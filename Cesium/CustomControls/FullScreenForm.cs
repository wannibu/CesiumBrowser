using CefSharp.WinForms;
using System.Windows.Forms;
using test.events;

namespace Cesium.App.CefBrowser
{
    public partial class FullScreenForm : Form
    {
        public ChromiumWebBrowser browser;
        private GlobalEventHook _globalEventHook;

        public FullScreenForm(ChromiumWebBrowser chromiumWebBrowser)
        {
            this.browser = chromiumWebBrowser;
            this.Controls.Add(this.browser);

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormClosing += FullScreenForm_FormClosing;
            _globalEventHook = new GlobalEventHook();
            _globalEventHook.KeyDown += GlobalKeyboardHook_KeyDown;
        }

        private void FullScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _globalEventHook.Dispose();
            _globalEventHook = null;
            this.Controls.Remove(this.browser);
            Browser b = this.Owner as Browser;
            b.Visible = true;
            MyTabControl tab = b.Title.getAvtiveTab();
            tab.page.panelBrowser.Controls.Add(this.browser);
        }
        private void GlobalKeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

    }
}
