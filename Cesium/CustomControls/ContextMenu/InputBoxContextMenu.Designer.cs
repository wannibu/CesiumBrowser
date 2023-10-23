namespace Cesium.CustomControls
{
    partial class InputBoxContextMenu
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
            this.line1 = new System.Windows.Forms.Panel();
            this.item3 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item4 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item5 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item6 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item7 = new Cesium.CustomControls.CustomContextMenuItem();
            this.line2 = new System.Windows.Forms.Panel();
            this.item8 = new Cesium.CustomControls.CustomContextMenuItem();
            this.line3 = new System.Windows.Forms.Panel();
            this.item9 = new Cesium.CustomControls.CustomContextMenuItem();
            this.item10 = new Cesium.CustomControls.CustomContextMenuItem();
            this.SuspendLayout();
            // 
            // item2
            // 
            this.item2.AutoSize = true;
            this.item2.iconVisible = false;
            this.item2.leftText = "撤消";
            this.item2.Location = new System.Drawing.Point(0, 31);
            this.item2.Margin = new System.Windows.Forms.Padding(0);
            this.item2.MinimumSize = new System.Drawing.Size(300, 29);
            this.item2.Name = "item2";
            this.item2.rightText = "Ctrl+Z";
            this.item2.Size = new System.Drawing.Size(300, 29);
            this.item2.TabIndex = 1;
            this.item2.Clicked += new System.EventHandler(this.item2_Click);
            // 
            // item1
            // 
            this.item1.AutoSize = true;
            this.item1.Enabled = false;
            this.item1.iconVisible = false;
            this.item1.leftText = "表情符号";
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Margin = new System.Windows.Forms.Padding(0);
            this.item1.MinimumSize = new System.Drawing.Size(300, 29);
            this.item1.Name = "item1";
            this.item1.rightText = "Win键+句号";
            this.item1.Size = new System.Drawing.Size(300, 29);
            this.item1.TabIndex = 0;
            this.item1.Clicked += new System.EventHandler(this.item1_Click);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line.Location = new System.Drawing.Point(0, 30);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(300, 1);
            this.line.TabIndex = 2;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line1.Location = new System.Drawing.Point(0, 60);
            this.line1.Margin = new System.Windows.Forms.Padding(0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(300, 1);
            this.line1.TabIndex = 2;
            // 
            // item3
            // 
            this.item3.AutoSize = true;
            this.item3.iconVisible = false;
            this.item3.leftText = "剪切";
            this.item3.Location = new System.Drawing.Point(0, 59);
            this.item3.Margin = new System.Windows.Forms.Padding(0);
            this.item3.MinimumSize = new System.Drawing.Size(300, 29);
            this.item3.Name = "item3";
            this.item3.rightText = "Ctrl+X";
            this.item3.Size = new System.Drawing.Size(300, 29);
            this.item3.TabIndex = 2;
            this.item3.Clicked += new System.EventHandler(this.item3_Click);
            // 
            // item4
            // 
            this.item4.AutoSize = true;
            this.item4.iconVisible = false;
            this.item4.leftText = "复制";
            this.item4.Location = new System.Drawing.Point(0, 88);
            this.item4.Margin = new System.Windows.Forms.Padding(0);
            this.item4.MinimumSize = new System.Drawing.Size(300, 29);
            this.item4.Name = "item4";
            this.item4.rightText = "Ctrl+C";
            this.item4.Size = new System.Drawing.Size(300, 29);
            this.item4.TabIndex = 3;
            this.item4.Clicked += new System.EventHandler(this.item4_Click);
            // 
            // item5
            // 
            this.item5.AutoSize = true;
            this.item5.iconVisible = false;
            this.item5.leftText = "粘贴";
            this.item5.Location = new System.Drawing.Point(0, 117);
            this.item5.Margin = new System.Windows.Forms.Padding(0);
            this.item5.MinimumSize = new System.Drawing.Size(300, 29);
            this.item5.Name = "item5";
            this.item5.rightText = "Ctrl+V";
            this.item5.Size = new System.Drawing.Size(300, 29);
            this.item5.TabIndex = 4;
            this.item5.Clicked += new System.EventHandler(this.item5_Click);
            // 
            // item6
            // 
            this.item6.AutoSize = true;
            this.item6.iconVisible = false;
            this.item6.leftText = "粘贴并";
            this.item6.Location = new System.Drawing.Point(0, 146);
            this.item6.Margin = new System.Windows.Forms.Padding(0);
            this.item6.MinimumSize = new System.Drawing.Size(300, 29);
            this.item6.Name = "item6";
            this.item6.rightText = "";
            this.item6.Size = new System.Drawing.Size(300, 29);
            this.item6.TabIndex = 5;
            this.item6.Clicked += new System.EventHandler(this.item6_Click);
            // 
            // item7
            // 
            this.item7.AutoSize = true;
            this.item7.iconVisible = false;
            this.item7.leftText = "删除";
            this.item7.Location = new System.Drawing.Point(0, 175);
            this.item7.Margin = new System.Windows.Forms.Padding(0);
            this.item7.MinimumSize = new System.Drawing.Size(300, 29);
            this.item7.Name = "item7";
            this.item7.rightText = "";
            this.item7.Size = new System.Drawing.Size(300, 29);
            this.item7.TabIndex = 6;
            this.item7.Clicked += new System.EventHandler(this.item7_Click);
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line2.Location = new System.Drawing.Point(0, 208);
            this.line2.Margin = new System.Windows.Forms.Padding(0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(300, 1);
            this.line2.TabIndex = 2;
            // 
            // item8
            // 
            this.item8.AutoSize = true;
            this.item8.iconVisible = false;
            this.item8.leftText = "全选";
            this.item8.Location = new System.Drawing.Point(0, 209);
            this.item8.Margin = new System.Windows.Forms.Padding(0);
            this.item8.MinimumSize = new System.Drawing.Size(300, 29);
            this.item8.Name = "item8";
            this.item8.rightText = "Ctrl+A";
            this.item8.Size = new System.Drawing.Size(300, 29);
            this.item8.TabIndex = 7;
            this.item8.Clicked += new System.EventHandler(this.item8_Click);
            // 
            // line3
            // 
            this.line3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.line3.Location = new System.Drawing.Point(0, 240);
            this.line3.Margin = new System.Windows.Forms.Padding(0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(300, 1);
            this.line3.TabIndex = 2;
            // 
            // item9
            // 
            this.item9.AutoSize = true;
            this.item9.Enabled = false;
            this.item9.iconVisible = false;
            this.item9.leftText = "管理搜索引擎和网站搜索";
            this.item9.Location = new System.Drawing.Point(0, 240);
            this.item9.Margin = new System.Windows.Forms.Padding(0);
            this.item9.MinimumSize = new System.Drawing.Size(300, 29);
            this.item9.Name = "item9";
            this.item9.rightText = "";
            this.item9.Size = new System.Drawing.Size(300, 29);
            this.item9.TabIndex = 8;
            this.item9.Clicked += new System.EventHandler(this.item9_Click);
            // 
            // item10
            // 
            this.item10.AutoSize = true;
            this.item10.iconVisible = true;
            this.item10.leftText = "总是显示完整网址";
            this.item10.Location = new System.Drawing.Point(0, 269);
            this.item10.Margin = new System.Windows.Forms.Padding(0);
            this.item10.MinimumSize = new System.Drawing.Size(300, 29);
            this.item10.Name = "item10";
            this.item10.rightText = "";
            this.item10.Size = new System.Drawing.Size(300, 29);
            this.item10.TabIndex = 9;
            this.item10.Clicked += new System.EventHandler(this.item10_Click);
            // 
            // InputBoxContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.item10);
            this.Controls.Add(this.item9);
            this.Controls.Add(this.item8);
            this.Controls.Add(this.item7);
            this.Controls.Add(this.item6);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "InputBoxContextMenu";
            this.Size = new System.Drawing.Size(300, 300);
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
        private CustomContextMenuItem item7;
        private System.Windows.Forms.Panel line2;
        private CustomContextMenuItem item8;
        private System.Windows.Forms.Panel line3;
        private CustomContextMenuItem item9;
        private CustomContextMenuItem item10;
    }
}
