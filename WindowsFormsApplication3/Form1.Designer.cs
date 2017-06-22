namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.cob = new System.Windows.Forms.ComboBox();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.btnesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cob
            // 
            this.cob.FormattingEnabled = true;
            this.cob.Location = new System.Drawing.Point(79, 43);
            this.cob.Name = "cob";
            this.cob.Size = new System.Drawing.Size(121, 20);
            this.cob.TabIndex = 0;
            this.cob.SelectedIndexChanged += new System.EventHandler(this.cob_SelectedIndexChanged);
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.ItemHeight = 12;
            this.lstShow.Location = new System.Drawing.Point(79, 91);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(120, 136);
            this.lstShow.TabIndex = 1;
            // 
            // btnesc
            // 
            this.btnesc.Location = new System.Drawing.Point(105, 284);
            this.btnesc.Name = "btnesc";
            this.btnesc.Size = new System.Drawing.Size(75, 23);
            this.btnesc.TabIndex = 2;
            this.btnesc.Text = "退出";
            this.btnesc.UseVisualStyleBackColor = true;
            this.btnesc.Click += new System.EventHandler(this.btnesc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 402);
            this.Controls.Add(this.btnesc);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.cob);
            this.Name = "Form1";
            this.Text = "combobox下拉框";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cob;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Button btnesc;
    }
}

