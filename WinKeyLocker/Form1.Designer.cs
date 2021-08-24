
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLockRightMouse = new System.Windows.Forms.CheckBox();
            this.chkLockLeftMouse = new System.Windows.Forms.CheckBox();
            this.chkLockMiddleMouse = new System.Windows.Forms.CheckBox();
            this.chkAutoStartup = new System.Windows.Forms.CheckBox();
            this.chkHideOnStartup = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOpenApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 373);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblHotkey);
            this.tabPage1.Controls.Add(this.picIcon);
            this.tabPage1.Controls.Add(this.lblError);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(114, 87);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(180, 20);
            this.lblHotkey.TabIndex = 4;
            this.lblHotkey.Text = "Press Ctrl + Alt + L to lock";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(168, 110);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(72, 61);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(8, 174);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(393, 41);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "(Error message)";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.chkAutoStartup);
            this.tabPage2.Controls.Add(this.chkHideOnStartup);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkLockRightMouse);
            this.groupBox1.Controls.Add(this.chkLockLeftMouse);
            this.groupBox1.Controls.Add(this.chkLockMiddleMouse);
            this.groupBox1.Location = new System.Drawing.Point(8, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse locks";
            // 
            // chkLockRightMouse
            // 
            this.chkLockRightMouse.AutoSize = true;
            this.chkLockRightMouse.Location = new System.Drawing.Point(203, 26);
            this.chkLockRightMouse.Name = "chkLockRightMouse";
            this.chkLockRightMouse.Size = new System.Drawing.Size(144, 24);
            this.chkLockRightMouse.TabIndex = 6;
            this.chkLockRightMouse.Text = "Lock right mouse";
            this.chkLockRightMouse.UseVisualStyleBackColor = true;
            // 
            // chkLockLeftMouse
            // 
            this.chkLockLeftMouse.AutoSize = true;
            this.chkLockLeftMouse.Location = new System.Drawing.Point(15, 26);
            this.chkLockLeftMouse.Name = "chkLockLeftMouse";
            this.chkLockLeftMouse.Size = new System.Drawing.Size(135, 24);
            this.chkLockLeftMouse.TabIndex = 5;
            this.chkLockLeftMouse.Text = "Lock left mouse";
            this.chkLockLeftMouse.UseVisualStyleBackColor = true;
            // 
            // chkLockMiddleMouse
            // 
            this.chkLockMiddleMouse.AutoSize = true;
            this.chkLockMiddleMouse.Location = new System.Drawing.Point(15, 56);
            this.chkLockMiddleMouse.Name = "chkLockMiddleMouse";
            this.chkLockMiddleMouse.Size = new System.Drawing.Size(152, 24);
            this.chkLockMiddleMouse.TabIndex = 7;
            this.chkLockMiddleMouse.Text = "Lock mouse wheel";
            this.chkLockMiddleMouse.UseVisualStyleBackColor = true;
            // 
            // chkAutoStartup
            // 
            this.chkAutoStartup.AutoSize = true;
            this.chkAutoStartup.Location = new System.Drawing.Point(8, 25);
            this.chkAutoStartup.Name = "chkAutoStartup";
            this.chkAutoStartup.Size = new System.Drawing.Size(178, 24);
            this.chkAutoStartup.TabIndex = 9;
            this.chkAutoStartup.Text = "Launch app on startup";
            this.chkAutoStartup.UseVisualStyleBackColor = true;
            // 
            // chkHideOnStartup
            // 
            this.chkHideOnStartup.AutoSize = true;
            this.chkHideOnStartup.Location = new System.Drawing.Point(8, 60);
            this.chkHideOnStartup.Name = "chkHideOnStartup";
            this.chkHideOnStartup.Size = new System.Drawing.Size(321, 24);
            this.chkHideOnStartup.TabIndex = 8;
            this.chkHideOnStartup.Text = "On app launch, minimize app to system tray";
            this.chkHideOnStartup.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(130, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(231, 100);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password to unlock (a-z, 0-9)";
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 52);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // menuOpenApp
            // 
            this.menuOpenApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuOpenApp.Name = "menuOpenApp";
            this.menuOpenApp.Size = new System.Drawing.Size(148, 24);
            this.menuOpenApp.Text = "&Open App";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(148, 24);
            this.menuExit.Text = "&Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 373);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.CheckBox chkAutoStartup;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

