using WinKeyLocker.Helpers;
using WinKeyLocker.Models;
using WinKeyLocker.Services;
using WinKeyLocker.Services.Win32;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WinKeyLocker
{
    public partial class Form1 : Form
    {
        private readonly LockService _lockService = new LockService();

        private AppSetting _appSetting;

        private bool _isForceClosing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.keyboard;
            notifyIcon1.Icon = Properties.Resources.keyboard;
            notifyIcon1.Text = Application.ProductName;
            picIcon.Image = Properties.Resources.keyboard.ToBitmap();

            notifyIcon1.Visible = true;

            this.Text = Application.ProductName + " " + Application.ProductVersion;

            _appSetting = AppSettingHelper.Load<AppSetting>();

            chkAutoStartup.Checked = _appSetting.AutoStartUp;
            txtPassword.Text = _appSetting.UnlockPassword;
            chkHideOnStartup.Checked = _appSetting.HideOnStartup;
            chkLockLeftMouse.Checked = _appSetting.LockLeftMouse;
            chkLockRightMouse.Checked = _appSetting.LockRightMouse;
            chkLockMiddleMouse.Checked = _appSetting.LockMiddleMouse;

            _lockService.Unlock += Hooker_Unlock;
            _lockService.HotKeyPressed += KeyboardService_HotKeyPressed;
            var hotkey = "Ctrl + Alt + L";
            var isSuccessful = _lockService.RegisterHotKey(Win32ModifierKeys.Control | Win32ModifierKeys.Alt, Keys.L);

            if (!isSuccessful)
            {
                isSuccessful = _lockService.RegisterHotKey(Win32ModifierKeys.Control | Win32ModifierKeys.Shift, Keys.L);
                hotkey = "Ctrl + Shift + L";
            }

            lblHotkey.Text = "Press  " + hotkey + " to lock";
            if (!isSuccessful)
            {
                lblError.Text = "Cannot register hotkey";
                lblError.Visible = true;
                lblHotkey.Font = new System.Drawing.Font(lblHotkey.Font, System.Drawing.FontStyle.Strikeout);
            }

            if (_appSetting.HideOnStartup)
            {
                this.Hide();

                notifyIcon1.ShowBalloonTip(1000, "App is running in background", lblHotkey.Text, ToolTipIcon.Info);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!_isForceClosing)
            {
                e.Cancel = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "App is running in background", lblHotkey.Text, ToolTipIcon.Info);
            }
        }

        private void KeyboardService_HotKeyPressed(object sender, KeyPressedEventArgs e)
        {
            StartLock();
        }

        private void Hooker_Unlock(object sender, EventArgs e)
        {
            StopLock();
        }

        private void StartLock()
        {
            if (_appSetting.LockLeftMouse || _appSetting.LockRightMouse || _appSetting.LockMiddleMouse)
            {
                _lockService.LockMouse(_appSetting.LockLeftMouse, _appSetting.LockRightMouse, _appSetting.LockMiddleMouse);
            }

            _lockService.SetUnlockPassword(_appSetting.UnlockPassword);
            _lockService.LockKeyboard();
            picIcon.Image = Properties.Resources.keyboard_locked.ToBitmap();
            notifyIcon1.Icon = Properties.Resources.keyboard_locked;
            notifyIcon1.ShowBalloonTip(1000, string.Empty, "Keyboard & mouse are locked. Type '" + _appSetting.UnlockPassword + "' to unlock.", ToolTipIcon.Info);
        }

        private void StopLock()
        {
            if (_appSetting.LockLeftMouse || _appSetting.LockRightMouse || _appSetting.LockMiddleMouse)
            {
                _lockService.UnlockMouse();
            }

            _lockService.UnlockKeyboard();
            notifyIcon1.Icon = Properties.Resources.keyboard;
            picIcon.Image = Properties.Resources.keyboard.ToBitmap();
            notifyIcon1.ShowBalloonTip(1000, string.Empty, "Keyboard & mouse are unlocked", ToolTipIcon.Info);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == menuOpenApp)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem == menuExit)
            {
                _isForceClosing = true;
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string password = GetValidPassword();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid password");
                return;
            }

            _appSetting.AutoStartUp = chkAutoStartup.Checked;

            StartupHelper.SetAutoStartup(_appSetting.AutoStartUp);
            
            _appSetting.HideOnStartup = chkHideOnStartup.Checked;
            _appSetting.UnlockPassword = password;
            _appSetting.LockLeftMouse = chkLockLeftMouse.Checked;
            _appSetting.LockRightMouse = chkLockRightMouse.Checked;
            _appSetting.LockMiddleMouse = chkLockMiddleMouse.Checked;

            AppSettingHelper.Save(_appSetting);
            _lockService.SetUnlockPassword(password);
            btnSave.Text = "Saved!";
            btnSave.Enabled = false;

            Task.Delay(1000).ContinueWith((task) => {
                MethodInvoker methodInvokerDelegate = delegate ()
                {
                    btnSave.Text = "Save";
                    btnSave.Enabled = true;
                };

                this.Invoke(methodInvokerDelegate);
            });
        }

        private string GetValidPassword()
        {
            var password = txtPassword.Text.Trim();

            var regexItem = new Regex("^[a-zA-Z0-9]+$");

            if (regexItem.IsMatch(password))
            {
                return password.ToLowerInvariant();
            }

            return string.Empty;
        }
    }
}