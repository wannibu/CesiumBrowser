using System;
using System.Windows.Forms;

namespace Cesium.Utils
{
    public class WindowHelper
    {
        public static bool IsForegroundWindow(Form form)
        {
            int currentThreadId = Win32.GetCurrentThreadId();
            int formThreadId;

            Win32.GetWindowThreadProcessId(form.Handle, out formThreadId);

            if (formThreadId == currentThreadId)
                return true;

            if (formThreadId != 0 && currentThreadId != formThreadId)
            {
                Win32.AttachThreadInput(formThreadId, currentThreadId, true);
                bool result = IsWindowFocused(form.Handle);
                Win32.AttachThreadInput(formThreadId, currentThreadId, false);
                return result;
            }

            return false;
        }

        private static bool IsWindowFocused(IntPtr handle)
        {
            IntPtr focusedWindow = Win32.GetForegroundWindow();
            return (focusedWindow == handle);
        }

        public static void DisableMouse()
        {
            Win32.BlockInput(true);
        }

        public static void EnableMouse()
        {
            Win32.BlockInput(false);
        }

        public static void SimulateKeyPress(Keys key, bool ctrl = false, bool shift = false, bool alt = false)
        {
            if (ctrl) SendKeys.Send("^");
            if (shift) SendKeys.Send("+");
            if (alt) SendKeys.Send("%");

            SendKeys.Send(key.ToString());
        }

        public static void SimulateKeyPressWait(Keys key, bool ctrl = false, bool shift = false, bool alt = false)
        {
            if (ctrl) SendKeys.SendWait("^");
            if (shift) SendKeys.SendWait("+");
            if (alt) SendKeys.SendWait("%");

            SendKeys.SendWait(key.ToString());
        }

    }

}