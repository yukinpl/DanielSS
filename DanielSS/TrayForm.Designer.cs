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
            this.notifyIcon.Text = "DanielSS v2.3.5" ;
            this.notifyIcon.Visible = true ;
            this.notifyIcon.DoubleClick += new System.EventHandler( this.notifyIcon_DoubleClick ) ;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point( 394 , 81 ) ;
            this.HideButton.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size( 96 , 67 ) ;
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
            this.chkEnableFunc.Location = new System.Drawing.Point( 20 , 30 ) ;
            this.chkEnableFunc.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
            this.chkEnableFunc.Name = "chkEnableFunc" ;
            this.chkEnableFunc.Size = new System.Drawing.Size( 345 , 36 ) ;
            this.chkEnableFunc.TabIndex = 2 ;
            this.chkEnableFunc.Text = "Shift + Space 로 한/영 변환" ;
            this.chkEnableFunc.UseVisualStyleBackColor = true ;
            this.chkEnableFunc.CheckedChanged += new System.EventHandler( this.chkEnableFunc_CheckedChanged ) ;
            // 
            // chkEnableDisplay
            // 
            this.chkEnableDisplay.AutoSize = true ;
            this.chkEnableDisplay.Checked = true  ;
            this.chkEnableDisplay.CheckState = System.Windows.Forms.CheckState.Checked ;
            this.chkEnableDisplay.Location = new System.Drawing.Point( 20 , 70 ) ;
            this.chkEnableDisplay.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
            this.chkEnableDisplay.Name = "chkEnableDisplay" ;
            this.chkEnableDisplay.Size = new System.Drawing.Size( 216 , 36 ) ;
            this.chkEnableDisplay.TabIndex = 3 ;
            this.chkEnableDisplay.Text = "한/영 상태 표시" ;
            this.chkEnableDisplay.UseVisualStyleBackColor = true ; 
            this.chkEnableDisplay.CheckedChanged += new System.EventHandler( this.chkEnableDisplay_CheckedChanged ) ;
            // 
            // txtMargin
            // 
            this.txtMargin.Location = new System.Drawing.Point( 208 , 109 ) ;
            this.txtMargin.Margin = new System.Windows.Forms.Padding( 6 , 6 , 6 , 6 ) ;
            this.txtMargin.MaxLength = 2 ;
            this.txtMargin.Name = "txtMargin" ;
            this.txtMargin.ShortcutsEnabled = false ;
            this.txtMargin.Size = new System.Drawing.Size( 58 , 39 ) ;
            this.txtMargin.TabIndex = 4 ;
            this.txtMargin.Text = "8" ;
            this.txtMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center ;
            this.txtMargin.TextChanged += new System.EventHandler( this.txtMargin_TextChanged ) ;
            // 
            // TerminateButton
            // 
            this.TerminateButton.Font = new System.Drawing.Font( "맑은 고딕" , 7.875F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point ) ;
            this.TerminateButton.Location = new System.Drawing.Point( 394 , 30 ) ;
            this.TerminateButton.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
            this.TerminateButton.Name = "TerminateButton" ;
            this.TerminateButton.Size = new System.Drawing.Size( 96 , 47 ) ;
            this.TerminateButton.TabIndex = 6 ;
            this.TerminateButton.Text = "X" ;
            this.TerminateButton.UseVisualStyleBackColor = true ;
            this.TerminateButton.Click += new System.EventHandler( this.TerminateButton_Click ) ;
            // 
            // labelMargin
            // 
            this.labelMargin.AutoSize = true ;
            this.labelMargin.Location = new System.Drawing.Point( 72 , 111 ) ;
            this.labelMargin.Margin = new System.Windows.Forms.Padding( 4 , 0 , 4 , 0 ) ;
            this.labelMargin.Name = "labelMargin" ;
            this.labelMargin.Size = new System.Drawing.Size( 135 , 32 ) ;
            this.labelMargin.TabIndex = 7 ;
            this.labelMargin.Text = "ㄴMargin : " ;
            // 
            // TrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 14F , 32F ) ;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font ;
            this.ClientSize = new System.Drawing.Size( 504 , 162 ) ;
            this.Controls.Add( this.labelMargin ) ;
            this.Controls.Add( this.TerminateButton ) ;
            this.Controls.Add( this.txtMargin ) ;
            this.Controls.Add( this.chkEnableDisplay ) ;
            this.Controls.Add( this.chkEnableFunc ) ;
            this.Controls.Add( this.HideButton ) ;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ;
            this.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
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