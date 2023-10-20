using CefSharp;
using System;
using System.Windows.Forms;
using Cesium.App.CefBrowser;
using Cesium.App.CefBrowser.Tab;
using Cesium.Utils;
using Cesium.View;

namespace Cesium.CustomControls
{
    public partial class LinkContextMenu : UserControl
    {
        private MyPage myPage;
        private string link;
        private IBrowser browser;
        private int x, y;

        public LinkContextMenu()
        {
            InitializeComponent();
        }

        public void setContent(MyPage myPage, string link, IBrowser browser, int xCoord, int yCoord)
        {
            this.myPage = myPage;
            this.link = link;
            this.browser = browser;
            x = xCoord;
            y = yCoord;
        }

        #region 监听方法
        private void item1_Click(object sender, EventArgs e)
        {
            Browser browser = myPage.ParentForm as Browser;
            browser.Invoke((Action)delegate ()
            {
                MyTabControl newTab = new MyTabControl(link);
                newTab.OpenMode = MyTabOpenMode.INSERT;
                newTab.insertLocation = browser.Title.getTabIndex(myPage.tab) + 1;
                browser.addTab(newTab);
            });
        }

        private void item2_Click(object sender, EventArgs e)
        {
            Browser browser = myPage.ParentForm as Browser;
            browser.Invoke((Action)delegate ()
            {
                Browser nBrowser = new Browser(link);
                MainForm.Browsers.Add(nBrowser.Handle, nBrowser);
                nBrowser.Show();
            });
        }

        private void item3_Click(object sender, EventArgs e)
        {

        }

        private void item4_Click(object sender, EventArgs e)
        {
            browser.Print();
        }

        private void item5_Click(object sender, EventArgs e)
        {
            ClipboardHelper.setContent(link);
        }

        private void item6_Click(object sender, EventArgs e)
        {
            browser.GetHost().ShowDevTools(null, x, y);
        }
        #endregion

    }
}
