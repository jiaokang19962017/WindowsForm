using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化要跳转的窗体
            Form2 f2 = new Form2();
            f2.name = textname.Text;
          //  f2.Show();//打开此窗体
            f2.ShowDialog();//模式化显式窗体,只能在当前窗体操作
        }
    }
}
