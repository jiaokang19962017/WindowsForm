namespace 定时器
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrshow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnok = new System.Windows.Forms.Button();
            this.imgpic = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrshow
            // 
            this.tmrshow.Interval = 300;
            this.tmrshow.Tick += new System.EventHandler(this.tmrshow_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::定时器.Properties.Resources._55a11652b87b51f8e63677b578b045ba;
            this.pictureBox1.Location = new System.Drawing.Point(41, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(100, 213);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // imgpic
            // 
            this.imgpic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgpic.ImageStream")));
            this.imgpic.TransparentColor = System.Drawing.Color.Transparent;
            this.imgpic.Images.SetKeyName(0, "55a11652b87b51f8e63677b578b045ba.jpg");
            this.imgpic.Images.SetKeyName(1, "design_and_hand_made_drawing_pack_128px_1199818_easyicon.net.ico");
            this.imgpic.Images.SetKeyName(2, "school_material_128px_1206224_easyicon.net.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrshow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.ImageList imgpic;
    }
}

