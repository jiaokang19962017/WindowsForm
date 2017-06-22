using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("瞎点什么");
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            //如果密码为空
            if (txtPwd.Text.Trim().Equals(string.Empty)&&txtUser.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("帐号或者密码为空");
            }
            //如果帐号是admin,密码是526611
            else if (txtUser.Text.Equals("admin") && txtPwd.Text.Equals("526611"))
            {
                MessageBox.Show("登录成功!账号是:"+txtUser.Text+"密码是:"+txtPwd.Text);//显式密码框内容
            }
            else
            {
                MessageBox.Show("密码或者帐号错误");
            }
        }

   

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FormMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

    }
}
