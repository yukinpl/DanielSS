using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        }

        private void HideForm()
        {
            this.ShowInTaskbar = false ;
            this.Visible = false ;
            this.TopMost = false ;
            this.WindowState = FormWindowState.Minimized ;
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
                Status.isEnable = true ;
            }
            else
            {
                Status.isEnable = false ;
            }
        }
    }
}