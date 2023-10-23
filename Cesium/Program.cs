using Cesium.App.CefBrowser;
using Cesium.CustomControls;
using Cesium.DataBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            BootPrepare.InitData();

            Browsers = new Dictionary<IntPtr, Browser>();
            Browser browser = new Browser("");
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

        public static class BootPrepare
        {
            private static LinkContextMenu linkContextMenu;
            private static TextContextMenu TextContextMenu;
            private static OtherContextMenu otherContextMenu;
            private static InputBoxContextMenu inputBoxContextMenu;
            private static InputBoxInPageContextMenu inputBoxInPageContextMenu;

            public static void InitData()
            {
                DbSeed.InitData();
                linkContextMenu = new LinkContextMenu();
                TextContextMenu = new TextContextMenu();
                otherContextMenu = new OtherContextMenu();
                inputBoxContextMenu = new InputBoxContextMenu();
                inputBoxInPageContextMenu = new InputBoxInPageContextMenu();
            }

            public static LinkContextMenu GetLinkContextMenu()
            {
                return linkContextMenu;
            }
            public static TextContextMenu GetTextContextMenu()
            {
                return TextContextMenu;
            }
            public static OtherContextMenu GetOtherContextMenu()
            {
                return otherContextMenu;
            }
            public static InputBoxContextMenu GetInputBoxContextMenu()
            {
                return inputBoxContextMenu;
            }
            public static InputBoxInPageContextMenu GetInputBoxInPageContextMenu()
            {
                return inputBoxInPageContextMenu;
            }

        }

    }
}
