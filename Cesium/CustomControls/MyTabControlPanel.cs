using System;
using System.Windows.Forms;
using Cesium.App.CefBrowser.Tab;
using Cesium.CustomControls;

namespace Cesium.App.CefBrowser
{
    public partial class MyTabControlPanel : UserControl
    {

        public MyTabControlPanel()
        {
            InitializeComponent();
        }

        private void MyTabControlPanel_Load(object sender, EventArgs e)
        {

        }

        public void resizePanelWidth()
        {
            int allControlWidth = 0;
            foreach (Control control in this.Controls)
            {
                allControlWidth += control.Width;
                control.Top = Height - control.Height;
            }

            int marginLeft = 0;
            FormTitle parentTitle = this.Parent.Parent as FormTitle;
            if (parentTitle.TabControlList.Count > 0)
            {
                if (allControlWidth >= this.MaximumSize.Width ||
                    parentTitle.TabControlList[0].Width != parentTitle.TabControlList[0].MaximumSize.Width)
                {
                    int wid = this.MaximumSize.Width / parentTitle.TabControlList.Count;
                    foreach (Control control in parentTitle.TabControlList)
                    {
                        control.Width = wid;
                        control.Left = marginLeft;
                        marginLeft += control.Width;
                    }
                }
                else
                {
                    foreach (Control control in parentTitle.TabControlList)
                    {
                        control.Left = marginLeft;
                        marginLeft += control.Width;
                    }
                }
                this.Width = marginLeft;
            }
        }

        private void MyTabControlPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (this.ParentForm != null)
            {
                FormTitle parentTitle = (this.ParentForm as Browser).Title;

                MyTabControl tab = e.Control as MyTabControl;
                if (tab != null)
                {
                    switch (tab.OpenMode)
                    {
                        case MyTabOpenMode.ADD:
                            parentTitle.TabControlList.Add(e.Control as MyTabControl);
                            break;
                        case MyTabOpenMode.INSERT:
                            parentTitle.TabControlList.Insert(tab.insertLocation, e.Control as MyTabControl);
                            break;
                        case MyTabOpenMode.NEWWINDOW:
                            parentTitle.TabControlList.Add(e.Control as MyTabControl);
                            break;
                        case MyTabOpenMode.APPEND:
                            parentTitle.TabControlList.Insert(tab.insertLocation > parentTitle.TabControlList.Count ? parentTitle.TabControlList.Count : tab.insertLocation, e.Control as MyTabControl);
                            break;
                    }
                    resizePanelWidth();
                }

            }
        }

        private void MyTabControlPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            resizePanelWidth();
        }

    }
}
