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
    public partial class AdminFlight : Form
    {
        public AdminFlight()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminFlight_Load(object sender, EventArgs e)
        {
            Table();//显示所有数据
        }

        //从数据库读取数据显示在表格中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = "select * from FLIGHTS";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //航班号查询
        public void TableID()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from FLIGHTS where flightNum LIKE '%{textBox1.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //始发地查询
        public void TableFromCity()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from FLIGHTS where FromCity LIKE '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //目的地查询
        public void TableArivCity()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from FLIGHTS where ArivCity LIKE '%{textBox3.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button1_Click(object sender, EventArgs e)//新增数据按钮
        {
            AdminInsertFlight admininsertflight = new AdminInsertFlight();
            admininsertflight.ShowDialog();
            Table();
        }

        private void button4_Click(object sender, EventArgs e)//刷新按钮
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)//删除数据按钮
        {
            try
            {
                string flightnum = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取航班号
                DialogResult dr = MessageBox.Show("确认删除吗?", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from FLIGHTS where flightNum ='{flightnum}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功!", "消息提示");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败!", "消息提示");
                    }
                    dao.Daoclose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的航班信息!", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)//航班号查询
        {
            TableID();
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)//始发地查询
        {
            TableFromCity();
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)//目的地查询
        {
            TableArivCity();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//修改航班数据
        {
            AdminUpdateFlight adminupdateflight = new AdminUpdateFlight();
            adminupdateflight.ShowDialog();
            Table();
        }
    }
}
