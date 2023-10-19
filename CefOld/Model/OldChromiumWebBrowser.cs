using CefSharp;
using CefSharp.Web;
using CefSharp.WinForms;

namespace CefOld.Model
{
    [System.Obsolete]
    public class OldChromiumWebBrowser : ChromiumWebBrowser
    {
        public OldChromiumWebBrowser()
        {
        }

        public OldChromiumWebBrowser(HtmlString html, IRequestContext requestContext = null) : base(html, requestContext)
        {
        }

        public OldChromiumWebBrowser(string address, IRequestContext requestContext = null) : base(address, requestContext)
        {
        }
    }
}
