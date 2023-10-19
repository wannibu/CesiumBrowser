using CefNew.Model;
using CefOld.Model;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OldChromiumWebBrowser chrome1 = new OldChromiumWebBrowser("https://www.baidu.com/");
            chrome1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(chrome1);

            NewChromiumWebBrowser chrome2 = new NewChromiumWebBrowser("https://www.4399.com/");
            chrome2.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(chrome2);


        }
    }
}
