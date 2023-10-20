using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/// <summary>
/// Wind32API����
/// </summary>
public class Win32
{
    public const int WS_EX_TRANSPARENT = 0x00000020;
    public const int WS_EX_LAYERED = 0x00080000;
    public const int WS_MINIMIZEBOX = 0x00020000;
    public const int HT_CAPTION = 0x2;
    public const int GWL_EXSTYLE = -20;
    public const int GCL_STYLE = (-26);
    public const int CS_DropSHADOW = 0x20000;
    public const int CS_DROPSHADOW = 0x00020000;
    public const int WM_NCCALCSIZE = 0x83;
    public const int WM_NCHITTEST = 0x84;
    public const int WM_NCPAINT = 0x0085;
    public const int WM_KEYDOWN = 0x0100;
    public const int WM_KEYUP = 0x0101;
    public const int WM_LBUTTONDOWN = 0x201;
    public const int WM_RBUTTONDOWN = 0x204;
    public const int WH_KEYBOARD_LL = 13;
    public const int WH_MOUSE_LL = 14;
    public const int DWMWA_NCRENDERING_POLICY = 2;
    public const int DWMNCRP_ENABLED = 2;
    public const int ULW_ALPHA = 2;
    public const int HTLEFT = 10;
    public const int HTRIGHT = 11;
    public const int HTTOP = 12;
    public const int HTTOPLEFT = 13;
    public const int HTTOPRIGHT = 14;
    public const int HTBOTTOM = 15;
    public const int HTBOTTOMLEFT = 0x10;
    public const int HTBOTTOMRIGHT = 17;
    public const byte AC_SRC_OVER = 0;
    public const byte AC_SRC_ALPHA = 1;

    [StructLayout(LayoutKind.Sequential)]
    public struct Size
    {
        public Int32 cx;
        public Int32 cy;

        public Size(Int32 x, Int32 y)
        {
            cx = x;
            cy = y;
        }
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BLENDFUNCTION
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct KBDLLHOOKSTRUCT
    {
        public uint vkCode;
        public uint scanCode;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public Int32 x;
        public Int32 y;

        public Point(Int32 x, Int32 y)
        {
            this.x = x;
            this.y = y;
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct MSLLHOOKSTRUCT
    {
        public Point pt;
        public uint mouseData;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }
    public struct MARGINS
    {
        public int leftWidth;
        public int rightWidth;
        public int topHeight;
        public int bottomHeight;
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    public static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

    public const Int32 AW_HOR_POSITIVE = 0x00000001;// ��������ʾ
    public const Int32 AW_HOR_NEGATIVE = 0x00000002;// ���ҵ�����ʾ
    public const Int32 AW_VER_POSITIVE = 0x00000004;// ���ϵ�����ʾ
    public const Int32 AW_VER_NEGATIVE = 0x00000008;// ���µ�����ʾ
    public const Int32 AW_CENTER = 0x00000010;// ��ʹ����AW_HIDE��־����ʹ���������ص������������ڣ�����ʹ����������չ����չ������
    public const Int32 AW_HIDE = 0x00010000;// ���ش��ڣ�ȱʡ����ʾ����
    public const Int32 AW_ACTIVATE = 0x00020000;// ����ڡ���ʹ����AW_HIDE��־����ʹ�������־
    public const Int32 AW_SLIDE = 0x00040000;// ʹ�û������͡�ȱʡ��Ϊ�����������͡���ʹ��AW_CENTER��־ʱ�������־�ͱ�����
    public const Int32 AW_BLEND = 0x00080000;// ���뵭��

    /// <summary>
    /// ִ�ж���
    /// </summary>
    /// <param name="whnd">�ؼ����</param>
    /// <param name="dwtime">����ʱ��</param>
    /// <param name="dwflag">�����������</param>
    /// <returns>boolֵ�������Ƿ�ɹ�</returns>
    [DllImport("user32")]
    public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

    /// <summary>
    /// <para>�ú�����ָ������Ϣ���͵�һ���������ڡ�</para>
    /// <para>�˺���Ϊָ���Ĵ��ڵ��ô��ڳ���ֱ�����ڳ���������Ϣ�ٷ��ء�</para>
    /// <para>������PostMessage��ͬ����һ����Ϣ���͵�һ���̵߳���Ϣ���к��������ء�</para>
    /// return ����ֵ : ָ����Ϣ����Ľ���������������͵���Ϣ��
    /// </summary>
    /// <param name="hWnd">Ҫ������Ϣ���Ǹ����ڵľ��</param>
    /// <param name="Msg">��Ϣ�ı�ʶ��</param>
    /// <param name="wParam">����ȡ������Ϣ</param>
    /// <param name="lParam">����ȡ������Ϣ</param>
    [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessageA")]
    public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("user32")]
    public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

    [DllImport("gdi32.dll")]
    public static extern int CreateRoundRectRgn1(int x1, int y1, int x2, int y2, int x3, int y3);

    [DllImport("user32.dll")]
    public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, Boolean bRedraw);

    [DllImport("user32", EntryPoint = "GetWindowLong")]
    public static extern int GetWindowLong(IntPtr hwnd, int nIndex);

    [DllImport("user32.dll")]
    public static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

    [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
    public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

    [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
    public static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("gdi32.dll", ExactSpelling = true)]
    public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObj);

    [DllImport("user32.dll", ExactSpelling = true)]
    public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
    public static extern int DeleteDC(IntPtr hDC);

    [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
    public static extern int DeleteObject(IntPtr hObj);

    [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
    public static extern int UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, Int32 crKey, ref BLENDFUNCTION pblend, Int32 dwFlags);

    [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
    public static extern IntPtr ExtCreateRegion(IntPtr lpXform, uint nCount, IntPtr rgnData);

    [DllImport("user32.dll")]
    public static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

    [DllImport("user32.dll")]
    public static extern bool SetCaretPos(int x, int y);

    [DllImport("user32.dll")]
    public static extern bool ShowCaret(IntPtr hWnd);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr SetCursor(IntPtr hCursor);

    [DllImport("user32.dll")]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

    [DllImport("dwmapi.dll")]
    public static extern int DwmSetWindowAttribute(IntPtr hwnd, uint dwAttribute, ref int pvAttribute, uint cbAttribute);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int GetClassLong(IntPtr hwnd, int nIndex);

    [DllImport("dwmapi.dll")]
    public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

    [DllImport("dwmapi.dll")]
    public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

    [DllImport("dwmapi.dll")]
    public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

    [DllImport("User32.dll")]
    public static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);

    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(ref Point lpPoint);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

    [DllImport("user32.dll")]
    public static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);

    public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    public static extern short GetAsyncKeyState(Keys vKey);

    [DllImport("user32.dll")]
    public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

    [DllImport("user32.dll")]
    public static extern bool AttachThreadInput(int idAttach, int idAttachTo, bool fAttach);

    [DllImport("kernel32.dll")]
    public static extern int GetCurrentThreadId();

    [DllImport("user32.dll")]
    public static extern bool BlockInput(bool fBlockIt);

}