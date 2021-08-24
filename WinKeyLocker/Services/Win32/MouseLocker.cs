using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinKeyLocker.Services.Win32
{
    public class MouseLocker
    {
        private bool _isLockLeftMouse = false;

        private bool _isLockRightMouse = false;

        private bool _isLockMiddleMouse = false;

        ~MouseLocker()
        {
            Stop();
        }

        public void Start(bool lockLeftMouse, bool lockRightMouse, bool lockMiddleMouse)
        {
            _isLockLeftMouse = lockLeftMouse;
            _isLockRightMouse = lockRightMouse;
            _isLockMiddleMouse = lockMiddleMouse;
            LowLevelMouseProc _proc = HookCallback;
            _hookID = SetHook(_proc);
        }

        public void Stop()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private IntPtr _hookID = IntPtr.Zero;

        private IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                  GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(
          int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var mouseButton = (MouseMessages)wParam;

                if (_isLockLeftMouse && mouseButton == MouseMessages.WM_LBUTTONDOWN)
                {
                    return (IntPtr)1;
                }

                if (_isLockRightMouse && (mouseButton == MouseMessages.WM_RBUTTONDOWN || mouseButton == MouseMessages.WM_RBUTTONUP))
                {
                    return (IntPtr)1;
                }

                if (_isLockMiddleMouse && (mouseButton == MouseMessages.WM_MOUSEWHEEL || mouseButton == MouseMessages.WM_MBUTTONDOWN))
                {
                    return (IntPtr)1;
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MBUTTONDOWN = 0x0207, // middle button down
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}