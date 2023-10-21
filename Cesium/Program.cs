using Cesium.App.CefBrowser;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.boot;

namespace Cesium
{
    class Program
    {
        public static Dictionary<IntPtr, Browser> Browsers;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new BootPrepare();

            Browsers = new Dictionary<IntPtr, Browser>();
            Browser browser = new Browser("https://www.baidu.com");
            Browsers.Add(browser.Handle, browser);
            browser.FormClosing += Browser_FormClosing;


            Application.Run(browser);
        }

        private static void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Browser browser = sender as Browser;
            Browsers.Remove(browser.Handle);
            if (browser != null)
            {
                browser.FormClosing -= Browser_FormClosing;
                browser.Dispose();
            }
        }

    }
}
