using CefSharp;
using CefSharp.Web;
using CefSharp.WinForms;

namespace CefNew.Model
{
    public class NewChromiumWebBrowser : ChromiumWebBrowser
    {
        public NewChromiumWebBrowser()
        {
        }

        public NewChromiumWebBrowser(HtmlString html, IRequestContext requestContext = null) : base(html, requestContext)
        {
        }

        public NewChromiumWebBrowser(string address, IRequestContext requestContext = null) : base(address, requestContext)
        {
        }
    }
}
