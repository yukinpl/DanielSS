using System.Runtime.InteropServices ;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DanielSS
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent() ;

            timer.Enabled = true ;
            HideForm() ;
        }

        private struct Rect
        {
            public int Left
            {
                get ;
                set ; 
            }

            public int Top
            {
                get ;
                set ;
            }

            public int Right
            {
                get ;
                set ;
            }

            public int Bottom
            {
                get ;
                set ;
            }
        }

        [DllImport( "user32.dll" )]
        private static extern bool GetWindowRect( IntPtr hwnd , ref Rect rect ) ;

        private bool colorToggle = false ;

        private Int16 toggleCnt = 0 ;

        private IntPtr prevHandle = IntPtr.Zero ;

        private bool isVisible = false ;

        public static bool isEnable = true ;

        private void timer_Tick( object sender , EventArgs e )
        {
            if( false == isEnable )
            {
                HideForm() ;
                return ;
            }

            Lib.IMEStatus status = Lib.GetIMEStatus() ;

            Color backColor ;
            Color textColor ;

            IntPtr handle = IntPtr.Zero;
            Lib.GetForegroundWindowsHandle( ref handle ) ;

            Rect rect = new Rect() ;
            GetWindowRect( handle , ref rect ) ;

            if( Lib.IMEStatus.Korean == status )
            {
                this.lableT.Text = "H";

                backColor = colorToggle == true ? Color.DeepPink : Color.White;
                textColor = colorToggle == true ? Color.White : Color.DeepPink;

                if( prevHandle != handle || false == isVisible )
                {
                    this.Location = new Point( rect.Right - this.Width - 13 , rect.Bottom - this.Height - 13 ) ;
                    prevHandle = handle ;
                }

                this.isVisible = true ;

                OpenForm() ;
            }
            else if( Lib.IMEStatus.English == status )
            {
                this.lableT.Text = "A" ;

                backColor = colorToggle == true ? Color.Black : Color.White ;
                textColor = colorToggle == true ? Color.White : Color.Black ;

                if( prevHandle != handle || false == isVisible )
                {
                    this.Location = new Point( rect.Right - this.Width - 13 , rect.Bottom - this.Height - 13 ) ;
                    prevHandle = handle ;
                }

                this.isVisible = true ;

                OpenForm() ; 
            }
            else
            {
                backColor = colorToggle == true ? Color.Black : Color.White ; 
                textColor = colorToggle == true ? Color.White : Color.Black ;
                this.lableT.Text = " " ;

                this.isVisible = false ;

                HideForm() ;
            }

            ++toggleCnt ;

            if( 5 < toggleCnt )
            {
                this.BackColor        = backColor ;
                this.lableT.ForeColor = textColor ;
                this.lableT.BackColor = backColor ;

                colorToggle = !colorToggle ;
                toggleCnt = 0 ;
            }
        }

        private void Status_Resize( object sender , EventArgs e )
        {
            Size = new Size( 40 , 40 ) ;
        }

        private Point mousePoint ;

        private void Status_MouseMove( object sender , MouseEventArgs e )
        {
            mousePoint = new Point( e.X , e.Y ) ;
        }

        private void Status_MouseDown( object sender , MouseEventArgs e )
        {
            if( ( e.Button & MouseButtons.Left ) == MouseButtons.Left )
            {
                Location = new Point( this.Left - ( mousePoint.X - e.X ) , this.Top - ( mousePoint.Y - e.Y ) ) ;
            }
        }

        private void lableT_MouseDown( object sender , MouseEventArgs e )
        {
            mousePoint = new Point( e.X , e.Y ) ;
        }

        private void lableT_MouseMove( object sender , MouseEventArgs e )
        {
            if( ( e.Button & MouseButtons.Left ) == MouseButtons.Left )
            {
                Location = new Point( this.Left - ( mousePoint.X - e.X ) , this.Top - ( mousePoint.Y - e.Y ) ) ;
            }
        }

        private void OpenForm()
        {
            this.Visible = false ;
            this.TopMost = true  ;
            this.ShowInTaskbar = false ;
            
            this.WindowState = FormWindowState.Normal ;
        }

        private void HideForm()
        {
            this.Visible = false ;
            this.TopMost = false ;
            this.ShowInTaskbar = false ;

            this.WindowState = FormWindowState.Minimized ;
        }
    }
}
