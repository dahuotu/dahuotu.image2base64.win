using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;


namespace com.DaHuotu
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.showPath = this.checkBoxShowPath.Checked;
            Properties.Settings.Default.showAlert = this.checkBoxShowAlert.Checked;
            Properties.Settings.Default.addHead = this.checkBoxImgHead.Checked;
            SetRadioButton();
            Properties.Settings.Default.Save();
            MessageBox.Show("设置成功", "提示", MessageBoxButtons.OK);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.checkBoxShowPath.Checked = Properties.Settings.Default.showPath;
            this.checkBoxShowAlert.Checked = Properties.Settings.Default.showAlert;
            this.checkBoxImgHead.Checked = Properties.Settings.Default.addHead;
            string code = Properties.Settings.Default.codeType;
            switch (code)
            {
                case "h5":
                    this.rdb2.Checked = true;
                    break;
                case "css":
                    this.rdb3.Checked = true;
                    break;
                case "mini":
                    this.rdb4.Checked = true;
                    break;
                default:
                    this.rdb1.Checked = true;
                    break;
            }
        }

        #region 常用函数

        private void SetRadioButton()
        {
            if (this.rdb1.Checked == true)
            {
                Properties.Settings.Default.codeType = "";
            }
            if (this.rdb2.Checked == true)
            {
                Properties.Settings.Default.codeType = "h5";
            }
            if (this.rdb3.Checked == true)
            {
                Properties.Settings.Default.codeType = "css";
            }
            if (this.rdb4.Checked == true)
            {
                Properties.Settings.Default.codeType = "mini";
            }

        }
        #endregion
    }
}
