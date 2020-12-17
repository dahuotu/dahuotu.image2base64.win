using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace com.DaHuotu
{
    public partial class frmAbout : Form
    {
        string appName = Properties.Settings.Default.appName;
        string appVersion = Properties.Settings.Default.appVersion;

        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.dahuotu.com/");
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:1979788761@qq.com?subject=标准工具&bc=1979788761@qq.com&bcc=qqblackboy@126.com");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.labSoftName.Text = appName;
            this.labVsion.Text = "Version " + appVersion;
        }
    }
}
