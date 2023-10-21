using CefSharp;
using CefSharp.WinForms;
using Cesium.App.CefBrowser.Handler;
using Cesium.Tables;
using Cesium.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Cesium.Services;

namespace Cesium.App.CefBrowser
{
    public partial class MyPage : UserControl
    {
        public MyTabControl tab { get; set; }
        public bool isActive = false;
        private bool loadErr = false;
        private HistoryServices _historyServices;

        public MyPage(MyTabControl tab, string url = "", bool isSearch = false)
        {
            this.tab = tab;
            InitializeComponent();
            _historyServices = new HistoryServices();

            if (url != "" && isSearch)
                browser = new ChromiumWebBrowser("https://www.baidu.com/s?ie=UTF-8&wd=" + url);
            else
                browser = new ChromiumWebBrowser(url);
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.LoadError += Browser_LoadError;
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;
            browser.FrameLoadStart += Browser_FrameLoadStart;
            browser.FrameLoadEnd += Browser_FrameLoadEnd;
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            browser.DownloadHandler = new DownloadHandler();
            browser.JsDialogHandler = new JsDialogHandler();
            browser.MenuHandler = new MenuHandler(this);
            browser.LifeSpanHandler = new CustomLifeSpanHandler(this);

            browser.Dock = DockStyle.Fill;
            browser.Margin = new Padding(0);
            this.panelBrowser.Controls.Add(browser);
        }

        private void Browser_IsBrowserInitializedChanged(object sender, EventArgs e)
        {
            if (browser.IsBrowserInitialized)
            {
                //自动播放flash
                Cef.UIThreadTaskFactory.StartNew(() =>
                {
                    string error = "666";
                    var requestContext = browser.GetBrowser().GetHost().RequestContext;
                    requestContext.SetPreference("profile.default_content_setting_values.plugins", 1, out error);
                });
            }
        }

        private void MyPage_Load(object sender, EventArgs e)
        {
            //搜索框输入框回车监听
            this.searchBox.inputBox.KeyDown += this.inputBox_KeyDown;
            //激活搜索框颜色
            this.searchBox.mouseEnter(sender, e);
        }

