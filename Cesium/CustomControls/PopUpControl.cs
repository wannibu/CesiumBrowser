using CefSharp;
using CefSharp.WinForms;
using Cesium.Enum;
using System;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public partial class PopUpControl : UserControl
    {
        private ChromiumWebBrowser browser;

        public PopUpControl(App.CefBrowser.Browser browser1, string url)
        {
            InitializeComponent();
            this.textBox.ContextMenu = new System.Windows.Forms.ContextMenu();
            browser = new ChromiumWebBrowser(url);
            browser.Dock = DockStyle.Fill;
            browser.Margin = new Padding(0);
            browser.TitleChanged += Browser_TitleChanged;
            browser.AddressChanged += Browser_AddressChanged;
            this.body.Controls.Add(browser);
            browser.Focus();
            browser.LifeSpanHandler = new PopUpControlLifeSpanHandler(browser1);
            browser.MenuHandler = new PopUpControlMenuHandler();
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.textBox.Text = e.Address.ToString();
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.ParentForm.Text = e.Title;
        }

        private class PopUpControlLifeSpanHandler : ILifeSpanHandler
        {
            private Cesium.App.CefBrowser.Browser browser1;

            public PopUpControlLifeSpanHandler(Cesium.App.CefBrowser.Browser browser1)
            {
                this.browser1 = browser1;
            }

            public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
            {
                return false;
            }
            public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
            {

            }
            public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
            {

            }
            public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
            {
                newBrowser = null;
                if (chromiumWebBrowser != null && !chromiumWebBrowser.IsDisposed)
                {
                    switch (targetDisposition)
                    {
                        case WindowOpenDisposition.NewForegroundTab:
                            browser1?.Invoke((Action)delegate ()
                            {
                                MyTabControl newTab = new MyTabControl(targetUrl);
                                newTab.OpenMode = MyTabOpenMode.ADD;
                                browser1.addTab(newTab);
                            });
                            break;
                        default:
                            chromiumWebBrowser.Load(targetUrl);
                            break;
                    }
                }
                return true;
            }
        }

        private class PopUpControlMenuHandler : IContextMenuHandler
        {
            public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
            {
                model.Clear();
            }

            public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
            {
                return false;
            }

            public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
            {

            }

            public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
            {
                return false;
            }
        }


    }
}
