using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManager
{
    public partial class FrmMain : Form
    {
        SqlConnection sqlcon = null;
        string strcon = "Data Source=HP201-1;Initial Catalog=Student;Integrated Security=True";
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobsex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加事件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //定义联连接字符串
                string strsql = string.Format("insert into tb_stuinfo(s_name,s_gender,s_age,s_romark) values('{0}','{1}','{2}','{3}')", txtname.Text.Trim(), cobsex.Text.Trim(), txtage.Text.Trim(), txttip.Text.Trim());
                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("添加成功");
                    StudentShow();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //加载查询信息方法
            StudentShow();
        }
        /// <summary>
        /// 查询信息方法
        /// </summary>
        private void StudentShow()
        {
            //实例化连接对象
            sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //定义查询字符串
                string sql = "select * from tb_stuInfo";
                //定义命令对象
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                //定义一个只读只进的记录器对象
                SqlDataReader dr = cmd.ExecuteReader();
                //先清除列表中的内容
                lstshow.Items.Clear();
                //通过遍历查询显式在列表框中
                while (dr.Read()) {
                    string id = dr[0].ToString();
                    string name = dr[1].ToString();
                    string sex = dr[2].ToString();
                    string age = dr[3].ToString();
                    string tip = dr[4].ToString();
                    //显式在列表中
                    lstshow.Items.Add(id + "\t" + name + "\t" + sex + "\t" + age + "\t" + tip + "\t");
                }
                //关闭记录集
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误"+ex.Message);
            }
            finally
            {
                //关闭连接
                sqlcon.Close();
            }



        }
        /// <summary>
        /// 退出按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsel_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           

        }

        /// <summary>
        /// 删除事件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtnum.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择学生信息再删除");
            }
            sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //定义联连接字符串
                string strsql = string.Format("delete  from tb_stuinfo where s_id='{0}'" ,  txtnum.Text.Trim());
                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    StudentShow();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }





        }

        /// <summary>
        /// 更新事件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnupd_Click(object sender, EventArgs e)
        {
            if (txtnum.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择学生信息再修改");
            }
            sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //定义联连接字符串
                string strsql = string.Format("update tb_stuinfo set s_name='{0}',s_gender='{1}',s_age='{2}',s_romark='{3}' where s_id='{4}'", txtname.Text.Trim(), cobsex.Text.Trim(), txtage.Text.Trim(), txttip.Text.Trim(),txtnum.Text.Trim());
                SqlCommand cmd = new SqlCommand(strsql, sqlcon);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("修改成功");
                    StudentShow();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }



        }

        private void lstshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstshow.SelectedIndex >= 0)
            {
                //获取每一项的值
                string str = lstshow.SelectedItem.ToString();
                string[] stu = str.Split('\t');
                //显式当前记录
                txtnum.Text = stu[0];
                txtname.Text = stu[1];
                if (stu[2] == "男")
                {
                    cobsex.SelectedIndex = 0;
                }
                else
                {
                    cobsex.SelectedIndex = 1;
                }
                txtage.Text = stu[3];
                txttip.Text = stu[4];
            }
        }
    }
}
