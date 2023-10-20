using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cesium.CustomControls.ContextMenu
{
    public partial class HistoryContextMenuItem : UserControl
    {
        public event EventHandler Clicked;
        public Uri uri { get; set; }

        public HistoryContextMenuItem()
        {
            InitializeComponent();
        }

        private void HistoryContextMenuItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void HistoryContextMenuItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        private void ItemClick(object sender, EventArgs e)
        {
            OnItemClick(e);
        }
        private void OnItemClick(EventArgs e)
        {
            Clicked?.Invoke(this, e);
            this.ParentForm.Visible = false;
        }

    }
}
