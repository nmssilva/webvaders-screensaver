using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deployment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            webBrowser1.AllowWebBrowserDrop = false;

            string curDir = Directory.GetCurrentDirectory();

            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/../../index.html", curDir));
        }

    }
}
