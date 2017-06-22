using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 定时器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //启动定时器
            
        }
        int i = 0;//定义全局变量
        private void tmrshow_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imgpic.Images[i];
            i++;
            //如果图片超过图片的总数,则循环从第0张开始显示
            if (i == imgpic.Images.Count)
            {
                i = 0;
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.tmrshow.Start();
        }
    }
}
