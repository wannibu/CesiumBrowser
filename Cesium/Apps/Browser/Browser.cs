using CefSharp;
using CefSharp.WinForms;
using Cesium.CustomControls;
using Cesium.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;
using test.events;
using test.Events;

namespace Cesium.App.CefBrowser
{
    public partial class Browser : MyForm
    {
        private MyTabControl ctrl;
        private Size Clientsize;
        private GlobalEventHook _globalEventHook;
        private HistoryContextMenu _historyContextMenu;
        private PopUpForm popUpForm;

        private bool isActive;

        public Browser(string url = "")
        {
            Browser_init();
            addTab(new MyTabControl(url));
        }

        public Browser(MyTabControl ctrl, Size size)
        {
            if (ctrl.ParentForm?.WindowState != FormWindowState.Maximized)
                this.Clientsize = size;
            MyTabControl tab = new MyTabControl(ctrl.page);
            tab.title.Text = ctrl.title.Text;
            tab.icon.Image = ctrl.icon.Image;
            tab.tabMarginLeft = ctrl.tabMarginLeft;
            tab.lastClickLocation = ctrl.lastClickLocation;
            this.ctrl = tab;
            Browser_init();
            addTab(tab);

            Point point = this.PointToScreen(new Point(tab.lastClickLocation.X, tab.lastClickLocation.Y + tab.ParentTitle.panelTab.Height - tab.Height));
            Win32.mouse_event(0x02, point.X, point.Y, 0, 0);

            if (tab.tabMarginLeft != 0)
            {
                tab.Left = tab.tabMarginLeft;
                tab.Parent.Width = tab.tabMarginLeft + tab.Width;
            }
        }

        private void Browser_init()
        {
            popUpForm = new PopUpForm(true);
            popUpForm.VisibleChanged += (s, e1) =>
            {
                isActive = popUpForm.Visible;
            };
            popUpForm.Show();
            popUpForm.Visible = false;
            _historyContextMenu = new HistoryContextMenu();

            var cache = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, System.IO.Path.Combine("Application", "cache")); //cache缓存路径
            if (!System.IO.Directory.Exists(cache)) //判断cache文件是否存在
                System.IO.Directory.CreateDirectory(cache); //如果没有则创建cache缓存文件
            if (!Cef.IsInitialized)
            {
                var settings = new CefSettings();
                settings.CachePath = cache;
                settings.CefCommandLineArgs["enable-system-flash"] = "1";
                settings.CefCommandLineArgs.Add("ppapi-flash-version", "34.0.0.192");
                settings.CefCommandLineArgs.Add("ppapi-flash-path", @"plugins\pepflashplayer.dll");
                Cef.Initialize(settings);
                Cef.EnableHighDPISupport();
            }
            InitializeComponent();
            SetStyles();
            if (this.Clientsize.Width != 0 && this.Clientsize.Height != 0)
            {
                this.ClientSize = Clientsize;
            }

            _globalEventHook = new GlobalEventHook();
            _globalEventHook.KeyDown += GlobalKeyboardHook_KeyDown;
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            this.Title.BtnClick += Title_BtnClick;

            if (this.ctrl != null)
            {
                Point mouseInScreen = MousePosition;
                Point panelInScreen = ctrl.PointToScreen(ctrl.lastClickLocation);
                int deltaX = mouseInScreen.X - panelInScreen.X;
                int deltaY = mouseInScreen.Y - panelInScreen.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
            Form owner = this.Owner;

        }

        private void Browser_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(232, 234, 237);
            this.Title.BackColor = Color.FromArgb(222, 225, 230);
        }

        private void Browser_Deactivate(object sender, EventArgs e)
        {
            MyTabControl tab = this.Title.getAvtiveTab();
            if (tab != null && !tab.page.searchBox.isActive && !tab.page.isActive && !isActive)
            {
                this.BackColor = Color.FromArgb(200, 200, 200);
                this.Title.BackColor = Color.FromArgb(232, 234, 237);
            }
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _globalEventHook.Dispose();
            _globalEventHook = null;
            if (this.Owner != null)
            {
                this.Owner.Show();
                this.Owner.Activate();
            }
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Browsers.Remove(this.Handle);
        }

