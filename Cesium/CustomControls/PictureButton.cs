using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public class PictureButton : PictureBox
    {
        public bool isCircle { get; set; }
        public bool defaultBackImage { get; set; }
        public int size { get; set; }
        public Point point { get; set; }

        public Color MouseOverBackColor { get; set; }
        public Color MouseClickBackColor { get; set; }
        public Color MouseLeaveBackColor { get; set; }
        public Image MouseOverBackImage { get; set; }
        public Image MouseClickBackImage { get; set; }
        public Image MouseLeaveBackImage { get; set; }

        public PictureButton()
        {
            Margin = new Padding(0);
            BackgroundImageLayout = ImageLayout.Center;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (isCircle)
            {
                GraphicsPath circle = new GraphicsPath();
                circle.AddEllipse(new Rectangle(point.X, point.Y, size, size));
                this.CreateGraphics().SmoothingMode = SmoothingMode.HighQuality;
                this.Region = new Region(circle);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            BackColor = MouseOverBackColor;
            if (!defaultBackImage) BackgroundImage = MouseOverBackImage;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackColor = MouseLeaveBackColor;
            if (!defaultBackImage) BackgroundImage = MouseLeaveBackImage;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackColor = MouseClickBackColor;
                if (!defaultBackImage) BackgroundImage = MouseClickBackImage;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackColor = MouseOverBackColor;
            }
            base.OnMouseUp(e);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_RBUTTONDOWN = 0x0204;
            const int WM_RBUTTONUP = 0x0205;

            if (m.Msg == WM_RBUTTONDOWN || m.Msg == WM_RBUTTONUP)
            {
                // 阻止右键单击事件的发生
                return;
            }

            base.WndProc(ref m);
        }


    }
}
