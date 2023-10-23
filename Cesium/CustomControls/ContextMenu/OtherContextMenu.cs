using CefSharp;
using System;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public partial class OtherContextMenu : UserControl
    {
        private IBrowser browser;
        private int x, y;

        public OtherContextMenu()
        {
            InitializeComponent();
        }

        public void setContent(IBrowser browser, int xCoord, int yCoord)
        {
            this.browser = browser;
            x = xCoord;
            y = yCoord;

            item1.Enabled = browser.CanGoBack;
            item2.Enabled = browser.CanGoForward;
            item7.iconVisible = true;
            item7.icon.BackgroundImage = Properties.Resources.qrcode;
        }

        #region 监听方法
        private void item1_Click(object sender, EventArgs e)
        {
            browser.GoBack();
        }

        private void item2_Click(object sender, EventArgs e)
        {
            browser.GoForward();
        }

        private void item3_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        private void item4_Click(object sender, EventArgs e)
        {

        }

        private void item5_Click(object sender, EventArgs e)
        {
            browser.Print();
        }

        private void item6_Click(object sender, EventArgs e)
        {

        }

        private void item7_Click(object sender, EventArgs e)
        {

        }

        private void item8_Click(object sender, EventArgs e)
        {

        }

        private void item9_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void item10_Click(object sender, EventArgs e)
        {
            browser.GetHost().ShowDevTools(null, x, y);
        }
        #endregion

    }
}
