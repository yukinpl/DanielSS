namespace DanielSS
{
    partial class TrayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideButton = new System.Windows.Forms.Button();
            this.chkEnableFunc = new System.Windows.Forms.CheckBox();
            this.chkEnableDisplay = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DanielSS v1.0";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 80);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(125, 38);
            this.setToolStripMenuItem.Text = "Set";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(384, 28);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(97, 78);
            this.HideButton.TabIndex = 1;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // chkEnableFunc
            // 
            this.chkEnableFunc.AutoSize = true;
            this.chkEnableFunc.Location = new System.Drawing.Point(33, 28);
            this.chkEnableFunc.Name = "chkEnableFunc";
            this.chkEnableFunc.Size = new System.Drawing.Size(345, 36);
            this.chkEnableFunc.TabIndex = 2;
            this.chkEnableFunc.Text = "Shift + Space 로 한/영 변환";
            this.chkEnableFunc.UseVisualStyleBackColor = true;
            this.chkEnableFunc.CheckedChanged += new System.EventHandler(this.chkEnableFunc_CheckedChanged);
            // 
            // chkEnableDisplay
            // 
            this.chkEnableDisplay.AutoSize = true;
            this.chkEnableDisplay.Checked = true;
            this.chkEnableDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableDisplay.Location = new System.Drawing.Point(33, 70);
            this.chkEnableDisplay.Name = "chkEnableDisplay";
            this.chkEnableDisplay.Size = new System.Drawing.Size(216, 36);
            this.chkEnableDisplay.TabIndex = 3;
            this.chkEnableDisplay.Text = "한/영 상태 표시";
            this.chkEnableDisplay.UseVisualStyleBackColor = true;
            this.chkEnableDisplay.CheckedChanged += new System.EventHandler(this.chkEnableDisplay_CheckedChanged);
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 136);
            this.Controls.Add(this.chkEnableDisplay);
            this.Controls.Add(this.chkEnableFunc);
            this.Controls.Add(this.HideButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "TrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrayForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TrayForm_MouseMove);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem setToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button HideButton;
        private CheckBox chkEnableFunc;
        private CheckBox chkEnableDisplay;
    }
}