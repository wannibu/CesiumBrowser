namespace Cesium.CustomControls
{
    partial class CustomContextMenuItem
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
            this.panel = new System.Windows.Forms.Panel();
            this.icon = new Cesium.CustomControls.PictureButton();
            this.text_left = new System.Windows.Forms.Label();
            this.text_right = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.icon);
            this.panel.Controls.Add(this.text_left);
            this.panel.Controls.Add(this.text_right);
            this.panel.Location = new System.Drawing.Point(0, 3);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(170, 23);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.ItemClick);
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // icon
            // 
            this.icon.BackgroundImage = global::Cesium.Properties.Resources.check;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icon.defaultBackImage = true;
            this.icon.isCircle = false;
            this.icon.Location = new System.Drawing.Point(10, 0);
            this.icon.Margin = new System.Windows.Forms.Padding(0);
            this.icon.MouseClickBackColor = System.Drawing.Color.Empty;
            this.icon.MouseClickBackImage = null;
            this.icon.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.icon.MouseLeaveBackImage = null;
            this.icon.MouseOverBackColor = System.Drawing.Color.Empty;
            this.icon.MouseOverBackImage = null;
            this.icon.Name = "icon";
            this.icon.point = new System.Drawing.Point(0, 0);
            this.icon.size = 0;
            this.icon.Size = new System.Drawing.Size(23, 23);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.ItemClick);
            // 
            // text_left
            // 
            this.text_left.AutoSize = true;
            this.text_left.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_left.Location = new System.Drawing.Point(33, 3);
            this.text_left.Margin = new System.Windows.Forms.Padding(0);
            this.text_left.MaximumSize = new System.Drawing.Size(290, 17);
            this.text_left.MinimumSize = new System.Drawing.Size(30, 17);
            this.text_left.Name = "text_left";
            this.text_left.Size = new System.Drawing.Size(30, 17);
            this.text_left.TabIndex = 0;
            this.text_left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.text_left.Click += new System.EventHandler(this.ItemClick);
            this.text_left.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.text_left.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // text_right
            // 
            this.text_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.text_right.AutoSize = true;
            this.text_right.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_right.Location = new System.Drawing.Point(74, 3);
            this.text_right.Margin = new System.Windows.Forms.Padding(0);
            this.text_right.MinimumSize = new System.Drawing.Size(96, 17);
            this.text_right.Name = "text_right";
            this.text_right.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.text_right.Size = new System.Drawing.Size(96, 17);
            this.text_right.TabIndex = 0;
            this.text_right.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.text_right.Click += new System.EventHandler(this.ItemClick);
            this.text_right.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.text_right.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // CustomContextMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CustomContextMenuItem";
            this.Size = new System.Drawing.Size(170, 29);
            this.Load += new System.EventHandler(this.InputBoxContextMenuItem_Load);
            this.Click += new System.EventHandler(this.ItemClick);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Label text_left;
        public System.Windows.Forms.Label text_right;
        public CustomControls.PictureButton icon;
    }
}
