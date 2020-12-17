namespace com.DaHuotu
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkBoxShowPath = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowAlert = new System.Windows.Forms.CheckBox();
            this.checkBoxImgHead = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(184, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // checkBoxShowPath
            // 
            this.checkBoxShowPath.AutoSize = true;
            this.checkBoxShowPath.Location = new System.Drawing.Point(172, 24);
            this.checkBoxShowPath.Name = "checkBoxShowPath";
            this.checkBoxShowPath.Size = new System.Drawing.Size(96, 16);
            this.checkBoxShowPath.TabIndex = 3;
            this.checkBoxShowPath.Text = "显示图片路径";
            this.checkBoxShowPath.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxImgHead);
            this.groupBox1.Controls.Add(this.checkBoxShowAlert);
            this.groupBox1.Controls.Add(this.checkBoxShowPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "默认设置";
            // 
            // checkBoxShowAlert
            // 
            this.checkBoxShowAlert.AutoSize = true;
            this.checkBoxShowAlert.Location = new System.Drawing.Point(27, 24);
            this.checkBoxShowAlert.Name = "checkBoxShowAlert";
            this.checkBoxShowAlert.Size = new System.Drawing.Size(120, 16);
            this.checkBoxShowAlert.TabIndex = 4;
            this.checkBoxShowAlert.Text = "显示复制成功提示";
            this.checkBoxShowAlert.UseVisualStyleBackColor = true;
            // 
            // checkBoxImgHead
            // 
            this.checkBoxImgHead.AutoSize = true;
            this.checkBoxImgHead.Location = new System.Drawing.Point(27, 53);
            this.checkBoxImgHead.Name = "checkBoxImgHead";
            this.checkBoxImgHead.Size = new System.Drawing.Size(108, 16);
            this.checkBoxImgHead.TabIndex = 5;
            this.checkBoxImgHead.Text = "添加图片头信息";
            this.checkBoxImgHead.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb1);
            this.groupBox2.Controls.Add(this.rdb3);
            this.groupBox2.Controls.Add(this.rdb4);
            this.groupBox2.Controls.Add(this.rdb2);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成设置";
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(172, 24);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(113, 16);
            this.rdb2.TabIndex = 6;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "生成Img标记代码";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(171, 55);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(137, 16);
            this.rdb4.TabIndex = 7;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "生成小程序Image代码";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(27, 55);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(113, 16);
            this.rdb3.TabIndex = 8;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "生成Css样式代码";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(27, 24);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(107, 16);
            this.rdb1.TabIndex = 9;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "生成Base64代码";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 277);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "常规设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBoxShowPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxShowAlert;
        private System.Windows.Forms.CheckBox checkBoxImgHead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb1;
    }
}