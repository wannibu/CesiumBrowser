using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace CefOld.Controls
{
    public partial class FlashBrowser : UserControl
    {
        private ChromiumWebBrowser browser;
        public FlashBrowser()
        {
            InitializeComponent();
            if (!Cef.IsInitialized)
            {
                var settings = new CefSettings();
                settings.CefCommandLineArgs["enable-system-flash"] = "1";
                settings.CefCommandLineArgs.Add("ppapi-flash-version", "34.0.0.192");
                settings.CefCommandLineArgs.Add("ppapi-flash-path", @"plugins\pepflashplayer.dll");
                Cef.Initialize(settings);
            }
        }

        private void FlashBrowser_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("https://www.4399.com/");
            browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            browser.Dock = DockStyle.Fill;
            this.panel.Controls.Add(browser);
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
    }
}
