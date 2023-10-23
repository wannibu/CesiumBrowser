using Cesium.Enum;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public partial class MyTabControl : UserControl
    {
        public bool isActive { get; set; }
        public bool isNextActive { get; set; }
        public bool saveHistory { get; set; }
        public bool Top2Bottom { get; set; }
        public bool Left2Right { get; set; }
        public int insertLocation { get; set; }
        public int tabMarginLeft { get; set; }
        public Point lastClickLocation { get; set; }
        public Image favicon { get; set; }
        public MyPage page { get; set; }
        public FormTitle ParentTitle { get; set; }
        public MyTabOpenMode OpenMode { get; set; }

        public MyTabControl(string url = "", bool isSearch = false, bool saveHistory = true)
        {
            this.saveHistory = saveHistory;
            init();
            page = new MyPage(this, url, isSearch);
        }
        public MyTabControl(MyPage myPage, bool saveHistory = true)
        {
            this.saveHistory = saveHistory;
            init();
            page = myPage;
            page.tab = this;
        }

        private void init()
        {
            InitializeComponent();
            isActive = true;
            line.Visible = false;
            Top2Bottom = false;
            Left2Right = false;
            BackColor = Color.White;
            AddMouseEvents(this.Controls);
            this.AllowDrop = true;
        }

        private void MyTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isActive)
                {
                    ParentTitle.setActiveTab(this);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }
        private void MyTabControl_MouseEnter(object sender, EventArgs e)
        {
            if (!isActive)
            {
                line.Visible = false;
                BackColor = Color.FromArgb(243, 244, 246);
            }
        }
        private void MyTabControl_MouseLeave(object sender, EventArgs e)
        {
            if (!isActive && !isNextActive)
            {
                line.Visible = true;
                BackColor = this.Parent.BackColor;
            }
            if (!isActive && isNextActive)
            {
                BackColor = this.Parent.BackColor;
            }
        }
        private void AddMouseEvents(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.MouseEnter -= MyTabControl_MouseEnter;
                control.MouseLeave -= MyTabControl_MouseLeave;
                control.MouseEnter += MyTabControl_MouseEnter;
                control.MouseLeave += MyTabControl_MouseLeave;
                if (control.Name.Equals("btn_closeTab")) continue;
                control.MouseDown -= MyTabControl_MouseDown;
                control.MouseDown += MyTabControl_MouseDown;

                if (control.HasChildren)
                {
                    AddMouseEvents(control.Controls);
                }
            }
        }

        public void MyTabControl_Leave()
        {
            isActive = false;
            if (!isNextActive)
                line.Visible = true;

            int i = ParentTitle.TabControlList.IndexOf(this);
            if (i > 0)
            {
                if (!ParentTitle.TabControlList[i - 1].isActive)
                {
                    ParentTitle.TabControlList[i - 1].line.Visible = true;
                }
            }

        }

        private void MyTabControl_Load(object sender, EventArgs e)
        {
            DrawRectRgn();
        }
        private void MyTabControl_SizeChanged(object sender, EventArgs e)
        {
            DrawRectRgn();
            this.title.MaximumSize = new Size(this.panelRight.Left - this.title.Left + 10, title.MaximumSize.Height);
            this.title.Invalidate();
        }
        private void DrawRectRgn()
        {
            int radius = 5; // 圆角半径
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // 左上角圆弧
            path.AddLine(radius, 0, Width - radius, 0); // 上边直线
            path.AddArc(Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); // 右上角圆弧
            path.AddLine(Width, radius, Width, Height); // 右边直线
            path.AddLine(Width, Height, 0, Height); // 下边直线
            path.AddLine(0, Height, 0, radius); // 左边直线
            path.CloseFigure(); // 闭合路径
            this.Region = new Region(path);
        }

        private void title_Paint(object sender, PaintEventArgs e)
        {
            if (title.Right > panelRight.Left - 10)
            {
                Rectangle rectText = new Rectangle(title.ClientRectangle.Right - (int)(title.ClientRectangle.Right * 0.2210), title.ClientRectangle.Top, title.ClientRectangle.Width / 5, title.ClientRectangle.Height);
                using (LinearGradientBrush brush = new LinearGradientBrush(rectText, Color.Transparent, this.isActive ? Color.White : this.BackColor, 0, false))
                {
                    e.Graphics.FillRectangle(brush, rectText);
                }
            }
        }

    }
}
