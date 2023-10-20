using CefSharp.WinForms;
using test.CustomControls;

namespace Cesium.CustomControls
{
    partial class MyPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer CustomControls = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (CustomControls != null))
            {
                CustomControls.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.line = new System.Windows.Forms.Panel();
            this.panelTool = new System.Windows.Forms.Panel();
            this.searchBox = new test.CustomControls.SearchBox();
            this.panelToolRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnRight3 = new test.CustomControls.PictureButton();
            this.btnRight1 = new test.CustomControls.PictureButton();
            this.btnRight2 = new test.CustomControls.PictureButton();
            this.panelToolBarLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back = new test.CustomControls.PictureButton();
            this.btn_refresh = new test.CustomControls.PictureButton();
            this.btn_forward = new test.CustomControls.PictureButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.updateTitleTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.panelToolRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight2)).BeginInit();
            this.panelToolBarLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_forward)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.line, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.panelTool, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelMenu, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelBrowser, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1024, 768);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.line.Location = new System.Drawing.Point(0, 64);
            this.line.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1024, 1);
            this.line.TabIndex = 2;
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.searchBox);
            this.panelTool.Controls.Add(this.panelToolRight);
            this.panelTool.Controls.Add(this.panelToolBarLeft);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Margin = new System.Windows.Forms.Padding(0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(1024, 36);
            this.panelTool.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoSize = true;
            this.searchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Location = new System.Drawing.Point(103, 4);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(807, 30);
            this.searchBox.TabIndex = 6;
            // 
            // panelToolRight
            // 
            this.panelToolRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToolRight.ColumnCount = 3;
            this.panelToolRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.panelToolRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.panelToolRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.panelToolRight.Controls.Add(this.btnRight3, 2, 0);
            this.panelToolRight.Controls.Add(this.btnRight1, 0, 0);
            this.panelToolRight.Controls.Add(this.btnRight2, 1, 0);
            this.panelToolRight.Location = new System.Drawing.Point(915, 0);
            this.panelToolRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolRight.MinimumSize = new System.Drawing.Size(100, 36);
            this.panelToolRight.Name = "panelToolRight";
            this.panelToolRight.RowCount = 1;
            this.panelToolRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelToolRight.Size = new System.Drawing.Size(100, 36);
            this.panelToolRight.TabIndex = 6;
            // 
            // btnRight3
            // 
            this.btnRight3.BackgroundImage = global::test.Properties.Resources.icons8_more_16;
            this.btnRight3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight3.defaultBackImage = true;
            this.btnRight3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRight3.isCircle = true;
            this.btnRight3.Location = new System.Drawing.Point(66, 4);
            this.btnRight3.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.btnRight3.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnRight3.MouseClickBackImage = null;
            this.btnRight3.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btnRight3.MouseLeaveBackImage = null;
            this.btnRight3.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRight3.MouseOverBackImage = null;
            this.btnRight3.Name = "btnRight3";
            this.btnRight3.point = new System.Drawing.Point(0, 0);
            this.btnRight3.size = 28;
            this.btnRight3.Size = new System.Drawing.Size(31, 30);
            this.btnRight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRight3.TabIndex = 3;
            this.btnRight3.TabStop = false;
            // 
            // btnRight1
            // 
            this.btnRight1.BackgroundImage = global::test.Properties.Resources.icons8_plug_16;
            this.btnRight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight1.defaultBackImage = true;
            this.btnRight1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRight1.isCircle = true;
            this.btnRight1.Location = new System.Drawing.Point(0, 4);
            this.btnRight1.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.btnRight1.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnRight1.MouseClickBackImage = null;
            this.btnRight1.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btnRight1.MouseLeaveBackImage = null;
            this.btnRight1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRight1.MouseOverBackImage = null;
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.point = new System.Drawing.Point(-1, 0);
            this.btnRight1.size = 28;
            this.btnRight1.Size = new System.Drawing.Size(30, 30);
            this.btnRight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRight1.TabIndex = 1;
            this.btnRight1.TabStop = false;
            // 
            // btnRight2
            // 
            this.btnRight2.BackgroundImage = global::test.Properties.Resources.icons8_user_16;
            this.btnRight2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight2.defaultBackImage = true;
            this.btnRight2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRight2.isCircle = true;
            this.btnRight2.Location = new System.Drawing.Point(33, 4);
            this.btnRight2.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.btnRight2.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnRight2.MouseClickBackImage = null;
            this.btnRight2.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btnRight2.MouseLeaveBackImage = null;
            this.btnRight2.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRight2.MouseOverBackImage = null;
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.point = new System.Drawing.Point(0, 0);
            this.btnRight2.size = 28;
            this.btnRight2.Size = new System.Drawing.Size(30, 30);
            this.btnRight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRight2.TabIndex = 2;
            this.btnRight2.TabStop = false;
            // 
            // panelToolBarLeft
            // 
            this.panelToolBarLeft.ColumnCount = 5;
            this.panelToolBarLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.panelToolBarLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelToolBarLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelToolBarLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelToolBarLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelToolBarLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelToolBarLeft.Controls.Add(this.btn_back, 1, 0);
            this.panelToolBarLeft.Controls.Add(this.btn_refresh, 3, 0);
            this.panelToolBarLeft.Controls.Add(this.btn_forward, 2, 0);
            this.panelToolBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelToolBarLeft.Location = new System.Drawing.Point(0, 0);
            this.panelToolBarLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolBarLeft.Name = "panelToolBarLeft";
            this.panelToolBarLeft.RowCount = 1;
            this.panelToolBarLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelToolBarLeft.Size = new System.Drawing.Size(102, 36);
            this.panelToolBarLeft.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::test.Properties.Resources.icons8_back_s1_16;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.defaultBackImage = true;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.Enabled = false;
            this.btn_back.isCircle = true;
            this.btn_back.Location = new System.Drawing.Point(8, 4);
            this.btn_back.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_back.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_back.MouseClickBackImage = null;
            this.btn_back.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_back.MouseLeaveBackImage = null;
            this.btn_back.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_back.MouseOverBackImage = null;
            this.btn_back.Name = "btn_back";
            this.btn_back.point = new System.Drawing.Point(0, 0);
            this.btn_back.size = 28;
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 1;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImage = global::test.Properties.Resources.icons8_refresh_16;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refresh.defaultBackImage = true;
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_refresh.isCircle = true;
            this.btn_refresh.Location = new System.Drawing.Point(68, 4);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_refresh.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_refresh.MouseClickBackImage = null;
            this.btn_refresh.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_refresh.MouseLeaveBackImage = null;
            this.btn_refresh.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_refresh.MouseOverBackImage = null;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.point = new System.Drawing.Point(0, 0);
            this.btn_refresh.size = 28;
            this.btn_refresh.Size = new System.Drawing.Size(30, 30);
            this.btn_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.BackgroundImage = global::test.Properties.Resources.icons8_forward_s1_16;
            this.btn_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_forward.defaultBackImage = true;
            this.btn_forward.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_forward.Enabled = false;
            this.btn_forward.isCircle = true;
            this.btn_forward.Location = new System.Drawing.Point(38, 4);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btn_forward.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_forward.MouseClickBackImage = null;
            this.btn_forward.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_forward.MouseLeaveBackImage = null;
            this.btn_forward.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_forward.MouseOverBackImage = null;
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.point = new System.Drawing.Point(0, 0);
            this.btn_forward.size = 28;
            this.btn_forward.Size = new System.Drawing.Size(30, 30);
            this.btn_forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_forward.TabIndex = 2;
            this.btn_forward.TabStop = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 36);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1024, 26);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "菜单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBrowser
            // 
            this.panelBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrowser.Location = new System.Drawing.Point(0, 65);
            this.panelBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(1024, 704);
            this.panelBrowser.TabIndex = 6;
            // 
            // updateTitleTimer
            // 
            this.updateTitleTimer.Enabled = true;
            this.updateTitleTimer.Interval = 1000;
            this.updateTitleTimer.Tick += new System.EventHandler(this.updateTitleTimer_Tick);
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MyPage";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.MyPage_Load);
            this.SizeChanged += new System.EventHandler(this.MyPage_SizeChanged);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.panelToolRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight2)).EndInit();
            this.panelToolBarLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_forward)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ChromiumWebBrowser browser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel panelTool;
        public SearchBox searchBox;
        private System.Windows.Forms.TableLayoutPanel panelToolRight;
        private PictureButton btnRight3;
        private PictureButton btnRight1;
        private PictureButton btnRight2;
        private System.Windows.Forms.TableLayoutPanel panelToolBarLeft;
        private PictureButton btn_back;
        private PictureButton btn_refresh;
        private PictureButton btn_forward;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panelBrowser;
        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer updateTitleTimer;
        private System.ComponentModel.IContainer components;
    }
}
