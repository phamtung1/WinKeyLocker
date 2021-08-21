using WinKeyLocker.Services.Win32;
using System;
using System.Windows.Forms;

namespace WinKeyLocker.Services
{
    public class LockService
    {
        private readonly MouseLocker _mouseLocker;

        private readonly KeyboardLocker _keyboardLocker;

        private readonly HotkeyRegister _hotkeyRegister;

        public event EventHandler Unlock;

        public event EventHandler<KeyPressedEventArgs> HotKeyPressed;

        public bool IsLocking { get; private set; } = false;

        public LockService()
        {
            _mouseLocker = new MouseLocker();
            _keyboardLocker = new KeyboardLocker();
            _hotkeyRegister = new HotkeyRegister();

            _keyboardLocker.Unlock += Win32Keyboard_Unlock;
            _hotkeyRegister.HotKeyPressed += HotkeyRegister_HotKeyPressed;
        }

        ~LockService()
        {
            _mouseLocker.Stop();
            _keyboardLocker.Unhook();
            _hotkeyRegister.Dispose();
        }

        public void LockMouse(bool lockLeftMouse, bool lockRightMouse, bool lockMiddleMouse)
        {
            _mouseLocker.Start(lockLeftMouse, lockRightMouse, lockMiddleMouse);
        }

        public void UnlockMouse()
        {
            _mouseLocker.Stop();
        }

        public bool RegisterHotKey(Win32ModifierKeys modifier, Keys key)
        {
            return _hotkeyRegister.RegisterHotKey(modifier, key);
        }

        public void SetUnlockPassword(string unlockPassword)
        {
            _keyboardLocker.SetUnlockPassword(unlockPassword);
        }

        public void LockKeyboard()
        {
            if (!IsLocking)
            {
                _keyboardLocker.Hook();
                IsLocking = true;
            }
        }

        public void UnlockKeyboard()
        {
            if (IsLocking)
            {
                _keyboardLocker.Unhook();
                IsLocking = false;
            }
        }

        #region Events

        private void HotkeyRegister_HotKeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (HotKeyPressed != null)
            {
                HotKeyPressed(sender, e);
            }
        }

        private void Win32Keyboard_Unlock(object sender, EventArgs e)
        {
            IsLocking = false;
            if (Unlock != null)
            {
                Unlock(sender, e);
            }
        }

        #endregion Events
    }
}