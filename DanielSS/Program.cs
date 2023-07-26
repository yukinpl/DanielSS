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
            Process [] process = Process.GetProcesses() ;
            int cnt = 0 ; 

            foreach( Process p in process )
            {
                if( processName == p.ProcessName )
                {
                    ++cnt ;
                }

                if( cnt > 1 )
                {
                    return true ;
                }
                    
            }

            return false ;
        }
    }
}