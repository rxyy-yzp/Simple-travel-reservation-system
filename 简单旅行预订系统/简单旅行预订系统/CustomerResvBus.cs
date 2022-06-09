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
    public partial class CustomerResvBus : Form
    {
        public CustomerResvBus()
        {
            InitializeComponent();
        }

        private void CustomerResvBus_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //从数据库读取数据显示在表格中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = "select * from BUS";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //航班号查询
        public void TableIDbus()
        {
            textBox5.Text = "";
            textBox6.Text = "";
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from BUS where BusNum LIKE '%{textBox1.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        public void TableBusWithFA()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql;
            if (checkBox1.Checked == true)
                sql = $"select * from BUS where FromCity LIKE '%{textBox5.Text}%' and ArivCity LIKE '%{textBox6.Text}%' and numAvail>0";
            else
                sql = $"select * from BUS where FromCity LIKE '%{textBox5.Text}%' and ArivCity LIKE '%{textBox6.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableIDbus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TableBusWithFA();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busnum = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取航班号
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());//获取可预订座位数
            if (number < 1)
            {
                MessageBox.Show("余票不足或不可预订!请选择其他班车", "消息提示");
            }
            else
            {
                DateTime dt = DateTime.Now;
                string nowt = string.Format("{0:yyyyMMddHHmmssf}", dt);
                string sql = $"insert into RESV_BUS(resvNum,custID,resvType,resvBusNum) values('{nowt}','{CustData.CustID}','BUS','{busnum}');update BUS set numAvail = numAvail - 1 where BusNum = '{busnum}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show($"用户{CustData.CustName}预定了巴士{busnum}", "消息提示");
                    Table();
                }
            }
        }
    }
}
