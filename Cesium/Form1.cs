using CefOld.Model;
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

            OldChromiumWebBrowser chrome = new OldChromiumWebBrowser("https://www.baidu.com/s?ie=UTF-8&wd=");
        }
    }
}
