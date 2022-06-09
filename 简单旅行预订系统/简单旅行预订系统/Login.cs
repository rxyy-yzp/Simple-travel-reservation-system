using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单旅行预订系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)//登录按钮
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("账号姓名或密码输入为空!","消息提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)//退出按钮
        {
            Environment.Exit(0);
        }

        public void login()//登陆验证方法
        {
            if (radioButtonUser.Checked == true)//用户选项
            {
                Dao dao = new Dao();
                string sql = $"select * from CUSTOMERS where custID='{textBox1.Text}' and custName='{textBox2.Text}' and custPSW='{textBox3.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    CustData.CustID = dc["custID"].ToString();
                    CustData.CustName = dc["custName"].ToString();
                    MessageBox.Show("用户登录成功!", "用户登录提示");
                    Customer1 costomer1 = new Customer1();
                    this.Hide();
                    costomer1.ShowDialog();
                    this.Show();

                    dao.Daoclose();
                    return;
                }
                else
                {
                    MessageBox.Show("密码或用户名错误!");
                    dao.Daoclose();
                    return;
                }

            }
            if (radioButtonAdmin.Checked == true)//管理员选项
            {
                Dao dao = new Dao();
                string sql = $"select * from ADMINS where adminID='{textBox1.Text}' and adminName='{textBox2.Text}' and adminPSW='{textBox3.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("管理员登录成功!","管理员登录提示");
                    Admin1 admin1 = new Admin1();
                    this.Hide();
                    admin1.ShowDialog();
                    this.Show();

                    dao.Daoclose();
                    return;
                }
                else
                {
                    MessageBox.Show("密码或用户名错误!","消息提示");
                    dao.Daoclose();
                    return;
                }
            }
            MessageBox.Show("未选择用户或管理员登陆!", "消息提示");
            return;
        }
    }
}
