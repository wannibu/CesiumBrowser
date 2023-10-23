using System.Windows.Forms;

namespace Cesium.CustomControls
{
    partial class FormTitle
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
            this.title_right = new System.Windows.Forms.Panel();
            this.title_right_buttonGroup = new System.Windows.Forms.TableLayoutPanel();
            this.btn_collapse = new Cesium.CustomControls.PictureButton();
            this.btn_close = new Cesium.CustomControls.PictureButton();
            this.btn_max = new Cesium.CustomControls.PictureButton();
            this.btn_min = new Cesium.CustomControls.PictureButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.spanLeft = new System.Windows.Forms.Panel();
            this.title_left = new System.Windows.Forms.Panel();
            this.panelTab = new MyTabControlPanel();
            this.btn_addTab = new Cesium.CustomControls.PictureButton();
            this.title_right.SuspendLayout();
            this.title_right_buttonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_collapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            this.title_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addTab)).BeginInit();
            this.SuspendLayout();
            // 
            // title_right
            // 
            this.title_right.Controls.Add(this.title_right_buttonGroup);
            this.title_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.title_right.Location = new System.Drawing.Point(400, 0);
            this.title_right.Margin = new System.Windows.Forms.Padding(0);
            this.title_right.Name = "title_right";
            this.title_right.Size = new System.Drawing.Size(200, 40);
            this.title_right.TabIndex = 0;
            // 
            // title_right_buttonGroup
            // 
            this.title_right_buttonGroup.ColumnCount = 4;
            this.title_right_buttonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.title_right_buttonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.title_right_buttonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.title_right_buttonGroup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.title_right_buttonGroup.Controls.Add(this.btn_collapse, 0, 0);
            this.title_right_buttonGroup.Controls.Add(this.btn_close, 3, 0);
            this.title_right_buttonGroup.Controls.Add(this.btn_max, 2, 0);
            this.title_right_buttonGroup.Controls.Add(this.btn_min, 1, 0);
            this.title_right_buttonGroup.Location = new System.Drawing.Point(20, 0);
            this.title_right_buttonGroup.Margin = new System.Windows.Forms.Padding(0);
            this.title_right_buttonGroup.Name = "title_right_buttonGroup";
            this.title_right_buttonGroup.RowCount = 1;
            this.title_right_buttonGroup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.title_right_buttonGroup.Size = new System.Drawing.Size(180, 30);
            this.title_right_buttonGroup.TabIndex = 3;
            // 
            // btn_collapse
            // 
            this.btn_collapse.BackgroundImage = global::Cesium.Properties.Resources.icons8_collapse_arrow_16;
            this.btn_collapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_collapse.defaultBackImage = true;
            this.btn_collapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_collapse.isCircle = false;
            this.btn_collapse.Location = new System.Drawing.Point(0, 0);
            this.btn_collapse.Margin = new System.Windows.Forms.Padding(0);
            this.btn_collapse.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(184)))));
            this.btn_collapse.MouseClickBackImage = null;
            this.btn_collapse.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_collapse.MouseLeaveBackImage = null;
            this.btn_collapse.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.btn_collapse.MouseOverBackImage = null;
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.point = new System.Drawing.Point(0, 0);
            this.btn_collapse.size = 0;
            this.btn_collapse.Size = new System.Drawing.Size(45, 30);
            this.btn_collapse.TabIndex = 3;
            this.btn_collapse.TabStop = false;
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Cesium.Properties.Resources.icons8_Close_16;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.defaultBackImage = false;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.isCircle = false;
            this.btn_close.Location = new System.Drawing.Point(135, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btn_close.MouseClickBackImage = global::Cesium.Properties.Resources.icons8_Close_s1_16;
            this.btn_close.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_close.MouseLeaveBackImage = global::Cesium.Properties.Resources.icons8_Close_16;
            this.btn_close.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_close.MouseOverBackImage = global::Cesium.Properties.Resources.icons8_Close_s1_16;
            this.btn_close.Name = "btn_close";
            this.btn_close.point = new System.Drawing.Point(0, 0);
            this.btn_close.size = 0;
            this.btn_close.Size = new System.Drawing.Size(45, 30);
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_close_MouseHover);
            // 
            // btn_max
            // 
            this.btn_max.BackgroundImage = global::Cesium.Properties.Resources.icons8_maximize_button_16;
            this.btn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_max.defaultBackImage = true;
            this.btn_max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_max.isCircle = false;
            this.btn_max.Location = new System.Drawing.Point(90, 0);
            this.btn_max.Margin = new System.Windows.Forms.Padding(0);
            this.btn_max.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(184)))));
            this.btn_max.MouseClickBackImage = null;
            this.btn_max.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_max.MouseLeaveBackImage = null;
            this.btn_max.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.btn_max.MouseOverBackImage = null;
            this.btn_max.Name = "btn_max";
            this.btn_max.point = new System.Drawing.Point(0, 0);
            this.btn_max.size = 0;
            this.btn_max.Size = new System.Drawing.Size(45, 30);
            this.btn_max.TabIndex = 1;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            this.btn_max.MouseHover += new System.EventHandler(this.btn_max_MouseHover);
            // 
            // btn_min
            // 
            this.btn_min.BackgroundImage = global::Cesium.Properties.Resources.icons8_subtract_16;
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_min.defaultBackImage = true;
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_min.isCircle = false;
            this.btn_min.Location = new System.Drawing.Point(45, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(0);
            this.btn_min.MouseClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(184)))));
            this.btn_min.MouseClickBackImage = null;
            this.btn_min.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_min.MouseLeaveBackImage = null;
            this.btn_min.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(207)))));
            this.btn_min.MouseOverBackImage = null;
            this.btn_min.Name = "btn_min";
            this.btn_min.point = new System.Drawing.Point(0, 0);
            this.btn_min.size = 0;
            this.btn_min.Size = new System.Drawing.Size(45, 30);
            this.btn_min.TabIndex = 2;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            this.btn_min.MouseHover += new System.EventHandler(this.btn_min_MouseHover);
            // 
            // spanLeft
            // 
            this.spanLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.spanLeft.Location = new System.Drawing.Point(0, 0);
            this.spanLeft.Margin = new System.Windows.Forms.Padding(0);
            this.spanLeft.Name = "spanLeft";
            this.spanLeft.Size = new System.Drawing.Size(10, 40);
            this.spanLeft.TabIndex = 0;
            // 
            // title_left
            // 
            this.title_left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_left.Controls.Add(this.panelTab);
            this.title_left.Controls.Add(this.btn_addTab);
            this.title_left.Controls.Add(this.spanLeft);
            this.title_left.Location = new System.Drawing.Point(0, 0);
            this.title_left.Margin = new System.Windows.Forms.Padding(0);
            this.title_left.Name = "title_left";
            this.title_left.Size = new System.Drawing.Size(400, 40);
            this.title_left.TabIndex = 4;
            // 
            // panelTab
            // 
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTab.Location = new System.Drawing.Point(10, 0);
            this.panelTab.Margin = new System.Windows.Forms.Padding(0);
            this.panelTab.MaximumSize = new System.Drawing.Size(230, 40);
            this.panelTab.MinimumSize = new System.Drawing.Size(230, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelTab.Size = new System.Drawing.Size(230, 40);
            this.panelTab.TabIndex = 3;
            this.panelTab.SizeChanged += new System.EventHandler(this.panelTab_SizeChanged);
            this.panelTab.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelTab_ControlAdded);
            // 
            // btn_addTab
            // 
            this.btn_addTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addTab.BackgroundImage = global::Cesium.Properties.Resources.icons8_addTab;
            this.btn_addTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addTab.defaultBackImage = false;
            this.btn_addTab.isCircle = false;
            this.btn_addTab.Location = new System.Drawing.Point(257, 8);
            this.btn_addTab.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addTab.MouseClickBackColor = System.Drawing.Color.Empty;
            this.btn_addTab.MouseClickBackImage = global::Cesium.Properties.Resources.icons8_addTab_s2;
            this.btn_addTab.MouseLeaveBackColor = System.Drawing.Color.Empty;
            this.btn_addTab.MouseLeaveBackImage = global::Cesium.Properties.Resources.icons8_addTab;
            this.btn_addTab.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btn_addTab.MouseOverBackImage = global::Cesium.Properties.Resources.icons8_addTab_s1;
            this.btn_addTab.Name = "btn_addTab";
            this.btn_addTab.point = new System.Drawing.Point(1, 0);
            this.btn_addTab.size = 26;
            this.btn_addTab.Size = new System.Drawing.Size(30, 30);
            this.btn_addTab.TabIndex = 0;
            this.btn_addTab.TabStop = false;
            this.btn_addTab.Click += new System.EventHandler(this.btn_addTab_Click);
            // 
            // FormTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.title_left);
            this.Controls.Add(this.title_right);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormTitle";
            this.Size = new System.Drawing.Size(600, 40);
            this.BackColorChanged += new System.EventHandler(this.FormTitle_BackColorChanged);
            this.SizeChanged += new System.EventHandler(this.FormTitle_SizeChanged);
            this.title_right.ResumeLayout(false);
            this.title_right_buttonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_collapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            this.title_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolTip toolTip;
        private PictureButton btn_min;
        private PictureButton btn_collapse;
        private Panel spanLeft;
        public MyTabControlPanel panelTab;
        private PictureButton btn_addTab;
        private Panel title_left;
        private Panel title_right;
        private PictureButton btn_max;
        private PictureButton btn_close;
        private System.ComponentModel.IContainer components;
        public TableLayoutPanel title_right_buttonGroup;
    }
}
