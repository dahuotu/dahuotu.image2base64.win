using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace com.DaHuotu
{
    /// <summary>
    /// 标注应用入口
    /// </summary>
    public partial class App : Form
    {
        #region 全局变量
        string appName = Properties.Settings.Default.appName;
        string appVersion = Properties.Settings.Default.appVersion;
        DataTable dtList = new DataTable();
        int indexI = 0;
        #endregion

        #region 界面事件处理

        public App()
        {
            InitializeComponent();
        }

        //界面加载
        private void App_Load(object sender, EventArgs e)
        {
            this.Text = appName + " Version " + appVersion;
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //菜单退出
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        //软件介绍
        private void useHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.dahuotu.com/image2base64.html");
        }

        //菜单联系作者
        private void linkaboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.dahuotu.com/contact.html");
        }

        //菜单关于我们
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.ShowDialog();
        }

        //设置
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting fset = new frmSetting();
            fset.ShowDialog();
        }

        //选择图片
        private void toolStripButtonTP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Multiselect = true;
            dlg.Filter = "图片|*.jpg;*.jpeg;*.gif;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.panel1.Controls.Clear();
                for (int i = 0; i < dlg.FileNames.Length; i++)
                {
                    this.makeForm(i, dlg.FileNames[i]);
                }

            }
        }

        //选择文件夹
        private void toolStripButtonML_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "请选择含有（*.jpg;*.jpeg;*.gif;*.png;*.bmp）格式的文件夹";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.panel1.Controls.Clear();
                indexI = 0;
                string[] imageFile = Directory.GetFiles(dlg.SelectedPath);
                for (int i = 0; i < imageFile.Length; i++)
                {
                    string extension = Path.GetExtension(imageFile[i]);
                    if (extension.Equals(".jpg") || extension.Equals(".jpeg") || extension.Equals(".gif") || extension.Equals(".png") || extension.Equals(".bmp"))
                    {
                        this.makeForm(indexI, imageFile[i]);
                        indexI++;
                    }
                }
                if (indexI == 0)
                {
                    MessageBox.Show("该文件夹下暂无图片", "提示");
                }
            }
        }

        //动态生成界面
        private void makeForm(int index, string groupValue)
        {
            bool isShow = Properties.Settings.Default.showPath;
            //生成pictureBox
            PictureBox picbox = new PictureBox();
            picbox.Location = new System.Drawing.Point(5, 14);
            picbox.Name = "picture" + index.ToString();
            picbox.Size = new System.Drawing.Size(158, 180);
            picbox.TabStop = false;
            picbox.ImageLocation = groupValue;
            picbox.SizeMode = PictureBoxSizeMode.Zoom;
            picbox.BackColor = SystemColors.ButtonHighlight;
            // 生成textBox
            RichTextBox txtbox = new RichTextBox();
            txtbox.Location = new System.Drawing.Point(172, 14);
            txtbox.Multiline = true;
            txtbox.Name = "text" + index.ToString();
            txtbox.Size = new System.Drawing.Size(578, 180);
            txtbox.Text = this.makeCode(groupValue);
            txtbox.Click += new EventHandler(CopyBase64);

            // 生成groupBox
            GroupBox group = new GroupBox();
            group.Location = new System.Drawing.Point(10, (10 + (index * 215)));
            group.Name = "group" + index.ToString();
            group.Size = new System.Drawing.Size(755, 200);
            group.TabStop = false;
            group.Text = isShow == true ? groupValue : (index + 1).ToString();

            group.Controls.Add(picbox);
            group.Controls.Add(txtbox);
            this.panel1.Controls.Add(group);
        }

        #endregion

        #region 常用函数
        //生成代码
        private string makeCode(string filepath)
        {
            string codeStr = "";
            string code = Properties.Settings.Default.codeType;

            if (!string.IsNullOrEmpty(code))
            {
                switch (code)
                {
                    case "h5":
                        codeStr = string.Format("<img src=\"{0}{1}\" />", this.GetImageHead(filepath), this.ConvertImageToBase64(Image.FromFile(filepath)));
                        break;
                    case "css":
                        codeStr = string.Format("background:url('{0}{1}');", this.GetImageHead(filepath), this.ConvertImageToBase64(Image.FromFile(filepath)));
                        break;
                    case "mini":
                        codeStr = string.Format("<image src=\"{0}{1}\"></image>", this.GetImageHead(filepath), this.ConvertImageToBase64(Image.FromFile(filepath)));
                        break;
                }
            }
            else
            {
                if (Properties.Settings.Default.addHead == true)
                {
                    codeStr = string.Format("{0}{1}", this.GetImageHead(filepath), this.ConvertImageToBase64(Image.FromFile(filepath)));
                }
                else
                {
                    codeStr = this.ConvertImageToBase64(Image.FromFile(filepath));
                }
            }
            return codeStr;
        }

        //图片转Base64
        private string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
        //Base64转图片
        private Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
        //复制base64
        private void CopyBase64(object sender, EventArgs e)
        {
            RichTextBox text = (RichTextBox)sender;
            Clipboard.SetDataObject(text.Text);
            if (Properties.Settings.Default.showAlert == true)
            {
                MessageBox.Show("复制成功", "提示");
            }
        }
        //获取图片头字符串
        private string GetImageHead(string imgpath)
        {
            string heads = "";
            string extension = Path.GetExtension(imgpath);
            if (extension.Equals(".jpg") || extension.Equals(".jpeg"))
            {
                heads = "data:image/jpeg;base64,";
            }
            if (extension.Equals(".gif"))
            {
                heads = "data:image/gif;base64,";
            }
            if (extension.Equals(".png"))
            {
                heads = "data:image/png;base64,";
            }
            if (extension.Equals(".bmp"))
            {
                heads = "data:image/bmp;base64,";
            }
            return heads;
        }
        #endregion

    }
}
