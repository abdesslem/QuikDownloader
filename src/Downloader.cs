using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleDownload
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
        }

        public  void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Download dn=new Download();
            dn.DownloadFile(url.Text, @"c:\NewImages\");
        }
    }
}
