using CefSharp;
using System;
using System.Windows.Forms;
using Cesium.Utils;

namespace Cesium.CustomControls
{
    public partial class InputBoxInPageContextMenu : UserControl
    {
        private IBrowser browser;
        private int x, y;

        public InputBoxInPageContextMenu()
        {
            InitializeComponent();
        }

        public void setContent(IBrowser browser, int xCoord, int yCoord)
        {
            this.browser = browser;
            x = xCoord;
            y = yCoord;

            string firstContent = ClipboardHelper.GetFirstClipboardContent();
            if (ObjectUtils.IsNullOrEmpty(firstContent))
            {
                this.item5.Enabled = false; this.item6.Enabled = false;
            }
            else
            {
                this.item5.Enabled = true; this.item6.Enabled = true;
            }

        }

        #region 监听方法
        private void item1_Click(object sender, EventArgs e)
        {

        }

        private void item2_Click(object sender, EventArgs e)
        {
            browser.GetHost().SendKeyEvent(new KeyEvent { WindowsKeyCode = (int)Keys.Z, Modifiers = CefEventFlags.ControlDown });
        }

        private void item3_Click(object sender, EventArgs e)
        {
            browser.GetHost().SendKeyEvent(new KeyEvent { WindowsKeyCode = (int)Keys.X, Modifiers = CefEventFlags.ControlDown });
        }

        private void item4_Click(object sender, EventArgs e)
        {
            browser.GetHost().SendKeyEvent(new KeyEvent { WindowsKeyCode = (int)Keys.C, Modifiers = CefEventFlags.ControlDown });
        }

        private void item5_Click(object sender, EventArgs e)
        {
            browser.GetHost().SendKeyEvent(new KeyEvent { WindowsKeyCode = (int)Keys.V, Modifiers = CefEventFlags.ControlDown });
        }

        private void item6_Click(object sender, EventArgs e)
        {
            browser.GetHost().SendKeyEvent(new KeyEvent { WindowsKeyCode = (int)Keys.V, Modifiers = CefEventFlags.ControlDown | CefEventFlags.ShiftDown });
        }


        private void item7_Click(object sender, EventArgs e)
        {
            browser.GetHost().SendKeyEvent(new KeyEvent { WindowsKeyCode = (int)Keys.A, Modifiers = CefEventFlags.ControlDown });
        }

        private void item8_Click(object sender, EventArgs e)
        {

        }

        private void item9_Click(object sender, EventArgs e)
        {

        }
        private void item10_Click(object sender, EventArgs e)
        {
            browser.GetHost().ShowDevTools(null, x, y);
        }
        #endregion

    }
}
