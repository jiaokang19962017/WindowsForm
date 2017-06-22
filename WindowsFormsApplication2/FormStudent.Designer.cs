namespace WindowsFormsApplication2
{
    partial class FormStudent
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lba2 = new System.Windows.Forms.Label();
            this.lstone = new System.Windows.Forms.ListBox();
            this.lsttwo = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnesc = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "优秀学员候选人";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lba2
            // 
            this.lba2.AutoSize = true;
            this.lba2.Location = new System.Drawing.Point(326, 20);
            this.lba2.Name = "lba2";
            this.lba2.Size = new System.Drawing.Size(53, 12);
            this.lba2.TabIndex = 1;
            this.lba2.Text = "优秀学员";
            // 
            // lstone
            // 
            this.lstone.FormattingEnabled = true;
            this.lstone.ItemHeight = 12;
            this.lstone.Location = new System.Drawing.Point(21, 54);
            this.lstone.Name = "lstone";
            this.lstone.Size = new System.Drawing.Size(120, 160);
            this.lstone.TabIndex = 2;
            this.lstone.SelectedIndexChanged += new System.EventHandler(this.lstone_SelectedIndexChanged);
            // 
            // lsttwo
            // 
            this.lsttwo.FormattingEnabled = true;
            this.lsttwo.ItemHeight = 12;
            this.lsttwo.Location = new System.Drawing.Point(296, 54);
            this.lsttwo.Name = "lsttwo";
            this.lsttwo.Size = new System.Drawing.Size(120, 160);
            this.lsttwo.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(181, 94);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = ">>";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnesc
            // 
            this.btnesc.Location = new System.Drawing.Point(181, 144);
            this.btnesc.Name = "btnesc";
            this.btnesc.Size = new System.Drawing.Size(75, 23);
            this.btnesc.TabIndex = 5;
            this.btnesc.Text = "<<";
            this.btnesc.UseVisualStyleBackColor = true;
            this.btnesc.Click += new System.EventHandler(this.btnesc_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(181, 227);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "显示信息";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 262);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnesc);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lsttwo);
            this.Controls.Add(this.lstone);
            this.Controls.Add(this.lba2);
            this.Controls.Add(this.lbl1);
            this.Name = "FormStudent";
            this.Text = "优秀学院选择";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lba2;
        private System.Windows.Forms.ListBox lstone;
        private System.Windows.Forms.ListBox lsttwo;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnesc;
        private System.Windows.Forms.Button btnshow;
    }
}

