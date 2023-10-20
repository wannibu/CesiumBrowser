using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Cesium.App.CefBrowser;
using Cesium.App.CefBrowser.Tab;
using Cesium.Utils;
using Cesium.View;

namespace Cesium.CustomControls
{
    public partial class FormTitle : UserControl
    {
        public List<MyTabControl> TabControlList { get; set; }

        private bool IsLBtnDownInTab = false;
        private Point pCtrlLastCoordinate = new Point(0, 0);
        private Point pCursorLastCoordinate = new Point(0, 0);
        private MyTabControl ctrl = null;
        private int enterX;
        private int enterY;

        public event EventHandler<MouseEventArgs> MyMouseDown;
        public event EventHandler<MouseEventArgs> MyMouseDoubleClick;
        public event EventHandler<EventArgs> BtnClick;

        public FormTitle()
        {
            InitializeComponent();
            this.TabControlList = new List<MyTabControl>();
            SetMouseDownEvent(this.Controls);
        }

        private void SetMouseDownEvent(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.Equals("title_right_buttonGroup") || control.Name.Equals("panelTab") || control.Name.StartsWith("btn"))
                    continue;
                control.MouseDown -= Control_MouseDown;
                control.MouseDown += Control_MouseDown;

                if (control.HasChildren)
                {
                    SetMouseDownEvent(control.Controls);
                }
            }
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            Control p = (Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1)
                {
                    MyMouseDown?.Invoke(sender, e);
                }
                else if (e.Clicks == 2)
                {
                    MyMouseDoubleClick?.Invoke(sender, e);
                }
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            switch (this.ParentForm.WindowState)
            {
                case FormWindowState.Normal:
                    this.ParentForm.WindowState = FormWindowState.Maximized;
                    break;
                case FormWindowState.Maximized:
                    this.ParentForm.WindowState = FormWindowState.Normal;
                    break;
                default: break;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }
        private void btn_addTab_Click(object sender, EventArgs e)
        {
            BtnClick?.Invoke(sender, e);
        }
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            BtnClick?.Invoke(sender, e);
        }
        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("关闭", (Control)sender);
        }
        private void btn_max_MouseHover(object sender, EventArgs e)
        {
            switch (this.ParentForm.WindowState)
            {
                case FormWindowState.Normal:
                    toolTip.Show("最大化", (Control)sender);
                    break;
                case FormWindowState.Maximized:
                    toolTip.Show("向下还原", (Control)sender);
                    break;
                default: break;
            }
        }
        private void btn_min_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("最小化", (Control)sender);
        }
        public void setBtnMaxIcon(Image icon)
        {
            this.btn_max.BackgroundImage = icon;
        }

        private void FormTitle_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Control c in panelTab.Controls)
            {
                if (c.BackColor != Color.White)
                {
                    c.BackColor = BackColor;
                }
            }
        }
        private void panelTab_ControlAdded(object sender, ControlEventArgs e)
        {
            this.panelTab.MaximumSize = new Size(Right - this.title_right.Width - 100, this.panelTab.MaximumSize.Height);

            MyTabControl tab = (MyTabControl)e.Control;
            tab.ParentTitle = this;
            tab.Left2Right = true;
            //tab.Top2Bottom = true;
            SetTabEvent(tab.Controls);
            setActiveTab(tab);
        }

        private void SetTabEvent(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.Equals("btn_closeTab"))
                    continue;
                control.MouseDown -= Tab_MouseDown;
                control.MouseDown += Tab_MouseDown;
                control.MouseUp -= Tab_MouseUp;
                control.MouseUp += Tab_MouseUp;
                control.MouseMove -= Tab_MouseMove;
                control.MouseMove += Tab_MouseMove;
                if (control.HasChildren)
                {
                    SetTabEvent(control.Controls);
                }
            }
        }

        public void Tab_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ctrl = getAvtiveTab();
                ctrl.lastClickLocation = ctrl.PointToClient(MousePosition);
                IsLBtnDownInTab = true;

                if (this.TabControlList.Count <= 1)
                {
                    enterX = e.Location.X;
                    enterY = e.Location.Y;
                }
                else
                {
                    pCtrlLastCoordinate.X = ctrl.Left;
                    pCtrlLastCoordinate.Y = ctrl.Top;
                    pCursorLastCoordinate.X = Cursor.Position.X;
                    pCursorLastCoordinate.Y = Cursor.Position.Y;
                }
            }
        }
        private void Tab_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsLBtnDownInTab)
            {
                this.panelTab.resizePanelWidth();
                IsLBtnDownInTab = false;

                enterX = 0;
                enterY = 0;
            }
        }
        public void Tab_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsLBtnDownInTab)
            {
                if (this.TabControlList.Count <= 1)
                {
                    this.ParentForm.Left += e.Location.X - enterX;
                    this.ParentForm.Top += e.Location.Y - enterY;

                    //窗口数量大于1，将一个窗口拖至另一窗口时，两窗口合并
                    if (MainForm.Browsers.Count > 1)
                    {
                        foreach (var browser in MainForm.Browsers)
                        {
                            if (browser.Key.Equals(this.ParentForm.Handle))
                                continue;
                            Size size = new Size(browser.Value.Title.title_left.Size.Width - 50, browser.Value.Title.title_left.Size.Height - 10);
                            Rectangle rectangle = new Rectangle(browser.Value.Location, size);
                            if (rectangle.Contains(this.ParentForm.PointToScreen(e.Location)))
                            {
                                MyTabControl tab = new MyTabControl(ctrl.page);
                                tab.title.Text = ctrl.title.Text;
                                tab.icon.Image = ctrl.icon.Image;
                                tab.OpenMode = MyTabOpenMode.APPEND;
                                tab.tabMarginLeft = this.ParentForm.PointToScreen(ctrl.Location).X - browser.Value.Location.X;
                                tab.insertLocation = (tab.tabMarginLeft + (browser.Value.Title.TabControlList[0].Width / 2)) / browser.Value.Title.TabControlList[0].Width;
                                browser.Value.addTab(tab);
                                browser.Value.Focus();
                                Point point = this.ParentForm.PointToScreen(new Point(ctrl.lastClickLocation.X, ctrl.lastClickLocation.Y + ctrl.ParentTitle.panelTab.Height - ctrl.Height));
                                Win32.mouse_event(0x02, point.X, point.Y, 0, 0);
                                this.ParentForm.Close();
                                break;
                            }
                        }
                    }
                }
                else
                {
                    ctrl.BringToFront();
                    Point pCursor = new Point(Cursor.Position.X, Cursor.Position.Y);
                    int offsetX = pCtrlLastCoordinate.X + pCursor.X - pCursorLastCoordinate.X;
                    int offsetY = pCtrlLastCoordinate.Y + pCursor.Y - pCursorLastCoordinate.Y;
                    int leftLimit = 0, topLimit = 0;
                    int rightLimit = panelTab.MaximumSize.Width - ctrl.Width;
                    int bottomLimit = panelTab.ClientSize.Height - ctrl.Height;
                    if (offsetX < leftLimit) offsetX = leftLimit; else if (offsetX > rightLimit) offsetX = rightLimit;
                    if (offsetY < topLimit) offsetY = topLimit; else if (offsetY > bottomLimit) offsetY = bottomLimit;

                    if (offsetX != 0 && ctrl.Left != offsetX)
                    {
                        MyTabControl tab;
                        if (ctrl.Left < offsetX)
                        {//向右
                            if ((tab = getNextTab(ctrl)) != null)
                            {
                                if (ctrl.Right > tab.Left + tab.Width / 2)
                                {
                                    TabControlList.Swap(TabControlList.IndexOf(ctrl), TabControlList.IndexOf(tab));
                                    this.panelTab.resizePanelWidth();
                                }
                            }
                        }
                        else
                        {//向左
                            if ((tab = getLastTab(ctrl)) != null)
                            {
                                if (ctrl.Left < tab.Left + tab.Width / 2)
                                {
                                    TabControlList.Swap(TabControlList.IndexOf(ctrl), TabControlList.IndexOf(tab));
                                    this.panelTab.resizePanelWidth();
                                }
                            }
                        }
                        if (ctrl.Right >= panelTab.Width)
                        {
                            panelTab.Width = ctrl.Width + offsetX;
                        }
                    }

                    Point cursorPointInPanelTab = panelTab.PointToClient(pCursor);
                    //拖动tab至面板外，在新窗口中打开
                    if (cursorPointInPanelTab.X < 0 || cursorPointInPanelTab.X > panelTab.MaximumSize.Width
                        || cursorPointInPanelTab.Y < 0 || cursorPointInPanelTab.Y > panelTab.MaximumSize.Height)
                    {
                        ctrl.OpenMode = MyTabOpenMode.NEWWINDOW;
                        ctrl.tabMarginLeft = offsetX;
                        removeEvents(ctrl.page.Controls);
                        Browser browser = new Browser(ctrl, this.ParentForm.Size);
                        MainForm.Browsers.Add(browser.Handle, browser);
                        Tab_MouseUp(sender, e);
                        removeTab(ctrl);
                        browser.Show();

                        setActiveTab(TabControlList[TabControlList.Count - 1]);
                        this.panelTab.resizePanelWidth();
                        return;
                    }
                    if (ctrl.Left2Right)
                        ctrl.Left = offsetX;
                    if (ctrl.Top2Bottom)
                        ctrl.Top = offsetY;
                }
            }

        }
        public int getTabIndex(MyTabControl tab)
        {
            return TabControlList.IndexOf(tab);
        }
        public void setActiveTab(MyTabControl tab)
        {
            Panel body = ((Browser)this.ParentForm).Body;
            tab.line.Visible = false;
            tab.BackColor = Color.White;
            tab.isActive = true;
            tab.page.Dock = DockStyle.Fill;
            for (int i = 0; i < TabControlList.Count; i++)
            {
                if (TabControlList[i] != tab)
                {
                    Win32.AnimateWindow(tab.page.Handle, 150, Win32.AW_BLEND | Win32.AW_HIDE);
                    body.Controls.Remove(TabControlList[i].page);
                    TabControlList[i].MyTabControl_Leave();
                    TabControlList[i].isActive = false;
                    TabControlList[i].isNextActive = false;
                    TabControlList[i].BackColor = BackColor;
                }
                else if (i != 0)
                {
                    TabControlList[i - 1].isNextActive = true;
                    TabControlList[i - 1].line.Visible = false;
                }
            }
            Win32.AnimateWindow(tab.page.Handle, 150, Win32.AW_BLEND | Win32.AW_ACTIVATE);
            body.Controls.Add(tab.page);
            this.ParentForm.Text = tab.title.Text;
        }
        public MyTabControl getAvtiveTab()
        {
            foreach (MyTabControl tab in TabControlList)
            {
                if (tab.isActive) return tab;
            }
            return null;
        }
        private MyTabControl getLastTab(MyTabControl tab)
        {
            if (TabControlList.Count == 1 || TabControlList[0] == tab)
                return null;
            return TabControlList[TabControlList.IndexOf(tab) - 1];
        }
        private MyTabControl getNextTab(MyTabControl tab)
        {
            if (TabControlList.Count == 1 || TabControlList[TabControlList.Count - 1] == tab)
                return null;
            return TabControlList[TabControlList.IndexOf(tab) + 1];
        }
        private void removeTab(MyTabControl tab)
        {
            TabControlList.Remove(tab);
            tab.Dispose();
        }
        private void removeEvents(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.Equals("searchBox"))
                    continue;
                control.RemoveControlEvent("EventMouseMove");
                control.RemoveControlEvent("EventMouseDown");
                control.RemoveControlEvent("EventMouseUp");
                if (control.HasChildren)
                {
                    removeEvents(control.Controls);
                }
            }
        }

        private void FormTitle_SizeChanged(object sender, EventArgs e)
        {
            this.panelTab.resizePanelWidth();
            this.panelTab.MaximumSize = new Size(Right - this.title_right.Width - 100, this.panelTab.MaximumSize.Height);
        }
        private void panelTab_SizeChanged(object sender, EventArgs e)
        {
            this.btn_addTab.Location = new Point(this.panelTab.Width + 15, this.btn_addTab.Location.Y);
            this.btn_addTab.Top = this.panelTab.Height - this.btn_addTab.Height - 3;
        }

    }
}
