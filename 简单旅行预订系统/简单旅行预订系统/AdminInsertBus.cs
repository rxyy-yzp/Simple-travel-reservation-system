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
    public partial class AdminInsertBus : Form
    {
        public AdminInsertBus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    Dao dao = new Dao();
                    string sql = $"insert into BUS values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}')";
                    int n = dao.Execute(sql);
                    if (n > 0)
                    {
                        MessageBox.Show("添加成功!", "消息提示");
                    }
                    else
                    {
                        MessageBox.Show("添加失败!", "消息提示");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("输入不允许有空!", "消息提示");
                }
            }
            catch
            {
                MessageBox.Show("巴士班车号已存在或其他错误", "消息提示");
            }
        }
    }
}
