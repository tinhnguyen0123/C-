using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tracnghiem_Application
{
    public partial class Form_LienHe : Office2007Form
    {
        public Form_LienHe()
        {
            InitializeComponent();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/doanluanvan.com.vn/");
        }
    }
}