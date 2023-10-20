using System;
using System.Windows.Forms;

namespace Cesium.Utils
{
    public class ClipboardHelper
    {
        public static string GetFirstClipboardContent()
        {
            // 获取剪贴板的文本内容
            string clipboardText = Clipboard.GetText();

            // 获取第一条内容
            if (!string.IsNullOrEmpty(clipboardText))
            {
                string[] lines = clipboardText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length > 0)
                {
                    return lines[0];
                }
            }
            return null;
        }

        public static void setContent(string content)
        {
            Clipboard.SetText(content);
        }

    }

}
