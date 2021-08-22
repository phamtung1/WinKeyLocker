namespace WinKeyLocker.Models
{
    public class AppSetting
    {
        public bool HideOnStartup { get; set; } = true;

        public string UnlockPassword { get; set; } = "1234";

        public bool LockLeftMouse { get; set; } = false;

        public bool LockRightMouse { get; set; } = false;

        public bool LockMiddleMouse { get; set; } = false;

        public bool AutoStartUp { get; set; } = false;
    }
}