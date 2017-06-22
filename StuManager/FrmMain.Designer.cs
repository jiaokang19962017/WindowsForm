namespace StuManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lstshow = new System.Windows.Forms.ListBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.cobsex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btnsel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstshow
            // 
            this.lstshow.FormattingEnabled = true;
            this.lstshow.ItemHeight = 12;
            this.lstshow.Location = new System.Drawing.Point(0, 0);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(452, 88);
            this.lstshow.TabIndex = 0;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(13, 112);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(29, 12);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "学号";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(71, 109);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 21);
            this.txtnum.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(322, 112);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(13, 167);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(29, 12);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "年龄";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(71, 164);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 21);
            this.txtage.TabIndex = 6;
            this.txtage.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(252, 173);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(29, 12);
            this.lblsex.TabIndex = 7;
            this.lblsex.Text = "性别";
            // 
            // cobsex
            // 
            this.cobsex.FormattingEnabled = true;
            this.cobsex.Location = new System.Drawing.Point(319, 167);
            this.cobsex.Name = "cobsex";
            this.cobsex.Size = new System.Drawing.Size(103, 20);
            this.cobsex.TabIndex = 8;
            this.cobsex.SelectedIndexChanged += new System.EventHandler(this.cobsex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "备注";
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(71, 220);
            this.txttip.Multiline = true;
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(351, 21);
            this.txttip.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 285);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "增";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(127, 285);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "删";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(235, 285);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(75, 23);
            this.btnupd.TabIndex = 13;
            this.btnupd.Text = "改";
            this.btnupd.UseVisualStyleBackColor = true;
            // 
            // btnsel
            // 
            this.btnsel.Location = new System.Drawing.Point(347, 285);
            this.btnsel.Name = "btnsel";
            this.btnsel.Size = new System.Drawing.Size(75, 23);
            this.btnsel.TabIndex = 14;
            this.btnsel.Text = "查";
            this.btnsel.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 329);
            this.Controls.Add(this.btnsel);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobsex);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lstshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstshow;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.ComboBox cobsex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btnsel;
    }
}

