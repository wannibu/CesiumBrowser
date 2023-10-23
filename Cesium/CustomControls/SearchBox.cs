using System;
using System.Drawing;
using System.Windows.Forms;
using Cesium.Boot;
using Cesium.CustomForms;

namespace Cesium.CustomControls
{
    public partial class SearchBox : UserControl
    {
        public bool isActive = false;
        private bool _borderVisible = false;
        private PopUpForm popUpForm;
        private InputBoxContextMenu inputBoxContextMenu;

        public SearchBox()
        {
            InitializeComponent();
            this.inputBox.ContextMenu = new System.Windows.Forms.ContextMenu();

            popUpForm = new PopUpForm(false);
            popUpForm.VisibleChanged += (s, e1) =>
            {
                isActive = popUpForm.Visible;
            };
            popUpForm.Show();
            popUpForm.Visible = false;
            inputBoxContextMenu = BootPrepare.GetInputBoxContextMenu();
        }

        #region InputBox
        private void inputBox_Enter(object sender, EventArgs e)
        {
            inputBox.SelectAll();
            inputBox.Width = inputBox.MaximumSize.Width;
            btn_webInfo.Visible = false;
            _borderVisible = true;
            inputBox.BackColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void inputBox_Leave(object sender, EventArgs e)
        {
            btn_webInfo.Visible = true;
            _borderVisible = false;
            DrawRectRgn();
            this.border_Left.Visible = _borderVisible;
            this.border_Center.Visible = _borderVisible;
            this.border_Right.Visible = _borderVisible;
            this.BackColor = Color.FromArgb(241, 243, 244);
            inputBox.BackColor = Color.FromArgb(241, 243, 244);
            inputBox.Width = (int)inputBox.CreateGraphics().MeasureString(inputBox.Text, inputBox.Font).Width;
        }
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }
        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            if (!_borderVisible)
            {
                TextBox textBox = sender as TextBox;
                textBox.Width = (int)textBox.CreateGraphics().MeasureString(textBox.Text, textBox.Font).Width;
            }
        }
        private void inputBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                inputBoxContextMenu.setInputBox(this.inputBox);
                popUpForm.SetControl(inputBoxContextMenu);
                popUpForm.Top = Cursor.Position.Y;
                popUpForm.Left = Cursor.Position.X;
                popUpForm.Visible = true;
                this.inputBox.Focus();
            }
        }

        #endregion

        public void mouseEnter(object sender, EventArgs e)
        {
            if (!inputBox.Focused)
            {
                inputBox.BackColor = Color.FromArgb(233, 235, 236);
                BackColor = Color.FromArgb(233, 235, 236);
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (!inputBox.Focused && !isActive)
            {
                this.inputBox.BackColor = Color.FromArgb(241, 243, 244);
                this.BackColor = Color.FromArgb(241, 243, 244);
            }
        }

        private void SearchBox_Load(object sender, EventArgs e)
        {
            DrawRectRgn();
        }
        private void SearchBox_SizeChanged(object sender, EventArgs e)
        {
            DrawRectRgn();
            this.inputBox.MaximumSize = new Size(this.inputBox.Location.X + btn_share.Left - 100, this.inputBox.MaximumSize.Height);
            this.inputBox.Width = (int)inputBox.CreateGraphics().MeasureString(inputBox.Text, inputBox.Font).Width;
        }

        private void DrawRectRgn()
        {
            IntPtr ptr;
            if (_borderVisible)
                ptr = Win32.CreateRoundRectRgn(-1, -1, Width + 2, Height + 2, 15 * 2, 15 * 2);
            else
                ptr = Win32.CreateRoundRectRgn(0, 0, Width, Height, 15 * 2, 15 * 2);
            Region = Region.FromHrgn(ptr);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawRectRgn();
            this.border_Left.Visible = _borderVisible;
            this.border_Center.Visible = _borderVisible;
            this.border_Right.Visible = _borderVisible;
        }

    }
}