        #region 标题按钮事件
        private void Title_BtnClick(object sender, EventArgs e)
        {
            PictureButton pictureButton = sender as PictureButton;
            switch (pictureButton?.Name)
            {
                case "btn_addTab":
                    addTab(new MyTabControl());
                    break;
                case "btn_collapse":
                    _historyContextMenu.reload(this);
                    popUpForm.SetControl(_historyContextMenu);
                    popUpForm.Top = this.PointToScreen(this.Title.Location).Y + pictureButton.Height + 3;
                    popUpForm.Left = this.PointToScreen(this.Title.Location).X + this.Title.Width - pictureButton.Width * 3 - _historyContextMenu.Width;
                    Win32.AnimateWindow(_historyContextMenu.Handle, 200, Win32.AW_ACTIVATE | Win32.AW_BLEND);
                    popUpForm.Visible = true;
                    this.Focus();
                    break;
            }
        }

        public void addTab(MyTabControl tab)
        {
            tab.btn_closeTab.Click -= Btn_closeTab_Click;
            tab.btn_closeTab.Click += Btn_closeTab_Click;
            this.Title.panelTab.Controls.Add(tab);
            Win32.AnimateWindow(tab.Handle, 100, Win32.AW_HOR_POSITIVE | Win32.AW_ACTIVATE);
            this.Body.Controls.Add(tab.page);
            if (tab.tabMarginLeft != 0 && tab.OpenMode == Tab.MyTabOpenMode.APPEND)
            {
                tab.Left = tab.tabMarginLeft;
                tab.Parent.Width = tab.tabMarginLeft + tab.Width;
                if ((tab.Left + tab.Width / 2) < (tab.Width * tab.ParentTitle.TabControlList.Count))
                    this.Title.panelTab.resizePanelWidth();
            }
        }

        private void Btn_closeTab_Click(object sender, EventArgs e)
        {
            MyTabControl tab = (MyTabControl)((PictureButton)sender).Parent.Parent;
            Win32.AnimateWindow(tab.Handle, 100, Win32.AW_HOR_NEGATIVE | Win32.AW_HIDE);
            MyTabControl activeTab = this.Title.getAvtiveTab();
            this.Title.TabControlList.Remove(tab);

            if (this.Title.TabControlList.Count == 0)
            {
                this.Close();
            }
            else
            {
                if (activeTab == tab)
                    this.Title.setActiveTab(this.Title.TabControlList[this.Title.TabControlList.Count - 1]);
                else
                    this.Title.setActiveTab(activeTab);

            }
            tab.Dispose();
            tab.page.Dispose();
        }

        #endregion

        #region 减少闪烁
        private void SetStyles()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer, true);
            UpdateStyles();
            base.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        private void GlobalKeyboardHook_KeyDown(object sender, ExtendedKeyEventArgs e)
        {
            if (WindowHelper.IsForegroundWindow(this))
            {
                MyTabControl tab = this.Title.getAvtiveTab();
                switch (e.KeyCode)
                {
                    case Keys.F5:
                        if (e.CtrlKeyDown)
                            tab.page.browser.Reload(true); //忽略缓存
                        else
                            tab.page.browser.Reload();
                        break;
                    case Keys.F11:
                        if (this.Visible)
                            this.SetFullScreen(tab);
                        break;
                    case Keys.F12:
                        tab.page.browser.ShowDevTools();
                        break;
                    case Keys.U:
                        if (e.CtrlKeyDown)
                            tab.page.browser.ShowDevTools();
                        break;
                    case Keys.P:
                        if (e.CtrlKeyDown)
                            tab.page.browser.Print();
                        break;
                    case Keys.R:
                        if (e.CtrlKeyDown)
                            tab.page.browser.Reload();
                        break;
                    case Keys.S:
                        break;
                    case Keys.Left:
                        if (e.AltKeyDown)
                            tab.page.browser.Back();
                        break;
                    case Keys.Right:
                        if (e.AltKeyDown)
                            tab.page.browser.Forward();
                        break;
                }
            }

        }
        private FullScreenForm fsform;
        protected void SetFullScreen(MyTabControl tab)
        {
            this.Visible = false;
            fsform = new FullScreenForm(tab.page.browser);
            fsform.Owner = this;
            fsform.Show();
        }

    }

}
