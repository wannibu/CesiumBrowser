using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public partial class MyForm : Form
    {
        private bool m_aeroEnabled;
        private FormWindowState lastState;

        public MyForm()
        {
            InitializeComponent();
            this.Resize += MyForm_Resize;
            this.DoubleBuffered = true;
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            this.MainBody.Location = new Point(2, 2);
            this.MainBody.Size = new Size(this.Width - 4, this.Height - 4);
            if (this.WindowState != lastState)
            {
                if (lastState != FormWindowState.Minimized)
                {
                    switch (this.WindowState)
                    {
                        case FormWindowState.Normal:
                            this.Title.setBtnMaxIcon(Properties.Resources.icons8_maximize_button_16);
                            this.Title.title_right_buttonGroup.Height -= 8;
                            this.Title.title_right_buttonGroup.Padding = new Padding(0, 0, 0, 0);
                            break;
                        case FormWindowState.Maximized:
                            this.Title.setBtnMaxIcon(Properties.Resources.icons8_restore_down_16);
                            this.Title.title_right_buttonGroup.Height += 8;
                            this.Title.title_right_buttonGroup.Padding = new Padding(0, 8, 0, 0);

                            break;
                    }
                }
                else
                {
                   this.Title.panelTab.resizePanelWidth();
                }
                lastState = this.WindowState;
            }

        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= Win32.CS_DROPSHADOW;

                cp.Style = cp.Style | Win32.WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                Win32.DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        Win32.MARGINS margins = new Win32.MARGINS()
        {
            bottomHeight = 1,
            leftWidth = 1,
            rightWidth = 1,
            topHeight = 1
        };
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_NCPAINT:    // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        Win32.DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        Win32.DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                case Win32.WM_NCHITTEST:
                    base.WndProc(ref m);
                    if (this.WindowState != FormWindowState.Maximized)
                    {
                        Point vPoint = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
                        vPoint = PointToClient(vPoint);
                        if (vPoint.X <= 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)Win32.HTTOPLEFT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)Win32.HTBOTTOMLEFT;
                            else m.Result = (IntPtr)Win32.HTLEFT;
                        else if (vPoint.X >= ClientSize.Width - 5)
                            if (vPoint.Y <= 5)
                                m.Result = (IntPtr)Win32.HTTOPRIGHT;
                            else if (vPoint.Y >= ClientSize.Height - 5)
                                m.Result = (IntPtr)Win32.HTBOTTOMRIGHT;
                            else m.Result = (IntPtr)Win32.HTRIGHT;
                        else if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Win32.HTTOP;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Win32.HTBOTTOM;
                    }

                    //无边框
                    if (m.Result.ToInt32() == Win32.HT_CAPTION)
                        m.Result = new IntPtr(Win32.HT_CAPTION);
                    return;
                default:
                    break;
            }

            if (m.Msg == Win32.WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                m.Result = new IntPtr(0xF0);   // Align client area to all borders
                return;
            }
            base.WndProc(ref m);
        }

        private void Title_MyMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void Title_MyMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
