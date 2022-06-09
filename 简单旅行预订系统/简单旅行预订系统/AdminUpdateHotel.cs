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
    public partial class AdminUpdateHotel : Form
    {
        public AdminUpdateHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    Dao dao = new Dao();
                    string sql = $"UPDATE HOTELS SET location = '{textBox2.Text}', price = '{textBox3.Text}', numRooms = '{textBox4.Text}', numAvail = '{textBox5.Text}' WHERE hotelName LIKE '{textBox1.Text}'";
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
    }
}
