namespace Cesium.CustomControls
{
    partial class SearchBox
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.border_Left = new System.Windows.Forms.PictureBox();
            this.border_Right = new System.Windows.Forms.PictureBox();
            this.border_Center = new System.Windows.Forms.PictureBox();
            this.btn_share = new Cesium.CustomControls.PictureButton();
            this.btn_star = new Cesium.CustomControls.PictureButton();
            this.btn_webInfo = new Cesium.CustomControls.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.border_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_share)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_webInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.inputBox.Location = new System.Drawing.Point(32, 4);
            this.inputBox.Margin = new System.Windows.Forms.Padding(0);
            this.inputBox.MaximumSize = new System.Drawing.Size(80, 21);
            this.inputBox.MinimumSize = new System.Drawing.Size(80, 21);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(80, 21);
            this.inputBox.TabIndex = 6;
            this.inputBox.WordWrap = false;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.Enter += new System.EventHandler(this.inputBox_Enter);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            this.inputBox.Leave += new System.EventHandler(this.inputBox_Leave);
            this.inputBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputBox_MouseDown);
            this.inputBox.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.inputBox.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // border_Left
            // 
            this.border_Left.BackgroundImage = global::Cesium.Properties.Resources.searchBox_Border_Left;
            this.border_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.border_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.border_Left.Location = new System.Drawing.Point(0, 0);
            this.border_Left.Margin = new System.Windows.Forms.Padding(0);
            this.border_Left.Name = "border_Left";
            this.border_Left.Size = new System.Drawing.Size(100, 30);
            this.border_Left.TabIndex = 7;
            this.border_Left.TabStop = false;
            this.border_Left.Visible = false;
            // 
            // border_Right
            // 
            this.border_Right.BackgroundImage = global::Cesium.Properties.Resources.searchBox_Border_Right;
            this.border_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.border_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.border_Right.Location = new System.Drawing.Point(500, 0);
            this.border_Right.Margin = new System.Windows.Forms.Padding(0);
            this.border_Right.Name = "border_Right";
            this.border_Right.Size = new System.Drawing.Size(100, 30);
            this.border_Right.TabIndex = 8;
            this.border_Right.TabStop = false;
            this.border_Right.Visible = false;
            // 
            // border_Center
            // 
            this.border_Center.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.border_Center.BackgroundImage = global::Cesium.Properties.Resources.searchBox_Border_Center;
            this.border_Center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.border_Center.Location = new System.Drawing.Point(100, 0);
            this.border_Center.Margin = new System.Windows.Forms.Padding(0);
            this.border_Center.Name = "border_Center";
            this.border_Center.Size = new System.Drawing.Size(400, 30);
            this.border_Center.TabIndex = 9;
            this.border_Center.TabStop = false;
            this.border_Center.Visible = false;
            // 
            // btn_share
            // 
            this.btn_share.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_share.BackgroundImage = global::Cesium.Properties.Resources.icons8_share_16;
            this.btn_share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_share.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_share.defaultBackImage = true;
            this.btn_share.isCircle = true;
            this.btn_share.Location = new System.Drawing.Point(530, 1);
            this.btn_share.Margin = new System.Windows.Forms.Padding(0);
            this.btn_share.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_share.MouseClickBackImage = null;
            this.btn_share.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_share.MouseLeaveBackImage = null;
            this.btn_share.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_share.MouseOverBackImage = null;
            this.btn_share.Name = "btn_share";
            this.btn_share.point = new System.Drawing.Point(1, 0);
            this.btn_share.size = 25;
            this.btn_share.Size = new System.Drawing.Size(30, 27);
            this.btn_share.TabIndex = 5;
            this.btn_share.TabStop = false;
            // 
            // btn_star
            // 
            this.btn_star.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_star.BackgroundImage = global::Cesium.Properties.Resources.icons8_star_16;
            this.btn_star.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_star.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_star.defaultBackImage = true;
            this.btn_star.isCircle = true;
            this.btn_star.Location = new System.Drawing.Point(561, 1);
            this.btn_star.Margin = new System.Windows.Forms.Padding(0);
            this.btn_star.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_star.MouseClickBackImage = null;
            this.btn_star.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_star.MouseLeaveBackImage = null;
            this.btn_star.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_star.MouseOverBackImage = null;
            this.btn_star.Name = "btn_star";
            this.btn_star.point = new System.Drawing.Point(1, 0);
            this.btn_star.size = 25;
            this.btn_star.Size = new System.Drawing.Size(30, 27);
            this.btn_star.TabIndex = 4;
            this.btn_star.TabStop = false;
            // 
            // btn_webInfo
            // 
            this.btn_webInfo.BackgroundImage = global::Cesium.Properties.Resources.icons8_webInfo_baidu;
            this.btn_webInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_webInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_webInfo.defaultBackImage = true;
            this.btn_webInfo.isCircle = true;
            this.btn_webInfo.Location = new System.Drawing.Point(4, 2);
            this.btn_webInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_webInfo.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btn_webInfo.MouseClickBackImage = null;
            this.btn_webInfo.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_webInfo.MouseLeaveBackImage = null;
            this.btn_webInfo.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_webInfo.MouseOverBackImage = null;
            this.btn_webInfo.Name = "btn_webInfo";
            this.btn_webInfo.point = new System.Drawing.Point(1, 0);
            this.btn_webInfo.size = 25;
            this.btn_webInfo.Size = new System.Drawing.Size(28, 27);
            this.btn_webInfo.TabIndex = 3;
            this.btn_webInfo.TabStop = false;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.btn_share);
            this.Controls.Add(this.btn_star);
            this.Controls.Add(this.btn_webInfo);
            this.Controls.Add(this.border_Left);
            this.Controls.Add(this.border_Right);
            this.Controls.Add(this.border_Center);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(600, 30);
            this.Load += new System.EventHandler(this.SearchBox_Load);
            this.SizeChanged += new System.EventHandler(this.SearchBox_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputBox_MouseDown);
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.border_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_share)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_webInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureButton btn_star;
        private PictureButton btn_share;
        public System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox border_Left;
        private System.Windows.Forms.PictureBox border_Right;
        private System.Windows.Forms.PictureBox border_Center;
        public PictureButton btn_webInfo;
    }
}
