namespace WindowsFormsApplication4
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
            this.labname = new System.Windows.Forms.Label();
            this.labtext = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.texttext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(38, 31);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(29, 12);
            this.labname.TabIndex = 0;
            this.labname.Text = "姓名";
            // 
            // labtext
            // 
            this.labtext.AutoSize = true;
            this.labtext.Location = new System.Drawing.Point(38, 114);
            this.labtext.Name = "labtext";
            this.labtext.Size = new System.Drawing.Size(29, 12);
            this.labtext.TabIndex = 1;
            this.labtext.Text = "内容";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(95, 28);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 21);
            this.textname.TabIndex = 2;
            // 
            // texttext
            // 
            this.texttext.Location = new System.Drawing.Point(95, 111);
            this.texttext.Name = "texttext";
            this.texttext.Size = new System.Drawing.Size(100, 21);
            this.texttext.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "传送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texttext);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.labtext);
            this.Controls.Add(this.labname);
            this.Name = "FormMain";
            this.Text = "窗口之间的跳转";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labtext;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox texttext;
        private System.Windows.Forms.Button button1;
    }
}

