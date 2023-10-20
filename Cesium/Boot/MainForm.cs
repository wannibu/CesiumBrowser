using Cesium.App.CefBrowser;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.boot;

namespace Cesium.View
{
    public partial class MainForm : Form
    {
        public static Dictionary<IntPtr, Browser> Browsers;

        public MainForm()
        {

            new BootPrepare();
            InitializeComponent();
            this.KeyPreview = true;
            Browsers = new Dictionary<IntPtr, Browser>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Browser browser = new Browser("https://www.baidu.com");
            browser.Owner = this;
            Browsers.Add(browser.Handle, browser);
            browser.FormClosed += new FormClosedEventHandler(browser_FormClosed);
            Hide();
            browser.Show();
        }

        private void browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Browser browser = sender as Browser;
            Browsers.Remove(browser.Handle);
            if (browser != null)
            {
                browser.FormClosed -= new FormClosedEventHandler(browser_FormClosed);
                browser.Dispose();
            }
        }

    }

}