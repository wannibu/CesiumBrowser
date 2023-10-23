using CefSharp;
using Cesium.App.CefBrowser;
using Cesium.Enum;
using System;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public partial class TextContextMenu : UserControl
    {
        private MyPage myPage;
        private string text;
        private string link;
        private IBrowser browser;
        private int x, y;

        public TextContextMenu()
        {
            InitializeComponent();
        }


        public void setContent(MyPage myPage, string text, string link, IBrowser browser, int xCoord, int yCoord)
        {
            this.myPage = myPage;
            this.text = text;
            this.link = link;
            this.browser = browser;
            x = xCoord;
            y = yCoord;

            item3.text_left.Text = $"使用百度搜索\"{text}\"";
        }

        #region 监听方法
        private void item1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(text);
        }

        private void item2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(link);
        }

        private void item3_Click(object sender, EventArgs e)
        {
            Browser browser = myPage.ParentForm as Browser;
            browser.Invoke((Action)delegate ()
            {
                MyTabControl newTab = new MyTabControl(text, true);
                newTab.OpenMode = MyTabOpenMode.INSERT;
                newTab.insertLocation = browser.Title.getTabIndex(myPage.tab) + 1;
                browser.addTab(newTab);
            });
        }

        private void item4_Click(object sender, EventArgs e)
        {
            browser.Print();
        }

        private void item5_Click(object sender, EventArgs e)
        {
            browser.GetHost().ShowDevTools(null, x, y);
        }

        #endregion

    }
}
