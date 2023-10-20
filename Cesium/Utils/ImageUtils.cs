using System.Drawing;
using System.IO;

namespace Cesium.Utils
{
    public class ImageUtils
    {
        public static byte[] ImageToByte(Image Picture)
        {
            MemoryStream ms = new MemoryStream();
            if (Picture == null)
                return new byte[ms.Length];
            Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] BPicture = new byte[ms.Length];
            BPicture = ms.GetBuffer();
            return BPicture;
        }

        public static Image ByteToImage(object value)
        {
            byte[] picData = (byte[])value;
            MemoryStream ms = new MemoryStream(picData);
            Image img = Image.FromStream(ms);
            ms.Close();
            return img;
        }

    }
}
