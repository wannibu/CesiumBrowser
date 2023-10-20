using System.Windows.Forms;

namespace Cesium.App.CefBrowser
{
    partial class Browser
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.Body = new System.Windows.Forms.Panel();
            this.MainBody.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBody
            // 
            this.MainBody.Controls.Add(this.Body);
            this.MainBody.Size = new System.Drawing.Size(1296, 796);
            this.MainBody.Controls.SetChildIndex(this.TitlePanel, 0);
            this.MainBody.Controls.SetChildIndex(this.Body, 0);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Size = new System.Drawing.Size(1296, 40);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(1296, 40);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 40);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(1296, 756);
            this.Body.TabIndex = 2;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Activated += new System.EventHandler(this.Browser_Activated);
            this.Deactivate += new System.EventHandler(this.Browser_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Browser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Browser_FormClosed);
            this.Load += new System.EventHandler(this.Browser_Load);
            this.MainBody.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        public Panel Body;
    }
}
