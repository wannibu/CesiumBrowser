using CefSharp;
using System.IO;

namespace Cesium.App.CefBrowser
{

    class DownloadHandler : IDownloadHandler
    {
        private string outputDirectory = @"D:\desktop";

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            var fileName = Path.Combine(outputDirectory, downloadItem.SuggestedFileName);
            callback.Continue(fileName, true);
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            if (downloadItem.IsComplete)
            {
                // 执行相关操作，例如提供下载进度条或通知用户文件已准备好。
            }
        }
    }

}
