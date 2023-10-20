using CefSharp;
using System;
using Cesium.App.CefBrowser.Tab;
using Cesium.Utils;
using Cesium.View;

namespace Cesium.App.CefBrowser
{
    public class CustomLifeSpanHandler : ILifeSpanHandler
    {
        private MyPage myPage;

        public CustomLifeSpanHandler(MyPage myPage)
        {
            this.myPage = myPage;
        }

        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            if (browser.IsPopup)
            {
                return false;
            }
            return true;
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
                if (myPage.tab.page.panelBrowser.Controls.Count == 0)
                {
                    targetDisposition = WindowOpenDisposition.CurrentTab;
                }
                Browser browser1 = myPage.ParentForm as Browser;
                switch (targetDisposition)
                {
                    case WindowOpenDisposition.NewForegroundTab:
                        browser1?.Invoke((Action)delegate ()
                        {
                            MyTabControl newTab = new MyTabControl(targetUrl);
                            newTab.OpenMode = MyTabOpenMode.INSERT;
                            newTab.insertLocation = browser1.Title.getTabIndex(myPage.tab) + 1;
                            browser1.addTab(newTab);
                        });
                        break;
                    case WindowOpenDisposition.CurrentTab:
                        chromiumWebBrowser.Load(targetUrl);
                        break;
                    case WindowOpenDisposition.NewWindow:
                        browser1.Invoke((Action)delegate ()
                        {
                            Browser nBrowser = new Browser(targetUrl);
                            MainForm.Browsers.Add(nBrowser.Handle, nBrowser);
                            nBrowser.Show();
                        });
                        break;
                    case WindowOpenDisposition.NewPopup:
                        //PopUpForm popUpForm = new PopUpForm(true, false);
                        //popUpForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                        //popUpForm.ShowInTaskbar = true;
                        //popUpForm.ShowIcon = false;
                        //popUpForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                        //popUpForm.SetControl(new PopUpControl(browser1, targetUrl));
                        //popUpForm.Show();
                        //break;
                        return false;
                    default:
                        chromiumWebBrowser.Load(targetUrl);
                        break;
                }

            }
            return true;
        }

    }

}
