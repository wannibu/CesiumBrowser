using CefSharp;
using System;
using System.Windows.Forms;
using Cesium.Boot;
using Cesium.CustomControls;
using Cesium.CustomForms;

namespace Cesium.App.CefBrowser.Handler
{
    class MenuHandler : IContextMenuHandler
    {
        private PopUpForm popUpForm;
        private LinkContextMenu linkContextMenu;
        private TextContextMenu textContextMenu;
        private OtherContextMenu otherContextMenu;
        private InputBoxInPageContextMenu inputBoxInPageContextMenu;

        private MyPage myPage;

        public MenuHandler(MyPage myPage)
        {
            this.myPage = myPage;

            linkContextMenu = BootPrepare.GetLinkContextMenu();
            textContextMenu = BootPrepare.GetTextContextMenu();
            otherContextMenu = BootPrepare.GetOtherContextMenu();
            inputBoxInPageContextMenu = BootPrepare.GetInputBoxInPageContextMenu();
        }

        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();

            if (popUpForm == null)
            {
                popUpForm = new PopUpForm(false);
                popUpForm.Show();
                popUpForm.Visible = false;
                popUpForm.VisibleChanged += (s, e1) =>
                {
                    myPage.isActive = popUpForm.Visible;
                };
            }
            if (parameters.LinkUrl != null && !string.IsNullOrEmpty(parameters.LinkUrl.Trim()))
            {
                // 链接
                linkContextMenu.setContent(myPage, parameters.LinkUrl.Trim(), browser, parameters.XCoord, parameters.YCoord);
                popUpForm.SetControl(linkContextMenu);
            }
            else if (parameters.SelectionText != null && !string.IsNullOrEmpty(parameters.SelectionText.Trim()))
            {
                // 选中的文本
                textContextMenu.setContent(myPage, parameters.SelectionText, chromiumWebBrowser.Address, browser, parameters.XCoord, parameters.YCoord);
                popUpForm.SetControl(textContextMenu);
            }
            else if (parameters.IsEditable)
            {
                //输入框
                inputBoxInPageContextMenu.setContent(browser, parameters.XCoord, parameters.YCoord);
                popUpForm.SetControl(inputBoxInPageContextMenu);
            }
            else
            {
                // 其他界面
                otherContextMenu.setContent(browser, parameters.XCoord, parameters.YCoord);
                popUpForm.SetControl(otherContextMenu);
            }
            popUpForm.Top = Cursor.Position.Y;
            popUpForm.Left = Cursor.Position.X;
            popUpForm.Visible = true;
            this.myPage.Invoke((Action)delegate () { this.myPage.Focus(); });
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
