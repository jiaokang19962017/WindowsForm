using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片框
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            //定义一个变量,先是个人信息
            string info = "";
            info += "个人信息: \r\n";
            info += "姓名为:" + txtname.Text.Trim() + "\r\n";
            if (radioButtonnan.Checked == true)
            {
                info += "性别为:男" + "\r\n";
            }
            else
            {
                info += "性别为:女" + "\r\n";
            }
            info += "爱好: ";
            //在复选框容器中遍历显示爱好
            foreach (CheckBox cb in groupBox1.Controls)
            {
                if (cb.Checked == true)
                {
                    info += cb.Text+" ";
                }
            }
            txtshow.Text = info;


        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
