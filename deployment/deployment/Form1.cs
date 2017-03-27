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
        Keys[] key = new Keys[2];
        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            ShowInTaskbar = false;

            webBrowser1.AllowWebBrowserDrop = false;

            string curDir = Directory.GetCurrentDirectory();

            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/../../index.html", curDir));


        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            key[0] = key[1];
            key[1] = e.KeyCode;
            if (key[0] == Keys.N && key[1] == Keys.Down)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!(key[0] == Keys.N && key[1] == Keys.Down))
            {
                e.Cancel = true;
            }
        }
    }
}
