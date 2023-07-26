

namespace DanielSS
{
    public partial class TrayForm : Form
    {
        public TrayForm()
        {
            InitializeComponent() ;

            chkEnableFunc.Checked = true ;
            chkEnableDisplay.Checked = true ;

            HideForm() ;
            Lib.SetRunMode( true ) ;
            bool isAble = Lib.SetHook() ;

            if( false == isAble )
            {
                this.Close() ;
            }
        }

        private void OpenForm()
        {
            this.ShowInTaskbar = false ;
            this.Visible = true ;
            this.TopMost = true ; 
            this.WindowState = FormWindowState.Normal ;

            Status.StopTimer() ;
        }

        private void HideForm()
        {
            this.ShowInTaskbar = false ;
            this.Visible = false ;
            this.TopMost = false ;
            this.WindowState = FormWindowState.Minimized ;

            if( true == Status.isEnable )
            {
                Status.BeginTimer() ;
            }
        }

        private void exitToolStripMenuItem_Click( object sender , EventArgs e )
        {
            this.Close() ;
        }

        private void notifyIcon_DoubleClick( object sender , EventArgs e )
        {
            OpenForm() ;
        }

        private void setToolStripMenuItem_Click( object sender , EventArgs e )
        {
            OpenForm() ;
        }

        private void HideButton_Click( object sender , EventArgs e )
        {
            HideForm() ;
        }

        private void TrayForm_FormClosing( object sender , FormClosingEventArgs e )
        {
            Lib.UnHook() ;
        }

        private void chkEnableFunc_CheckedChanged( object sender , EventArgs e )
        {
            if( true == chkEnableFunc.Checked )
            {
                Lib.SetRunMode( true ) ;
            }
            else
            {
                Lib.SetRunMode( false ) ;
            }
        }

        private Point mousePoint ;

        private void TrayForm_MouseDown( object sender , MouseEventArgs e )
        {
            mousePoint = new Point( e.X , e.Y ) ;
        }

        private void TrayForm_MouseMove( object sender , MouseEventArgs e )
        {
            if( ( e.Button & MouseButtons.Left ) == MouseButtons.Left )
            {
                Location = new Point( this.Left - ( mousePoint.X - e.X ) , this.Top - ( mousePoint.Y - e.Y ) ) ;
            }
        }

        private void chkEnableDisplay_CheckedChanged( object sender , EventArgs e )
        {
            if( true == chkEnableDisplay.Checked )
            {
                txtMargin.Enabled = true ;
                Status.isEnable = true ;
            }
            else
            {
                txtMargin.Enabled = false ;
                Status.isEnable = false ;
            }
        }

        private void txtMargin_TextChanged( object sender, EventArgs e )
        {
            if( 0 == txtMargin.Text.Length )
            {
                txtMargin.Text = "0";
            }

            UInt32 margin = 0 ;

            try
            {
                margin = Convert.ToUInt32(txtMargin.Text);
            }
            catch ( FormatException )
            {
                txtMargin.Text = "0" ;
                
            }
            catch ( OverflowException )
            {
                txtMargin.Text = "0" ;
            }

            Status.margin = ( int ) margin ; 
        }

        private void TerminateButton_Click( object sender , EventArgs e )
        {
            if( true == Application.MessageLoop )
            {
                Application.Exit() ;
            }
            else
            {
                Environment.Exit( 1 ) ;
            }
        }
    }
}