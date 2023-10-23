using System;
using System.Drawing;
using System.Windows.Forms;
using Cesium.Events;

namespace Cesium.CustomForms
{
    public partial class PopUpForm : Form
    {
        private bool borderStyle;
        private GlobalEventHook _globalEventHook;

        public PopUpForm(bool borderStyle = true, bool clickToClose = true)
        {
            this.borderStyle = borderStyle;
            InitializeComponent();
            TopMost = true;
            ShowInTaskbar = false;

            if (clickToClose)
            {
                _globalEventHook = new GlobalEventHook();
                _globalEventHook.MouseDown += _globalEventHook_MouseDown;
            }
        }
        public void SetControl(Control control)
        {
            Size = control.Size;
            control.Dock = DockStyle.Fill;
            Main.Controls.Add(control);
        }

        private void _globalEventHook_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rectangle = new Rectangle(this.Location, this.Size);
            if (!rectangle.Contains(e.Location) && Main.Controls.Count > 0)
            {
                Main.Controls.Clear();
                this.Visible = false;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!borderStyle)
                    cp.ClassStyle |= Win32.CS_DROPSHADOW;
                return cp;
            }
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
            if (borderStyle)
                switch (m.Msg)
                {
                    case Win32.WM_NCPAINT:    // box shadow
                        var v = 2;
                        Win32.DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        Win32.DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                        break;
                    default:
                        break;
                }
            base.WndProc(ref m);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _globalEventHook?.Dispose();
        }

    }
}
