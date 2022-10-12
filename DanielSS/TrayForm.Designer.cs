namespace DanielSS
{
    partial class TrayForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null ;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose() ;
            }
            base.Dispose( disposing ) ;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( TrayForm ) ) ;
            this.notifyIcon = new System.Windows.Forms.NotifyIcon( this.components ) ;
            this.HideButton = new System.Windows.Forms.Button() ;
            this.chkEnableFunc = new System.Windows.Forms.CheckBox() ;
            this.chkEnableDisplay = new System.Windows.Forms.CheckBox() ;
            this.txtMargin = new System.Windows.Forms.TextBox() ;
            this.TerminateButton = new System.Windows.Forms.Button() ;
            this.labelMargin = new System.Windows.Forms.Label() ;
            this.SuspendLayout() ;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "notifyIcon.Icon" ) ) ) ;
            this.notifyIcon.Text = "DanielSS v2.3.2" ;
            this.notifyIcon.Visible = true ;
            this.notifyIcon.DoubleClick += new System.EventHandler( this.notifyIcon_DoubleClick ) ;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point( 197 , 29 ) ;
            this.HideButton.Margin = new System.Windows.Forms.Padding( 2 , 1 , 2 , 1 ) ;
            this.HideButton.Name = "HideButton" ;
            this.HideButton.Size = new System.Drawing.Size( 48 , 40 ) ;
            this.HideButton.TabIndex = 5 ;
            this.HideButton.Text = "Hide" ;
            this.HideButton.UseVisualStyleBackColor = true ;
            this.HideButton.Click += new System.EventHandler( this.HideButton_Click ) ;
            // 
            // chkEnableFunc
            // 
            this.chkEnableFunc.AutoSize = true ;
            this.chkEnableFunc.Checked = true ;
            this.chkEnableFunc.CheckState = System.Windows.Forms.CheckState.Checked ;
            this.chkEnableFunc.Location = new System.Drawing.Point( 10 , 14 ) ;
            this.chkEnableFunc.Margin = new System.Windows.Forms.Padding( 2 , 1 , 2 , 1 ) ;
            this.chkEnableFunc.Name = "chkEnableFunc" ;
            this.chkEnableFunc.Size = new System.Drawing.Size( 176 , 19 ) ;
            this.chkEnableFunc.TabIndex = 2 ;
            this.chkEnableFunc.Text = "Shift + Space 로 한/영 변환" ;
            this.chkEnableFunc.UseVisualStyleBackColor = true ;
            this.chkEnableFunc.CheckedChanged += new System.EventHandler( this.chkEnableFunc_CheckedChanged ) ;
            // 
            // chkEnableDisplay
            // 
            this.chkEnableDisplay.AutoSize = true ;
            this.chkEnableDisplay.Checked = true ;
            this.chkEnableDisplay.CheckState = System.Windows.Forms.CheckState.Checked ;
            this.chkEnableDisplay.Location = new System.Drawing.Point( 10 , 33 ) ;
            this.chkEnableDisplay.Margin = new System.Windows.Forms.Padding( 2 , 1 , 2 , 1 ) ;
            this.chkEnableDisplay.Name = "chkEnableDisplay" ;
            this.chkEnableDisplay.Size = new System.Drawing.Size( 111 , 19 ) ;
            this.chkEnableDisplay.TabIndex = 3 ;
            this.chkEnableDisplay.Text = "한/영 상태 표시" ;
            this.chkEnableDisplay.UseVisualStyleBackColor = true ;
            this.chkEnableDisplay.CheckedChanged += new System.EventHandler( this.chkEnableDisplay_CheckedChanged ) ;
            // 
            // txtMargin
            // 
            this.txtMargin.Location = new System.Drawing.Point( 104 , 51 ) ;
            this.txtMargin.MaxLength = 2 ;
            this.txtMargin.Name = "txtMargin" ;
            this.txtMargin.ShortcutsEnabled = false ;
            this.txtMargin.Size = new System.Drawing.Size( 31 , 23 ) ;
            this.txtMargin.TabIndex = 4 ;
            this.txtMargin.Text = "8" ;
            this.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center ;
            this.txtMargin.TextChanged += new System.EventHandler( this.txtMargin_TextChanged ) ;
            // 
            // TerminateButton
            // 
            this.TerminateButton.Font = new System.Drawing.Font( "맑은 고딕" , 7.875F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point ) ;
            this.TerminateButton.Location = new System.Drawing.Point( 197 , 4 ) ;
            this.TerminateButton.Margin = new System.Windows.Forms.Padding( 2 , 1 , 2 , 1 ) ;
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size( 48 , 22 ) ;
            this.TerminateButton.TabIndex = 6 ;
            this.TerminateButton.Text = "X" ;
            this.TerminateButton.UseVisualStyleBackColor = true ;
            this.TerminateButton.Click += new System.EventHandler( this.TerminateButton_Click ) ;
            // 
            // labelMargin
            // 
            this.labelMargin.AutoSize = true ;
            this.labelMargin.Location = new System.Drawing.Point( 36 , 52 ) ;
            this.labelMargin.Margin = new System.Windows.Forms.Padding( 2 , 0 , 2 , 0 ) ;
            this.labelMargin.Name = "labelMargin" ;
            this.labelMargin.Size = new System.Drawing.Size( 68 , 15 ) ;
            this.labelMargin.TabIndex = 7 ;
            this.labelMargin.Text = "ㄴMargin : " ;
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 7F , 15F ) ;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font ;
            this.ClientSize = new System.Drawing.Size( 252 , 76 ) ;
            this.Controls.Add( this.labelMargin ) ;
            this.Controls.Add( this.TerminateButton ) ;
            this.Controls.Add( this.txtMargin ) ;
            this.Controls.Add( this.chkEnableDisplay ) ;
            this.Controls.Add( this.chkEnableFunc ) ;
            this.Controls.Add( this.HideButton ) ;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ;
            this.Margin = new System.Windows.Forms.Padding( 2 , 1 , 2 , 1 ) ;
            this.Name = "TrayForm" ;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual ;
            this.Text = "Menu" ;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.TrayForm_FormClosing ) ;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.TrayForm_MouseDown ) ;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.TrayForm_MouseMove ) ;
            this.ResumeLayout( false ) ;
            this.PerformLayout() ;

        }

        #endregion

        private NotifyIcon notifyIcon ;
        private Button HideButton ;
        private CheckBox chkEnableFunc ;
        private CheckBox chkEnableDisplay ;
        private TextBox txtMargin ;
        private Button TerminateButton ;
        private Label labelMargin ;
    }
}