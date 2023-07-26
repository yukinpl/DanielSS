using System.Runtime.InteropServices ;

namespace DanielSS
{
    public partial class Status : Form
    {
        #region Loading Dlls
        [DllImport( "user32.dll" )]
        static extern IntPtr GetDpiForWindow( IntPtr handle ) ;
        #endregion

        delegate void TimerDelegate() ;

        private void TimerCallBack( object? status )
        {
            BeginInvoke( new TimerDelegate( timerTick ) ) ;
        }

        private static System.Threading.Timer? timer ;

        private void _StopTimer()
        {
            if( timer is null )
            {
                return ;
            }

            HideForm() ;
            timer.Change( System.Threading.Timeout.Infinite , System.Threading.Timeout.Infinite ) ;
            
        }

        public static void StopTimer()
        {
            isEnable = false ;
        }

        public static void BeginTimer()
        {
            if( timer is null )
            {
                return;
            }

            timer.Change( 0 , 500 ) ;
            isEnable = true ;
        }

        public Status()
        {
            InitializeComponent() ;

            timer = new System.Threading.Timer( TimerCallBack ) ;
            BeginTimer() ;
            
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

        private IntPtr prevHandle = IntPtr.Zero ;

        private bool isVisible = false ;

        public static bool isEnable = true ;

        public static int margin = 8 ;

        private void timerTick()
        {
            if( false == isEnable )
            {
                _StopTimer() ;
                return ; 
            }

            /*
            if( false == Lib.GetIMEActive() )
            {
                HideForm();
                return ;
            }
            */

            Lib.IMEStatus status = Lib.GetIMEStatus() ;

            Color backColor ;
            Color textColor ;

            IntPtr handle = IntPtr.Zero ;
            string name = "" ;
            Lib.GetForegroundWindowsHandleAndName( ref handle , ref name ) ;

            Rect rect = new() ;
            GetWindowRect( handle , ref rect ) ;


            if( Lib.IMEStatus.Korean == status )
            {
                this.lableT.Text = "H";

                backColor = colorToggle == true ? Color.DeepPink : Color.White ;
                textColor = colorToggle == true ? Color.White : Color.DeepPink ;

                if( prevHandle != handle || false == isVisible )
                {
                    this.Location = new Point( rect.Right - this.Width - margin , rect.Bottom - this.Height - margin ) ;
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
                    this.Location = new Point( rect.Right - this.Width - margin , rect.Bottom - this.Height - margin ) ;
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


            this.BackColor        = backColor ;
            this.lableT.ForeColor = textColor ;
            this.lableT.BackColor = backColor ;

            
            colorToggle = !colorToggle ;

        }

        private void Status_Resize( object sender , EventArgs e )
        {
            IntPtr ptr = GetDpiForWindow( this.Handle ) ;

            if( ptr == IntPtr.Zero )
            {
                // ERROR
            }

            Double rate = ptr.ToInt32() / 96.0 ;

            Int32 baseSize = 20 ;
            Int32 newSize = ( Int32 )( baseSize * rate ) ;

            if( 1 == rate )
            {
                newSize = 22 ;
            }

            Size = new Size( newSize , newSize ) ;
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
            this.Visible = true ;
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
