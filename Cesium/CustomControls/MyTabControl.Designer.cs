using Cesium.CustomControls;

namespace Cesium.CustomControls
{
    partial class MyTabControl
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
            this.title = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btn_closeTab = new Cesium.CustomControls.PictureButton();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Location = new System.Drawing.Point(31, 9);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.MaximumSize = new System.Drawing.Size(190, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(56, 17);
            this.title.TabIndex = 1;
            this.title.Text = "新标签页";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Paint += new System.Windows.Forms.PaintEventHandler(this.title_Paint);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(142)))), ((int)(((byte)(146)))));
            this.line.Location = new System.Drawing.Point(27, 6);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1, 21);
            this.line.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btn_closeTab);
            this.panelRight.Controls.Add(this.line);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(211, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(29, 33);
            this.panelRight.TabIndex = 5;
            // 
            // btn_closeTab
            // 
            this.btn_closeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeTab.BackgroundImage = global::Cesium.Properties.Resources.tab_close;
            this.btn_closeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_closeTab.defaultBackImage = false;
            this.btn_closeTab.isCircle = false;
            this.btn_closeTab.Location = new System.Drawing.Point(3, 7);
            this.btn_closeTab.Margin = new System.Windows.Forms.Padding(0);
            this.btn_closeTab.MouseClickBackColor = System.Drawing.Color.Empty;
            this.btn_closeTab.MouseClickBackImage = global::Cesium.Properties.Resources.tab_close_s2;
            this.btn_closeTab.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_closeTab.MouseLeaveBackImage = global::Cesium.Properties.Resources.tab_close;
            this.btn_closeTab.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btn_closeTab.MouseOverBackImage = global::Cesium.Properties.Resources.tab_close_s1;
            this.btn_closeTab.Name = "btn_closeTab";
            this.btn_closeTab.point = new System.Drawing.Point(0, 1);
            this.btn_closeTab.size = 17;
            this.btn_closeTab.Size = new System.Drawing.Size(20, 20);
            this.btn_closeTab.TabIndex = 4;
            this.btn_closeTab.TabStop = false;
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icon.Image = global::Cesium.Properties.Resources.tab_icon;
            this.icon.Location = new System.Drawing.Point(3, 2);
            this.icon.Margin = new System.Windows.Forms.Padding(0);
            this.icon.MaximumSize = new System.Drawing.Size(30, 30);
            this.icon.MinimumSize = new System.Drawing.Size(30, 30);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(30, 30);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.Controls.Add(this.icon);
            this.panelLeft.Controls.Add(this.title);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(211, 33);
            this.panelLeft.TabIndex = 6;
            // 
            // MyTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(240, 33);
            this.MinimumSize = new System.Drawing.Size(50, 33);
            this.Name = "MyTabControl";
            this.Size = new System.Drawing.Size(240, 33);
            this.Load += new System.EventHandler(this.MyTabControl_Load);
            this.SizeChanged += new System.EventHandler(this.MyTabControl_SizeChanged);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public PictureButton btn_closeTab;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.PictureBox icon;
        public System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
    }
}
