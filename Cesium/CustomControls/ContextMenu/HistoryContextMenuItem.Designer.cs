namespace Cesium.CustomControls.ContextMenu
{
    partial class HistoryContextMenuItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.icon = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.url_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icon.Image = global::Cesium.Properties.Resources.tab_icon;
            this.icon.Location = new System.Drawing.Point(10, 15);
            this.icon.Margin = new System.Windows.Forms.Padding(0);
            this.icon.MaximumSize = new System.Drawing.Size(30, 30);
            this.icon.MinimumSize = new System.Drawing.Size(30, 30);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(30, 30);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.HistoryContextMenuItem_MouseLeave);
            this.icon.MouseEnter += new System.EventHandler(this.HistoryContextMenuItem_MouseEnter);
            this.icon.MouseLeave += new System.EventHandler(this.HistoryContextMenuItem_MouseLeave);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title.Location = new System.Drawing.Point(40, 15);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.MaximumSize = new System.Drawing.Size(270, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(65, 17);
            this.title.TabIndex = 2;
            this.title.Text = "新标签页";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.ItemClick);
            this.title.MouseEnter += new System.EventHandler(this.HistoryContextMenuItem_MouseEnter);
            this.title.MouseLeave += new System.EventHandler(this.HistoryContextMenuItem_MouseLeave);
            // 
            // url_time
            // 
            this.url_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.url_time.AutoSize = true;
            this.url_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.url_time.ForeColor = System.Drawing.Color.Gray;
            this.url_time.Location = new System.Drawing.Point(41, 34);
            this.url_time.Margin = new System.Windows.Forms.Padding(0);
            this.url_time.MaximumSize = new System.Drawing.Size(250, 17);
            this.url_time.Name = "url_time";
            this.url_time.Size = new System.Drawing.Size(56, 17);
            this.url_time.TabIndex = 3;
            this.url_time.Text = "新标签页";
            this.url_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.url_time.Click += new System.EventHandler(this.ItemClick);
            this.url_time.MouseEnter += new System.EventHandler(this.HistoryContextMenuItem_MouseEnter);
            this.url_time.MouseLeave += new System.EventHandler(this.HistoryContextMenuItem_MouseLeave);
            // 
            // HistoryContextMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.url_time);
            this.Controls.Add(this.title);
            this.Controls.Add(this.icon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(325, 60);
            this.MinimumSize = new System.Drawing.Size(325, 60);
            this.Name = "HistoryContextMenuItem";
            this.Size = new System.Drawing.Size(325, 60);
            this.Click += new System.EventHandler(this.ItemClick);
            this.MouseEnter += new System.EventHandler(this.HistoryContextMenuItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.HistoryContextMenuItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox icon;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label url_time;
    }
}
