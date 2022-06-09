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
    public partial class AdminUpdateFlight : Form
    {
        public AdminUpdateFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    Dao dao = new Dao();
                    string sql = $"UPDATE FLIGHTS SET price = '{textBox2.Text}', numSeats = '{textBox3.Text}', numAvail = '{textBox4.Text}', FromCity = '{textBox5.Text}', ArivCity = '{textBox6.Text}' WHERE flightNum = '{textBox1.Text}'";
                    int n = dao.Execute(sql);
                    if (n > 0)
                    {
                        MessageBox.Show("修改成功!", "消息提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败!", "消息提示");
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
                MessageBox.Show("修改错误", "消息提示");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
