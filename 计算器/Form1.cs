using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sum;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtnum1.Text.Equals(string.Empty)&& txtnum2.Text.Equals(string.Empty)&&comboBox1.Text.Equals(string.Empty))
            {
                MessageBox.Show("为空");
            }
            else
            {
                if (comboBox1.Text == "+")
                {
                    sum = Convert.ToInt32(txtnum1.Text) + Convert.ToInt32(txtnum2.Text);
                    txtsum.Text = Convert.ToString(sum);
                }
                else if (comboBox1.Text == "-")
                {

                    sum = Convert.ToInt32(txtnum1.Text) - Convert.ToInt32(txtnum2.Text);
                    txtsum.Text = Convert.ToString(sum);
                }
                else if (comboBox1.Text == "*")
                {

                    sum = Convert.ToInt32(txtnum1.Text) * Convert.ToInt32(txtnum2.Text);
                    txtsum.Text = Convert.ToString(sum);
                }
                else if (comboBox1.Text == "/")
                {

                    sum = Convert.ToInt32(txtnum1.Text) / Convert.ToInt32(txtnum2.Text);
                    txtsum.Text = Convert.ToString(sum);
                }
            }

            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
