﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinKeyLocker.Services.Win32
{
    public class KeyboardLocker
    {
        #region Constant, Structure and Delegate Definitions

        /// <summary>
        /// defines the callback type for the hook
        /// </summary>
        private delegate int keyboardHookProc(int code, int wParam, ref KeyboardHookStruct lParam);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private const int WM_SYSKEYDOWN = 0x104;
        private const int WM_SYSKEYUP = 0x105;

        #endregion Constant, Structure and Delegate Definitions

        private string _unlockPassword = string.Empty;

        private string _pressedKeys = string.Empty;

        /// <summary>
        /// Handle to the hook, need this to unhook and call the next hook
        /// </summary>
        private IntPtr _hookHandle = IntPtr.Zero;

        public event EventHandler Unlock;

        ~KeyboardLocker()
        {
            Unhook();
        }

        #region Public Methods

        public void SetUnlockPassword(string unlockPassword)
        {
            _unlockPassword = unlockPassword;
        }

        /// <summary>
        /// Installs the global hook
        /// </summary>
        public void Hook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            _hookHandle = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }


        /// <summary>
        /// Uninstalls the global hook
        /// </summary>
        public void Unhook()
        {
            UnhookWindowsHookEx(_hookHandle);
        }

        /// <summary>
        /// The callback for the keyboard hook
        /// </summary>
        /// <param name="code">The hook code, if it isn't >= 0, the function shouldn't do anyting</param>
        /// <param name="wParam">The event type</param>
        /// <param name="lParam">The keyhook event information</param>
        /// <returns></returns>
        private int hookProc(int code, int wParam, ref KeyboardHookStruct lParam)
        {
            if (code >= 0)
            {
                Keys key = (Keys)lParam.vkCode;

                if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && !string.IsNullOrEmpty(_unlockPassword))
                {
                    var character = KeyCodeConverter.KeyCodeToUnicode(key).ToLowerInvariant();
                    var newPressedKeys = _pressedKeys + character;

                    if (_unlockPassword == newPressedKeys)
                    {
                        _pressedKeys = string.Empty;
                        Unhook();
                        if (Unlock != null)
                        {
                            Unlock(this, new EventArgs());
                        }
                    }
                    else if (_unlockPassword.StartsWith(newPressedKeys))
                    {
                        _pressedKeys = newPressedKeys;
                    }
                    else if(_unlockPassword.StartsWith(character)) // user type password again
                    {
                        _pressedKeys = character;
                    }
                    else
                    {
                        _pressedKeys = string.Empty;
                    }

                    // Lock key
                    return 1;
                }
            }

            return CallNextHookEx(_hookHandle, code, wParam, ref lParam);
        }

        #endregion Public Methods

        #region DLL imports

        /// <summary>
        /// Sets the windows hook, do the desired event, one of hInstance or threadId must be non-null
        /// </summary>
        /// <param name="idHook">The id of the event you want to hook</param>
        /// <param name="callback">The callback.</param>
        /// <param name="hInstance">The handle you want to attach the event to, can be null</param>
        /// <param name="threadId">The thread you want to attach the event to, can be null</param>
        /// <returns>a handle to the desired hook</returns>
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

        /// <summary>
        /// Unhooks the windows hook.
        /// </summary>
        /// <param name="hInstance">The hook handle that was returned from SetWindowsHookEx</param>
        /// <returns>True if successful, false otherwise</returns>
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        /// <summary>
        /// Calls the next hook.
        /// </summary>
        /// <param name="idHook">The hook id</param>
        /// <param name="nCode">The hook code</param>
        /// <param name="wParam">The wparam.</param>
        /// <param name="lParam">The lparam.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyboardHookStruct lParam);

        /// <summary>
        /// Loads the library.
        /// </summary>
        /// <param name="lpFileName">Name of the library</param>
        /// <returns>A handle to the library</returns>
        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpFileName);

        #endregion DLL imports
    }
}