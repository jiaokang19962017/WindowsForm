namespace WindowsFormsApplication1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblShow = new System.Windows.Forms.Label();
            this.lalUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblShow.Location = new System.Drawing.Point(23, 32);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(249, 38);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "学生信息管理系统";
            // 
            // lalUser
            // 
            this.lalUser.AutoSize = true;
            this.lalUser.BackColor = System.Drawing.Color.Transparent;
            this.lalUser.Location = new System.Drawing.Point(60, 96);
            this.lalUser.Name = "lalUser";
            this.lalUser.Size = new System.Drawing.Size(47, 12);
            this.lalUser.TabIndex = 1;
            this.lalUser.Text = "用户名:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(113, 93);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 3;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Location = new System.Drawing.Point(66, 126);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(35, 12);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密码:";
            this.lblPwd.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(113, 123);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Transparent;
            this.btnPost.Location = new System.Drawing.Point(26, 192);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "登录";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(197, 192);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "取消";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect.Location = new System.Drawing.Point(48, 158);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(59, 12);
            this.lblSelect.TabIndex = 9;
            this.lblSelect.Text = "登录类型:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "换色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lalUser);
            this.Controls.Add(this.lblShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lalUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button button1;
    }
}

