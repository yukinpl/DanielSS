using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DanielSS
{
    internal class Lib
    {
        private static bool isRun = true ;

        private delegate IntPtr LowLevelKeyboardProc( int code , IntPtr wParam , IntPtr lParam ) ;

        #region Loading Dlls

        [DllImport( "user32.dll" )]
        static extern IntPtr SetWindowsHookEx( int idHook , LowLevelKeyboardProc callback , IntPtr ptr , uint threadId ) ;

        [DllImport( "user32.dll" )]
        static extern bool UnhookWindowsHookEx( IntPtr ptr );

        [DllImport( "user32.dll" )]
        static extern IntPtr CallNextHookEx( IntPtr idHook , int nCode , int wParam , IntPtr lParam ) ;

        [DllImport( "user32.dll" )]
        static extern IntPtr GetForegroundWindow() ;

        [DllImport( "user32.dll" )]
        static extern IntPtr GetWindowTextW( IntPtr hwnd , ref string str , int maxCount ) ;

        [DllImport( "user32.dll" , CharSet = CharSet.Auto )]
        static extern IntPtr SendMessage( IntPtr hwnd , UInt32 msg , IntPtr wParam , IntPtr lParam ) ;

        [DllImport( "user32.dll" )]
        static extern void keybd_event( Byte vKey , Byte scanCode , UInt32 flag , ref int extInfo ) ;

        [DllImport( "user32.dll" )]
        static extern Int16 GetKeyState( int vKey ) ;

        [DllImport( "kernel32.dll" )]
        static extern IntPtr LoadLibrary( string lpFileName ) ;

        [DllImport( "imm32.dll" )]
        private static extern IntPtr ImmGetDefaultIMEWnd( IntPtr hwnd ) ;

        [DllImport( "imm32.dll" )]
        static extern IntPtr ImmReleaseContext( IntPtr hwnd , IntPtr himc ) ;

        [DllImport( "user32.dll" )]
        private static extern Int32 GetWindowThreadProcessId( IntPtr hWnd , out uint lpdwProcessId ) ;

        #endregion

        private static LowLevelKeyboardProc keyProc = HookProc ;

        private static IntPtr keyHook = IntPtr.Zero ;

        private static IntPtr HookProc( int code , IntPtr wParam , IntPtr lParam )
        {
            if( false == isRun )
            {
                return CallNextHookEx( keyHook , code , ( int ) wParam , lParam ) ;
            }

            if( 0 > code )
            {
                return CallNextHookEx( keyHook , code , ( int ) wParam , lParam ) ;
            }

            if( ( ( IntPtr ) 0x100 ) != wParam ) /* WM_KEYDOWN */
            {
                return CallNextHookEx( keyHook , code , ( int ) wParam , lParam ) ;
            }

            int vkCode = Marshal.ReadInt32( lParam ) ;
            bool isLShiftPressed = ( GetKeyState( 0xA0 /* VK_LSHIFT */ ) & 0x8000 ) != 0 ? true : false ;

            if( !( isLShiftPressed && vkCode == 0x20 /* VK_SPACE */ ) )  // VK_LSHIFT + VK_SPACE
            {
                return CallNextHookEx( keyHook , code , ( int ) wParam , lParam ) ;
            }

            IMEStatus status = GetIMEStatus() ;
            if( IMEStatus.Unknown == status )
            {
                return CallNextHookEx( keyHook , code , ( int ) wParam , lParam ) ;
            }

            SetIMEStatus() ;

            return ( IntPtr ) 1 ;
        }

        public static bool GetForegroundWindowsHandleAndName( ref IntPtr handle , ref string name )
        {
            handle = GetForegroundWindow() ;

            if( IntPtr.Zero == handle )
            {
                return false ;
            }

            uint pid;

            GetWindowThreadProcessId( handle , out pid ) ;

            bool isFound = false ; 

            foreach( Process p in Process.GetProcesses() )
            {
                if( pid == p.Id )
                {
                    isFound = true ;
                    name = p.ProcessName ;
                }
            }

            return isFound ; 
        }

        private static void SetIMEStatus()
        {
            const Int16 KEYEVENTF_EXT   = 0x0001 ;
            const Int16 KEYEVENTF_KEYDN = 0x0000 ;
            const Int16 KEYEVENTF_KEYUP = 0x0002 ;
            const Byte  VK_HANGUL       = 0x15   ;

            Int32 refInfo = 0 ;

            keybd_event( VK_HANGUL , 0x45 , KEYEVENTF_EXT | KEYEVENTF_KEYDN , ref refInfo ) ;
            keybd_event( VK_HANGUL , 0x45 , KEYEVENTF_EXT | KEYEVENTF_KEYUP , ref refInfo ) ;
        }

        public enum IMEStatus
        {
            Unknown = 0 ,
            Korean  = 1 ,
            English = 2 
        }

        public static IMEStatus GetIMEStatus()
        {
            IntPtr hwnd = IntPtr.Zero ;
            string name = "" ;
            if( false == GetForegroundWindowsHandleAndName( ref hwnd , ref name ) )
            {
                return IMEStatus.Unknown ;
            }

            IntPtr hime = ImmGetDefaultIMEWnd( hwnd ) ;
            IntPtr stat = SendMessage( hime , 643 /* WM_IME_CONTROL */ , new IntPtr( 0x5 ) , new IntPtr( 0 ) ) ;

            bool isKorean = ( stat.ToInt32() != 0 ) ? true : false ;

            return ( isKorean == true ) ? IMEStatus.Korean : IMEStatus.English ;
        }

        /*
        public static bool GetIMEActive()
        {
            IMEStatus prevStatus , currStatus ;

            prevStatus = GetIMEStatus() ;
            SetIMEStatus() ;
            currStatus = GetIMEStatus() ;
            SetIMEStatus() ;

            if( prevStatus != currStatus )
            {
                return true ;
            }

            return false  ;
        }
        */

        public static bool SetHook()
        {
            try
            {
                IntPtr ptr = LoadLibrary( "user32.dll" );
                keyHook = SetWindowsHookEx( 13 /* WM_KEYBOARD_LL */ , keyProc , ptr , 0 ) ;
            }
            catch( System.EntryPointNotFoundException e )
            {
                MessageBox.Show( e.Message ) ;
                return false ;
            }

            return true ;
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx( keyHook ) ;
        }

        public static void SetRunMode( bool mode )
        {
            isRun = mode ;
        }
    }
}
