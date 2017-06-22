using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //定义一个储存优秀学员名单的字符串
            string stu = "优秀学员:";
            for (int i = 0; i < lsttwo.Items.Count; i++)
            {
                stu += lsttwo.Items[i];
            }
            //显式优秀学员
        
                MessageBox.Show(stu);
            
            
        }

        private void lstone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            //给list添加初始值
            lstone.Items.Add("张三");
            lstone.Items.Add("李四");
            lstone.Items.Add("王五");
            lstone.Items.Add("赵刘");
            lstone.Items.Add("田七");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //所选下标大于或者等于0,表示已选
            if (lstone.SelectedIndex >= 0)
            {
                //把lstone选中的值添加到lsttwo
                lsttwo.Items.Add(lstone.SelectedItem);
                //移除lstone里选中的值
                lstone.Items.RemoveAt(lstone.SelectedIndex);
            }
        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            if (lsttwo.SelectedIndex >= 0)
            {
                lstone.Items.Add(lsttwo.SelectedItem);
                lsttwo.Items.RemoveAt(lsttwo.SelectedIndex);
            }
        }
    }
}