        #region 按钮事件
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack) browser.Back();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward) browser.Forward();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (browser.IsLoading) browser.Stop();
            else browser.Reload();
        }

        #endregion

        #region 浏览器事件

        private string inputBoxContent = "";
        WebClient webClient = new WebClient();
        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (e.IsLoading)
            {
                this.btn_refresh.BackgroundImage = Properties.Resources.icons8_refresh_s1_16;
                this.tab.icon.Image = Properties.Resources.tab_loading;
            }
            else
            {
                this.tab.icon.Image = this.tab.favicon;
                this.btn_refresh.BackgroundImage = Properties.Resources.icons8_refresh_16;
                if (browser.Address.Equals(""))
                    this.tab.page.searchBox.btn_webInfo.BackgroundImage = Properties.Resources.icons8_webInfo_baidu;
                else
                {
                    Uri uri = new Uri(browser.Address);
                    if (uri.Scheme == "https")
                        this.tab.page.searchBox.btn_webInfo.BackgroundImage = Properties.Resources.icons8_webInfo_16;
                    else
                        this.tab.page.searchBox.btn_webInfo.BackgroundImage = Properties.Resources.icons8_webInfo_noSafe;
                }
            }

            try
            {
                if (e.CanGoBack) btn_back.BackgroundImage = Properties.Resources.icons8_back_16;
                else btn_back.BackgroundImage = Properties.Resources.icons8_back_s1_16;
                btn_back.Invoke(new Action(() => { if (!btn_back.IsDisposed) btn_back.Enabled = e.CanGoBack; }));

                if (e.CanGoForward) btn_forward.BackgroundImage = Properties.Resources.icons8_forward_16;
                else btn_forward.BackgroundImage = Properties.Resources.icons8_forward_s1_16;
                btn_forward.Invoke(new Action(() => { if (!btn_forward.IsDisposed) btn_forward.Enabled = e.CanGoForward; }));
            }
            catch (Exception ex) { LogUtils.Error(ex.Message, ex); }
        }
        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            searchBox.inputBox.Invoke(new Action(() =>
            {
                searchBox.inputBox.Text = browser.Address;
            }));

        }
        private void Browser_LoadError(object sender, LoadErrorEventArgs e)
        {
            searchBox.inputBox.Invoke(new Action(() =>
            {
                searchBox.inputBox.Text = inputBoxContent == "" ? browser.Address : inputBoxContent;
            }));
            loadErr = true;
        }
        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            if (!tab.IsDisposed && tab.isActive)
            {
                Title = e.Title;
                updateTitleTimer_Tick(sender, e);
            }
            if (canSaveHistory)
                saveHistory();
        }
        private void Browser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            this.tab.icon.Image = Properties.Resources.tab_loading;
            this.canSaveHistory = false;
        }
        private async void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                await e.Frame.EvaluateScriptAsync(@"
                var links = document.getElementsByTagName('link');
                for (var i = 0; i < links.length; i++) {
                    if (links[i].rel === 'shortcut icon' || links[i].rel === 'icon') {
                        links[i].href;
                        break;
                    }
                }").ContinueWith(async t =>
                {
                    if (!t.IsFaulted && !t.IsCanceled && t.Result.Success && t.Result.Result != null)
                    {
                        string iconUrl = t.Result.Result.ToString();
                        var imageBytes = await webClient.DownloadDataTaskAsync(iconUrl);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            var originalImage = Image.FromStream(ms);
                            if (!loadErr)
                                this.tab.icon.Image = originalImage.GetThumbnailImage(17, 17, null, IntPtr.Zero);
                        }
                    }
                    else
                    {
                        try
                        {
                            var imageBytes = await webClient.DownloadDataTaskAsync(new Uri(browser.Address).GetLeftPart(UriPartial.Authority) + "/favicon.ico");
                            using (var ms = new MemoryStream(imageBytes))
                            {
                                var originalImage = Image.FromStream(ms);
                                if (!loadErr)
                                    this.tab.icon.Image = originalImage.GetThumbnailImage(17, 17, null, IntPtr.Zero);
                            }
                        }
                        catch (Exception)
                        {
                            this.tab.icon.Image = Properties.Resources.tab_icon;
                        }
                    }
                    if (loadErr)
                        this.tab.icon.Image = Properties.Resources.tab_icon;
                    this.loadErr = false;
                    this.tab.favicon = this.tab.icon.Image;
                    this.canSaveHistory = true;
                    saveHistory();
                });
            }
        }
        #endregion

        private bool canSaveHistory;
        public void saveHistory()
        {
            if (tab.saveHistory)
            {
                tab.Invoke(new Action(async () =>
                {
                    try
                    {
                        var model = new HistoryModel { Url = browser.Address, VisitTime = DateTime.Now, FormVisit = 0, Title = this.Title, Favicon = ImageUtils.ImageToByte(this.tab.icon.Image) };
                        await _historyServices.AddHistory(model);
                    }
                    catch (Exception ex) { LogUtils.Error(ex.Message, ex); }
                }));
            }
        }

        private Point point = new Point(0, 0);
        private void MyPage_SizeChanged(object sender, EventArgs e)
        {
            point.X = this.Width - this.panelToolRight.Width - 5;
            point.Y = this.panelToolRight.Location.Y;
            this.panelToolRight.Location = point;
            this.searchBox.Width = point.X - this.panelToolRight.Width - 10;
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Return:
                    if (searchBox.inputBox.Focused && !ObjectUtils.IsNullOrEmpty(searchBox.inputBox.Text))
                    {
                        this.tab.favicon = null;
                        if (HttpUtils.IsValidUrl(searchBox.inputBox.Text))
                            browser.Load(searchBox.inputBox.Text);
                        else
                            browser.Load("https://www.baidu.com/s?ie=UTF-8&wd=" + searchBox.inputBox.Text);
                        inputBoxContent = searchBox.inputBox.Text;
                        browser.Focus();
                    }
                    break;
            }
        }

        private string Title = "新标签页";
        private void updateTitleTimer_Tick(object sender, EventArgs e)
        {
            if (tab.isActive)
            {
                tab.ParentForm?.Invoke(new Action(() =>
                {
                    tab.title.Text = Title;
                    if (tab.ParentForm != null)
                        tab.ParentForm.Text = Title;
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<IntPtr, Browser> browsers = Program.Browsers;
            MessageBox.Show("" + browsers.Count);
        }
    }
}
