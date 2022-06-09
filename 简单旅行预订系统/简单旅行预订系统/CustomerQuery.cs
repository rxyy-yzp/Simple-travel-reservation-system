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
    public partial class CustomerQuery : Form
    {
        public CustomerQuery()
        {
            InitializeComponent();
        }

        private void CustomerQuery_Load(object sender, EventArgs e)
        {
            Table1();
            Table2();
            Table3();
        }

        //从数据库读取数据显示在表格中
        public void Table1()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql1 = "select * from FLIGHTS";
            IDataReader dc = dao.read(sql1);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        public void Table2()
        {
            dataGridView2.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql2 = "select * from BUS";
            IDataReader dc = dao.read(sql2);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        public void Table3()
        {
            dataGridView3.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql3 = "select * from HOTELS";
            IDataReader dc = dao.read(sql3);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView3.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //航班号查询
        public void TableIDflight()
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

        //班号查询
        public void TableIDbus()
        {
            dataGridView2.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from BUS where BusNum LIKE '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //酒店名查询
        public void TableIDhotel()
        {
            dataGridView3.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from HOTELS where hotelName LIKE '%{textBox3.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView3.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        public void TableCity()
        {
            dataGridView3.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from HOTELS where location LIKE '%{textBox4.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView3.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button6_Click(object sender, EventArgs e)//航班号查询
        {
            TableIDflight();
        }

        private void button1_Click(object sender, EventArgs e)//班车号查询
        {
            TableIDbus();
        }

        private void button2_Click(object sender, EventArgs e)//酒店名称查询
        {
            TableIDhotel();
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableCity();
            textBox3.Text = "";
        }

        public void TableFlightWithFA()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql;
            if (checkBox1.Checked==true)
                sql = $"select * from FLIGHTS where FromCity LIKE '%{textBox5.Text}%' and ArivCity LIKE '%{textBox6.Text}%' and numAvail>0";
            else
                sql = $"select * from FLIGHTS where FromCity LIKE '%{textBox5.Text}%' and ArivCity LIKE '%{textBox6.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TableFlightWithFA();
            textBox1.Text = "";
        }

        public void TableBusWithFA()
        {
            dataGridView2.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql;
            if (checkBox2.Checked == true)
                sql = $"select * from BUS where FromCity LIKE '%{textBox8.Text}%' and ArivCity LIKE '%{textBox7.Text}%' and numAvail>0";
            else
                sql = $"select * from BUS where FromCity LIKE '%{textBox8.Text}%' and ArivCity LIKE '%{textBox7.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableBusWithFA();
            textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)//全部刷新
        {
            Table1();
            Table2();
            Table3();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
