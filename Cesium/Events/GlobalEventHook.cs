using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using test.Events;

namespace test.events
{
    public class GlobalEventHook : IDisposable
    {
        private readonly Win32.LowLevelKeyboardProc _keyboardProc;
        private readonly Win32.LowLevelMouseProc _mouseProc;
        private IntPtr _keyboardHookId = IntPtr.Zero;
        private IntPtr _mouseHookId = IntPtr.Zero;

        public event EventHandler<ExtendedKeyEventArgs> KeyDown;
        public event EventHandler<MouseEventArgs> MouseDown;

        public GlobalEventHook()
        {
            _keyboardProc = KeyboardHookCallback;
            _mouseProc = MouseHookCallback;

            _keyboardHookId = SetKeyboardHook(_keyboardProc);
            _mouseHookId = SetMouseHook(_mouseProc);
        }

        public void Dispose()
        {
            Win32.UnhookWindowsHookEx(_keyboardHookId);
            Win32.UnhookWindowsHookEx(_mouseHookId);
        }

        private IntPtr SetKeyboardHook(Win32.LowLevelKeyboardProc proc)
        {
            return Win32.SetWindowsHookEx(Win32.WH_KEYBOARD_LL, proc, IntPtr.Zero, 0);
        }

        private IntPtr SetMouseHook(Win32.LowLevelMouseProc proc)
        {
            return Win32.SetWindowsHookEx(Win32.WH_MOUSE_LL, proc, IntPtr.Zero, 0);
        }

        private IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)Win32.WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                bool ctrlKeyDown = (Win32.GetAsyncKeyState(Keys.ControlKey) & 0x8000) != 0;
                bool altKeyDown = (Win32.GetAsyncKeyState(Keys.Menu) & 0x8000) != 0;
                bool shiftKeyDown = (Win32.GetAsyncKeyState(Keys.ShiftKey) & 0x8000) != 0;
                ExtendedKeyEventArgs extendedArgs = new ExtendedKeyEventArgs((Keys)vkCode, ctrlKeyDown, altKeyDown, shiftKeyDown);

                OnKeyDown(extendedArgs);
            }
            return Win32.CallNextHookEx(_keyboardHookId, nCode, wParam, lParam);
        }

        private IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)Win32.WM_LBUTTONDOWN || wParam == (IntPtr)Win32.WM_RBUTTONDOWN))
            {
                Win32.MSLLHOOKSTRUCT hookStruct = Marshal.PtrToStructure<Win32.MSLLHOOKSTRUCT>(lParam);
                int xPos = hookStruct.pt.x;
                int yPos = hookStruct.pt.y;

                if (wParam == (IntPtr)Win32.WM_LBUTTONDOWN)
                    OnMouseDown(new MouseEventArgs(MouseButtons.Left, 1, xPos, yPos, 0));
                else
                    OnMouseDown(new MouseEventArgs(MouseButtons.Right, 1, xPos, yPos, 0));
            }
            return Win32.CallNextHookEx(_mouseHookId, nCode, wParam, lParam);
        }


        protected virtual void OnKeyDown(ExtendedKeyEventArgs e)
        {
            KeyDown?.Invoke(this, e);
        }

        protected virtual void OnMouseDown(MouseEventArgs e)
        {
            MouseDown?.Invoke(this, e);
        }

    }

}