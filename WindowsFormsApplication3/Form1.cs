using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cob.Items.Add("一年级");
            cob.Items.Add("二年级");
        }

        private void cob_SelectedIndexChanged(object sender, EventArgs e)
        {

                //先清除原来显式的
            lstShow.Items.Clear();
            switch (cob.Text)
            {
                case "一年级":
                    lstShow.Items.Add("小红");
                    lstShow.Items.Add("小绿");
                    lstShow.Items.Add("小黄");
                    break;
                case "二年级":
                   
                    lstShow.Items.Add("小青");
                    lstShow.Items.Add("小蓝");
                    lstShow.Items.Add("小紫");

                    break;
            }
        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定?","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }
    }
}
