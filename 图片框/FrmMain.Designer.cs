namespace 图片框
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.radioButtonnan = new System.Windows.Forms.RadioButton();
            this.radioButtonnv = new System.Windows.Forms.RadioButton();
            this.lbllove = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxlanqiu = new System.Windows.Forms.CheckBox();
            this.checkBoxgame = new System.Windows.Forms.CheckBox();
            this.checkBoxzhuqiu = new System.Windows.Forms.CheckBox();
            this.checkBoxbook = new System.Windows.Forms.CheckBox();
            this.lblhead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.btnpost = new System.Windows.Forms.Button();
            this.btnesc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(51, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 12);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "姓名:";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(106, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(51, 84);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(35, 12);
            this.lblsex.TabIndex = 2;
            this.lblsex.Text = "性别:";
            // 
            // radioButtonnan
            // 
            this.radioButtonnan.AutoSize = true;
            this.radioButtonnan.Checked = true;
            this.radioButtonnan.Location = new System.Drawing.Point(106, 84);
            this.radioButtonnan.Name = "radioButtonnan";
            this.radioButtonnan.Size = new System.Drawing.Size(35, 16);
            this.radioButtonnan.TabIndex = 3;
            this.radioButtonnan.TabStop = true;
            this.radioButtonnan.Text = "男";
            this.radioButtonnan.UseVisualStyleBackColor = true;
            // 
            // radioButtonnv
            // 
            this.radioButtonnv.AutoSize = true;
            this.radioButtonnv.Location = new System.Drawing.Point(171, 84);
            this.radioButtonnv.Name = "radioButtonnv";
            this.radioButtonnv.Size = new System.Drawing.Size(35, 16);
            this.radioButtonnv.TabIndex = 4;
            this.radioButtonnv.Text = "女";
            this.radioButtonnv.UseVisualStyleBackColor = true;
            // 
            // lbllove
            // 
            this.lbllove.AutoSize = true;
            this.lbllove.Location = new System.Drawing.Point(53, 127);
            this.lbllove.Name = "lbllove";
            this.lbllove.Size = new System.Drawing.Size(35, 12);
            this.lbllove.TabIndex = 5;
            this.lbllove.Text = "爱好:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxbook);
            this.groupBox1.Controls.Add(this.checkBoxzhuqiu);
            this.groupBox1.Controls.Add(this.checkBoxgame);
            this.groupBox1.Controls.Add(this.checkBoxlanqiu);
            this.groupBox1.Location = new System.Drawing.Point(53, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxlanqiu
            // 
            this.checkBoxlanqiu.AutoSize = true;
            this.checkBoxlanqiu.Location = new System.Drawing.Point(10, 20);
            this.checkBoxlanqiu.Name = "checkBoxlanqiu";
            this.checkBoxlanqiu.Size = new System.Drawing.Size(48, 16);
            this.checkBoxlanqiu.TabIndex = 0;
            this.checkBoxlanqiu.Text = "篮球";
            this.checkBoxlanqiu.UseVisualStyleBackColor = true;
            // 
            // checkBoxgame
            // 
            this.checkBoxgame.AutoSize = true;
            this.checkBoxgame.Location = new System.Drawing.Point(146, 50);
            this.checkBoxgame.Name = "checkBoxgame";
            this.checkBoxgame.Size = new System.Drawing.Size(48, 16);
            this.checkBoxgame.TabIndex = 1;
            this.checkBoxgame.Text = "游戏";
            this.checkBoxgame.UseVisualStyleBackColor = true;
            // 
            // checkBoxzhuqiu
            // 
            this.checkBoxzhuqiu.AutoSize = true;
            this.checkBoxzhuqiu.Location = new System.Drawing.Point(146, 20);
            this.checkBoxzhuqiu.Name = "checkBoxzhuqiu";
            this.checkBoxzhuqiu.Size = new System.Drawing.Size(48, 16);
            this.checkBoxzhuqiu.TabIndex = 2;
            this.checkBoxzhuqiu.Text = "足球";
            this.checkBoxzhuqiu.UseVisualStyleBackColor = true;
            // 
            // checkBoxbook
            // 
            this.checkBoxbook.AutoSize = true;
            this.checkBoxbook.Location = new System.Drawing.Point(10, 50);
            this.checkBoxbook.Name = "checkBoxbook";
            this.checkBoxbook.Size = new System.Drawing.Size(48, 16);
            this.checkBoxbook.TabIndex = 3;
            this.checkBoxbook.Text = "看书";
            this.checkBoxbook.UseVisualStyleBackColor = true;
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Location = new System.Drawing.Point(51, 267);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(35, 12);
            this.lblhead.TabIndex = 7;
            this.lblhead.Text = "头像:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图片框.Properties.Resources._55a11652b87b51f8e63677b578b045ba;
            this.pictureBox1.Location = new System.Drawing.Point(55, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 119);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "个人信息展示";
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(55, 444);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(198, 73);
            this.txtshow.TabIndex = 10;
            // 
            // btnpost
            // 
            this.btnpost.Location = new System.Drawing.Point(55, 545);
            this.btnpost.Name = "btnpost";
            this.btnpost.Size = new System.Drawing.Size(75, 23);
            this.btnpost.TabIndex = 11;
            this.btnpost.Text = "提交";
            this.btnpost.UseVisualStyleBackColor = true;
            this.btnpost.Click += new System.EventHandler(this.btnpost_Click);
            // 
            // btnesc
            // 
            this.btnesc.Location = new System.Drawing.Point(178, 545);
            this.btnesc.Name = "btnesc";
            this.btnesc.Size = new System.Drawing.Size(75, 23);
            this.btnesc.TabIndex = 12;
            this.btnesc.Text = "取消";
            this.btnesc.UseVisualStyleBackColor = true;
            this.btnesc.Click += new System.EventHandler(this.btnesc_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 580);
            this.Controls.Add(this.btnesc);
            this.Controls.Add(this.btnpost);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbllove);
            this.Controls.Add(this.radioButtonnv);
            this.Controls.Add(this.radioButtonnan);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "个人信息展示";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.RadioButton radioButtonnan;
        private System.Windows.Forms.RadioButton radioButtonnv;
        private System.Windows.Forms.Label lbllove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxbook;
        private System.Windows.Forms.CheckBox checkBoxzhuqiu;
        private System.Windows.Forms.CheckBox checkBoxgame;
        private System.Windows.Forms.CheckBox checkBoxlanqiu;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.Button btnpost;
        private System.Windows.Forms.Button btnesc;
    }
}

