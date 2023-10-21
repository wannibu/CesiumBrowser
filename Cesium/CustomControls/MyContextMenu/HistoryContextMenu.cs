using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cesium.App.CefBrowser;
using Cesium.App.CefBrowser.Tab;
using Cesium.CustomControls.ContextMenu;
using Cesium.Services;
using Cesium.Tables;
using Cesium.Utils;

namespace Cesium.CustomControls
{
    public partial class HistoryContextMenu : UserControl
    {
        private Browser browser;
        private HistoryServices _historyServices;
        private int _pageNum = 1;
        private int _pageSize = 10;
        public HistoryContextMenu()
        {
            _historyServices = new HistoryServices();
            InitializeComponent();
        }

        public void reload(Browser browser)
        {
            this.browser = browser;
            this.Main.Controls.Clear();

            Task<Param.PageModel<HistoryModel>> result = _historyServices.GetHistoryList(_pageNum, _pageSize);
            List<HistoryModel> data = result.Result.data;

            foreach (HistoryModel item in data)
            {
                HistoryContextMenuItem menuItem = new HistoryContextMenuItem();
                menuItem.Clicked += MenuItem_Clicked;
                menuItem.Dock = DockStyle.Top;
                menuItem.title.Text = item.Title;
                Uri uri = new Uri(item.Url);
                menuItem.uri = uri;
                menuItem.url_time.Text = uri.Host + " • " + TimeUtils.GetTimeElapsed(item.VisitTime);
                if (item.Favicon.Length > 0)
                    menuItem.icon.Image = ImageUtils.ByteToImage(item.Favicon);
                else
                    menuItem.icon.Image = Properties.Resources.tab_icon;
                this.Main.Controls.Add(menuItem);
                menuItem.BringToFront();
            }

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            HistoryContextMenuItem menuItem = sender as HistoryContextMenuItem;
            if (menuItem != null)
            {
                MyTabControl newTab = new MyTabControl(menuItem.uri.ToString());
                newTab.OpenMode = MyTabOpenMode.ADD;
                browser.addTab(newTab);
            }

        }

    }
}
