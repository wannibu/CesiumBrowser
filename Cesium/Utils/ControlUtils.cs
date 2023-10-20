using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Cesium.Utils
{
    public static class ControlUtils
    {
        public static void RemoveControlEvent(this Control control, string eventName)
        {
            FieldInfo _fl = typeof(Control).GetField(eventName, BindingFlags.Static | BindingFlags.NonPublic);
            if (_fl != null)
            {
                object _obj = _fl.GetValue(control);
                PropertyInfo _pi = control.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
                EventHandlerList _eventlist = (EventHandlerList)_pi.GetValue(control, null);
                if (_obj != null && _eventlist != null)
                    _eventlist.RemoveHandler(_obj, _eventlist[_obj]);
            }
        }
    }
}
