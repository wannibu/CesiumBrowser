namespace Cesium.CustomControls
{
    partial class LinkContextMenu
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
            this.line = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.item6 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item5 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item4 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item3 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item2 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item1 = new Cesium.CustomControls.CustomContextMenuItem();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line.Location = new System.Drawing.Point(0, 88);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(200, 1);
            this.line.TabIndex = 2;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line1.Location = new System.Drawing.Point(0, 145);
            this.line1.Margin = new System.Windows.Forms.Padding(0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(200, 1);
            this.line1.TabIndex = 2;
            // 
            // item6
            // 
            this.item6.AutoSize = true;
            this.item6.iconVisible = false;
            this.item6.leftText = "检查";
            this.item6.Location = new System.Drawing.Point(0, 146);
            this.item6.Margin = new System.Windows.Forms.Padding(0);
            this.item6.Name = "item6";
            this.item6.rightText = "";
            this.item6.Size = new System.Drawing.Size(200, 29);
            this.item6.TabIndex = 5;
            this.item6.Clicked += new System.EventHandler(this.item6_Click);
            // 
            // item5
            // 
            this.item5.AutoSize = true;
            this.item5.iconVisible = false;
            this.item5.leftText = "复制链接地址";
            this.item5.Location = new System.Drawing.Point(0, 117);
            this.item5.Margin = new System.Windows.Forms.Padding(0);
            this.item5.Name = "item5";
            this.item5.rightText = "";
            this.item5.Size = new System.Drawing.Size(200, 29);
            this.item5.TabIndex = 4;
            this.item5.Clicked += new System.EventHandler(this.item5_Click);
            // 
            // item4
            // 
            this.item4.AutoSize = true;
            this.item4.iconVisible = false;
            this.item4.leftText = "链接另存为...";
            this.item4.Location = new System.Drawing.Point(0, 88);
            this.item4.Margin = new System.Windows.Forms.Padding(0);
            this.item4.Name = "item4";
            this.item4.rightText = "";
            this.item4.Size = new System.Drawing.Size(200, 29);
            this.item4.TabIndex = 3;
            this.item4.Clicked += new System.EventHandler(this.item4_Click);
            // 
            // item3
            // 
            this.item3.AutoSize = true;
            this.item3.iconVisible = false;
            this.item3.Enabled = false;
            this.item3.leftText = "在隐身窗口中打开链接";
            this.item3.Location = new System.Drawing.Point(0, 59);
            this.item3.Margin = new System.Windows.Forms.Padding(0);
            this.item3.Name = "item3";
            this.item3.rightText = "";
            this.item3.Size = new System.Drawing.Size(200, 29);
            this.item3.TabIndex = 2;
            this.item3.Clicked += new System.EventHandler(this.item3_Click);
            // 
            // item2
            // 
            this.item2.AutoSize = true;
            this.item2.iconVisible = false;
            this.item2.leftText = "在新窗口中打开链接";
            this.item2.Location = new System.Drawing.Point(0, 30);
            this.item2.Margin = new System.Windows.Forms.Padding(0);
            this.item2.Name = "item2";
            this.item2.rightText = "";
            this.item2.Size = new System.Drawing.Size(200, 29);
            this.item2.TabIndex = 1;
            this.item2.Clicked += new System.EventHandler(this.item2_Click);
            // 
            // item1
            // 
            this.item1.AutoSize = true;
            this.item1.iconVisible = false;
            this.item1.leftText = "在新标签页中打开链接";
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Margin = new System.Windows.Forms.Padding(0);
            this.item1.Name = "item1";
            this.item1.rightText = "";
            this.item1.Size = new System.Drawing.Size(200, 29);
            this.item1.TabIndex = 0;
            this.item1.Clicked += new System.EventHandler(this.item1_Click);
            // 
            // LinkContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.item6);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(200, 180);
            this.Name = "LinkContextMenu";
            this.Size = new System.Drawing.Size(200, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomContextMenuItem item1;
        private CustomContextMenuItem item2;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel line1;
        private CustomContextMenuItem item3;
        private CustomContextMenuItem item4;
        private CustomContextMenuItem item5;
        private CustomContextMenuItem item6;
    }
}
