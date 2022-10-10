using System.Diagnostics ;

namespace DanielSS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            if( IsRunning( Process.GetCurrentProcess().ProcessName ) )
            {
                return ;
            }

            ApplicationConfiguration.Initialize() ;

            Form status = new Status() ;
            status.Size = new Size( 40 , 40 ) ;
            status.WindowState = FormWindowState.Normal ;
            status.ShowInTaskbar = false ;
            status.Visible = true ;

            Application.Run( new TrayForm() ) ;
        }

        static bool IsRunning( string processName )
        {
            bool isRunning = false ;

            Mutex mutex = new Mutex( true , processName , out isRunning ) ;

            return !isRunning ;
        }
    }
}