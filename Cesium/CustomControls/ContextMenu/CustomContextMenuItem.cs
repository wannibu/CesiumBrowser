using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cesium.CustomControls
{
    public partial class CustomContextMenuItem : UserControl
    {
        public string rightText { get; set; }
        public string leftText { get; set; }
        public bool iconVisible { get; set; }

        public event EventHandler Clicked;

        public CustomContextMenuItem()
        {
            InitializeComponent();
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.BackColor = SystemColors.Control;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            panel.BackColor = Color.White;

        }

        private void InputBoxContextMenuItem_Load(object sender, EventArgs e)
        {
            this.text_left.Text = leftText;
            this.text_right.Text = rightText;
            this.icon.Visible = iconVisible;
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
