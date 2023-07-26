namespace DanielSS
{
    partial class Status
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lableT = new System.Windows.Forms.Label() ;
            this.SuspendLayout() ;
            // 
            // lableT
            // 
            this.lableT.AutoSize = true ;
            this.lableT.Font = new System.Drawing.Font( "맑은 고딕" , 9F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point ) ;
            this.lableT.Location = new System.Drawing.Point( 4 , 4 ) ;
            this.lableT.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
            this.lableT.Name = "lableT" ;
            this.lableT.Size = new System.Drawing.Size( 30 , 32 ) ;
            this.lableT.TabIndex = 0 ;
            this.lableT.Text = "A" ;
            this.lableT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter ;
            this.lableT.MouseDown += new System.Windows.Forms.MouseEventHandler( this.lableT_MouseDown ) ;
            this.lableT.MouseMove += new System.Windows.Forms.MouseEventHandler( this.lableT_MouseMove ) ;
            // 
            // Status
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None ;
            this.ClientSize = new System.Drawing.Size( 40 , 40 ) ;
            this.Controls.Add( this.lableT ) ;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None ;
            this.Margin = new System.Windows.Forms.Padding( 4 , 2 , 4 , 2 ) ;
            this.Name = "Status" ;
            this.Text = "IMEStatus" ;
            this.TopMost = true ;
            this.Resize += new System.EventHandler( this.Status_Resize ) ;
            this.ResumeLayout( false ) ;
            this.PerformLayout() ;

        }

        #endregion

        private Label lableT ;
    }
}