
namespace WinKeyLocker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLock = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkHideOnStartup = new System.Windows.Forms.CheckBox();
            this.chkLockMiddleMouse = new System.Windows.Forms.CheckBox();
            this.chkLockRightMouse = new System.Windows.Forms.CheckBox();
            this.chkLockLeftMouse = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOpenApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLock.Location = new System.Drawing.Point(114, 149);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(185, 59);
            this.btnLock.TabIndex = 0;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 273);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblHotkey);
            this.tabPage1.Controls.Add(this.picIcon);
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Controls.Add(this.btnLock);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(119, 22);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(180, 20);
            this.lblHotkey.TabIndex = 4;
            this.lblHotkey.Text = "Press Ctrl + Alt + L to lock";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(173, 45);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(72, 61);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(8, 99);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(401, 41);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "(Error message)";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkHideOnStartup);
            this.tabPage2.Controls.Add(this.chkLockMiddleMouse);
            this.tabPage2.Controls.Add(this.chkLockRightMouse);
            this.tabPage2.Controls.Add(this.chkLockLeftMouse);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkHideOnStartup
            // 
            this.chkHideOnStartup.AutoSize = true;
            this.chkHideOnStartup.Location = new System.Drawing.Point(8, 18);
            this.chkHideOnStartup.Name = "chkHideOnStartup";
            this.chkHideOnStartup.Size = new System.Drawing.Size(321, 24);
            this.chkHideOnStartup.TabIndex = 8;
            this.chkHideOnStartup.Text = "On app launch, minimize app to system tray";
            this.chkHideOnStartup.UseVisualStyleBackColor = true;
            // 
            // chkLockMiddleMouse
            // 
            this.chkLockMiddleMouse.AutoSize = true;
            this.chkLockMiddleMouse.Location = new System.Drawing.Point(8, 132);
            this.chkLockMiddleMouse.Name = "chkLockMiddleMouse";
            this.chkLockMiddleMouse.Size = new System.Drawing.Size(152, 24);
            this.chkLockMiddleMouse.TabIndex = 7;
            this.chkLockMiddleMouse.Text = "Lock mouse wheel";
            this.chkLockMiddleMouse.UseVisualStyleBackColor = true;
            // 
            // chkLockRightMouse
            // 
            this.chkLockRightMouse.AutoSize = true;
            this.chkLockRightMouse.Location = new System.Drawing.Point(196, 102);
            this.chkLockRightMouse.Name = "chkLockRightMouse";
            this.chkLockRightMouse.Size = new System.Drawing.Size(144, 24);
            this.chkLockRightMouse.TabIndex = 6;
            this.chkLockRightMouse.Text = "Lock right mouse";
            this.chkLockRightMouse.UseVisualStyleBackColor = true;
            // 
            // chkLockLeftMouse
            // 
            this.chkLockLeftMouse.AutoSize = true;
            this.chkLockLeftMouse.Location = new System.Drawing.Point(8, 102);
            this.chkLockLeftMouse.Name = "chkLockLeftMouse";
            this.chkLockLeftMouse.Size = new System.Drawing.Size(135, 24);
            this.chkLockLeftMouse.TabIndex = 5;
            this.chkLockLeftMouse.Text = "Lock left mouse";
            this.chkLockLeftMouse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(231, 58);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password to unlock (a-zA-Z0-9)";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(417, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenApp,
            this.menuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 52);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // menuOpenApp
            // 
            this.menuOpenApp.Name = "menuOpenApp";
            this.menuOpenApp.Size = new System.Drawing.Size(146, 24);
            this.menuOpenApp.Text = "Open App";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(146, 24);
            this.menuExit.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 273);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyboardMouse Locker";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpenApp;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.CheckBox chkLockLeftMouse;
        private System.Windows.Forms.CheckBox chkLockRightMouse;
        private System.Windows.Forms.CheckBox chkLockMiddleMouse;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.CheckBox chkHideOnStartup;
    }
}

