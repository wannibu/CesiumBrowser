using System.Drawing;
using System.Windows.Forms;

namespace Cesium.CustomForms
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer CustomControls = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (CustomControls != null))
            {
                CustomControls.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.MainBody = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Title = new Cesium.CustomControls.FormTitle();
            this.MainBody.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBody
            // 
            this.MainBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainBody.BackColor = System.Drawing.Color.White;
            this.MainBody.Controls.Add(this.TitlePanel);
            this.MainBody.Location = new System.Drawing.Point(2, 2);
            this.MainBody.Margin = new System.Windows.Forms.Padding(0);
            this.MainBody.Name = "MainBody";
            this.MainBody.Size = new System.Drawing.Size(796, 596);
            this.MainBody.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(796, 40);
            this.TitlePanel.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(796, 40);
            this.Title.TabIndex = 0;
            this.Title.MyMouseDown += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.Title_MyMouseDown);
            this.Title.MyMouseDoubleClick += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.Title_MyMouseDoubleClick);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MainBody);
            this.MinimumSize = new System.Drawing.Size(500, 115);
            this.Name = "MyForm";
            this.MainBody.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Panel MainBody;
        public Panel TitlePanel;
        public FormTitle Title;
    }
}