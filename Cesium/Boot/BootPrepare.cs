using Cesium.CustomControls;
using Cesium.DataBase;

namespace test.boot
{
    public class BootPrepare
    {
        private static LinkContextMenu linkContextMenu;
        private static TextContextMenu TextContextMenu;
        private static OtherContextMenu otherContextMenu;
        private static InputBoxContextMenu inputBoxContextMenu;
        private static InputBoxInPageContextMenu inputBoxInPageContextMenu;

        public BootPrepare()
        {
            DbSeed.InitData();
            linkContextMenu = new LinkContextMenu();
            TextContextMenu = new TextContextMenu();
            otherContextMenu = new OtherContextMenu();
            inputBoxContextMenu = new InputBoxContextMenu();
            inputBoxInPageContextMenu = new InputBoxInPageContextMenu();
        }

        public static LinkContextMenu GetLinkContextMenu()
        {
            return linkContextMenu;
        }
        public static TextContextMenu GetTextContextMenu()
        {
            return TextContextMenu;
        }
        public static OtherContextMenu GetOtherContextMenu()
        {
            return otherContextMenu;
        }
        public static InputBoxContextMenu GetInputBoxContextMenu()
        {
            return inputBoxContextMenu;
        }        
        public static InputBoxInPageContextMenu GetInputBoxInPageContextMenu()
        {
            return inputBoxInPageContextMenu;
        }

    }

}
