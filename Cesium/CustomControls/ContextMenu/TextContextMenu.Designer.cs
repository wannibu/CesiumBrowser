namespace Cesium.CustomControls
{
    partial class TextContextMenu
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
            this.item2 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item1 = new Cesium.CustomControls.CustomContextMenuItem();
            this.line = new System.Windows.Forms.Panel();
            this.item3 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item4 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item5 = new Cesium.CustomControls.CustomContextMenuItem();
            this.SuspendLayout();
            // 
            // item2
            // 
            this.item2.iconVisible = false;
            this.item2.leftText = "复制指向突出显示的内容的链接";
            this.item2.Location = new System.Drawing.Point(0, 30);
            this.item2.Margin = new System.Windows.Forms.Padding(0);
            this.item2.Name = "item2";
            this.item2.rightText = "";
            this.item2.Size = new System.Drawing.Size(290, 29);
            this.item2.TabIndex = 1;
            this.item2.Clicked += new System.EventHandler(this.item2_Click);
            // 
            // item1
            // 
            this.item1.iconVisible = false;
            this.item1.leftText = "复制";
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Margin = new System.Windows.Forms.Padding(0);
            this.item1.Name = "item1";
            this.item1.rightText = "Ctrl+C";
            this.item1.Size = new System.Drawing.Size(290, 29);
            this.item1.TabIndex = 0;
            this.item1.Clicked += new System.EventHandler(this.item1_Click);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line.Location = new System.Drawing.Point(0, 117);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(290, 1);
            this.line.TabIndex = 2;
            // 
            // item3
            // 
            this.item3.iconVisible = false;
            this.item3.leftText = "使用百度搜索";
            this.item3.Location = new System.Drawing.Point(0, 59);
            this.item3.Margin = new System.Windows.Forms.Padding(0);
            this.item3.Name = "item3";
            this.item3.rightText = "";
            this.item3.Size = new System.Drawing.Size(290, 29);
            this.item3.TabIndex = 2;
            this.item3.Clicked += new System.EventHandler(this.item3_Click);
            // 
            // item4
            // 
            this.item4.iconVisible = false;
            this.item4.leftText = "打印";
            this.item4.Location = new System.Drawing.Point(0, 88);
            this.item4.Margin = new System.Windows.Forms.Padding(0);
            this.item4.Name = "item4";
            this.item4.rightText = "Ctrl+P";
            this.item4.Size = new System.Drawing.Size(290, 29);
            this.item4.TabIndex = 2;
            this.item4.Clicked += new System.EventHandler(this.item4_Click);
            // 
            // item5
            // 
            this.item5.iconVisible = false;
            this.item5.leftText = "检查";
            this.item5.Location = new System.Drawing.Point(0, 116);
            this.item5.Margin = new System.Windows.Forms.Padding(0);
            this.item5.Name = "item5";
            this.item5.rightText = "";
            this.item5.Size = new System.Drawing.Size(290, 29);
            this.item5.TabIndex = 2;
            this.item5.Clicked += new System.EventHandler(this.item5_Click);
            // 
            // TextContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.line);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(290, 145);
            this.Name = "TextContextMenu";
            this.Size = new System.Drawing.Size(290, 145);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomContextMenuItem item1;
        private CustomContextMenuItem item2;
        private System.Windows.Forms.Panel line;
        private CustomContextMenuItem item3;
        private CustomContextMenuItem item4;
        private CustomContextMenuItem item5;
    }
}
