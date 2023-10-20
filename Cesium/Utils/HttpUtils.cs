using System;
using System.Text.RegularExpressions;

namespace Cesium.Utils
{
    public class HttpUtils
    {
        public static bool IsValidUrl(string url)
        {
            Regex regex1 = new Regex(@"^(http(s)?://)?([\w-]+\.)?[\w-]+\.[a-zA-Z]{2,5}(:[0-9]{1,5})?(\/[\w-.\/?%&=]*)?$");
            Regex regex2 = new Regex(@"^(http(s)?://)?((\d{1,3}\.){3}\d{1,3})(:[0-9]{1,5})?(\/[\w-.\/?%&=]*)?$");
            Regex regex3 = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");

            Uri uriResult;
            return regex1.Match(url).Success || regex2.Match(url).Success || regex3.Match(url).Success || Uri.TryCreate(url, UriKind.Absolute, out uriResult);
        }

    }
}
