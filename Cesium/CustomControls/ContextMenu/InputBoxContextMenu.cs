using System;
using System.Windows.Forms;
using Cesium.Utils;

namespace Cesium.CustomControls
{
    public partial class InputBoxContextMenu : UserControl
    {
        private TextBox inputBox;

        public InputBoxContextMenu()
        {
            InitializeComponent();
        }

        public void setInputBox(TextBox inputBox)
        {
            this.inputBox = inputBox;

            if (inputBox.Text.Length == 0)
                this.item2.Enabled = false;
            else
                this.item2.Enabled = true;

            if (inputBox.SelectedText.Length == 0)
            {
                this.item3.Enabled = false;
                this.item4.Enabled = false;
                this.item7.Enabled = false;
            }
            else
            {
                this.item3.Enabled = true;
                this.item4.Enabled = true;
                this.item7.Enabled = true;
            }

            if (inputBox.Text.Length == 0 && inputBox.SelectedText.Length != 0)
                this.item8.Enabled = false;
            else
                this.item8.Enabled = true;

            string firstContent = ClipboardHelper.GetFirstClipboardContent();

            if (ObjectUtils.IsNullOrEmpty(firstContent))
            {
                this.item5.Enabled = false; this.item6.Enabled = false;
                item6.text_left.Text = "粘贴并";
            }
            else
            {
                this.item5.Enabled = true; this.item6.Enabled = true;
                if (HttpUtils.IsValidUrl(firstContent.Trim()))
                    this.item6.text_left.Text = "粘贴并转到 " + firstContent.Trim();
                else
                    this.item6.text_left.Text = $"粘贴并搜索\"{firstContent.Trim()}\"";
            }
        }

        #region 监听方法
        private void item1_Click(object sender, EventArgs e)
        {

        }

        private void item2_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
            SendKeys.SendWait("^z");
        }

        private void item3_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
            SendKeys.SendWait("^x");
        }

        private void item4_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
            SendKeys.SendWait("^c");
        }

        private void item5_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
            SendKeys.SendWait("^v");
        }

        private void item6_Click(object sender, EventArgs e)
        {
            inputBox.Focus();
            inputBox.Text = ClipboardHelper.GetFirstClipboardContent();
            SendKeys.SendWait("{ENTER}");
        }

        private void item7_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
        }

        private void item8_Click(object sender, EventArgs e)
        {
            inputBox.SelectAll();
        }

        private void item9_Click(object sender, EventArgs e)
        {

        }
        private void item10_Click(object sender, EventArgs e)
        {
            this.item10.icon.Visible = this.item10.iconVisible = !this.item10.iconVisible;
        }
        #endregion

    }
}
