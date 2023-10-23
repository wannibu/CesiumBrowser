using System.Windows.Forms;

namespace Cesium.Events
{
    public class ExtendedKeyEventArgs : KeyEventArgs
    {
        public bool CtrlKeyDown { get; }
        public bool AltKeyDown { get; }
        public bool ShiftKeyDown { get; }

        public ExtendedKeyEventArgs(Keys keyCode, bool ctrlKeyDown, bool altKeyDown, bool shiftKeyDown)
            : base(keyCode)
        {
            CtrlKeyDown = ctrlKeyDown;
            AltKeyDown = altKeyDown;
            ShiftKeyDown = shiftKeyDown;
        }
    }

}
