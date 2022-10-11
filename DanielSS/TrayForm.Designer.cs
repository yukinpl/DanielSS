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
            this.HideButton = new System.Windows.Forms.Button();
            this.chkEnableFunc = new System.Windows.Forms.CheckBox();
            this.chkEnableDisplay = new System.Windows.Forms.CheckBox();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DanielSS v2.2.1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(197, 13);
            this.HideButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(48, 37);
            this.HideButton.TabIndex = 5;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // chkEnableFunc
            // 
            this.chkEnableFunc.AutoSize = true;
            this.chkEnableFunc.Checked = true;
            this.chkEnableFunc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableFunc.Location = new System.Drawing.Point(8, 13);
            this.chkEnableFunc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chkEnableFunc.Name = "chkEnableFunc";
            this.chkEnableFunc.Size = new System.Drawing.Size(176, 19);
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
            this.chkEnableDisplay.Location = new System.Drawing.Point(8, 33);
            this.chkEnableDisplay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chkEnableDisplay.Name = "chkEnableDisplay";
            this.chkEnableDisplay.Size = new System.Drawing.Size(111, 19);
            this.chkEnableDisplay.TabIndex = 3;
            this.chkEnableDisplay.Text = "한/영 상태 표시";
            this.chkEnableDisplay.UseVisualStyleBackColor = true;
            this.chkEnableDisplay.CheckedChanged += new System.EventHandler(this.chkEnableDisplay_CheckedChanged);
            // 
            // txtMargin
            // 
            this.txtMargin.Location = new System.Drawing.Point(153, 31);
            this.txtMargin.MaxLength = 2;
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.ShortcutsEnabled = false;
            this.txtMargin.Size = new System.Drawing.Size(31, 23);
            this.txtMargin.TabIndex = 4;
            this.txtMargin.Text = "0";
            this.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMargin.TextChanged += new System.EventHandler(this.txtMargin_TextChanged);
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 62);
            this.Controls.Add(this.txtMargin);
            this.Controls.Add(this.chkEnableDisplay);
            this.Controls.Add(this.chkEnableFunc);
            this.Controls.Add(this.HideButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "TrayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrayForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TrayForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private Button HideButton;
        private CheckBox chkEnableFunc;
        private CheckBox chkEnableDisplay;
        private TextBox txtMargin;
    }
}