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
    public partial class CustomerResvHotel : Form
    {
        public CustomerResvHotel()
        {
            InitializeComponent();
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
            string sql = "select * from HOTELS";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void CustomerResvHotel_Load(object sender, EventArgs e)
        {
            Table();
        }

        //酒店名称查询
        public void TableHotelName()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            string sql;
            Dao dao = new Dao();
            if (checkBox1.Checked == true)
                sql = $"select * from HOTELS where hotelName LIKE '%{textBox1.Text}%' and numAvail>0";
            else
                sql = $"select * from HOTELS where hotelName LIKE '%{textBox1.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        //酒店地址查询
        public void TableHotelLoc()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            string sql;
            Dao dao = new Dao();
            if (checkBox1.Checked == true)
                sql = $"select * from HOTELS where location LIKE '%{textBox2.Text}%' and numAvail>0";
            else
                sql = $"select * from HOTELS where location LIKE '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableHotelName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableHotelLoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hotelname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取酒店名
            
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());//获取可预订座位数
            if (number < 1)
            {
                MessageBox.Show("可预订房间不足或不可预订!请选择其他酒店", "消息提示");
            }
            else
            {
                DateTime dt = DateTime.Now;
                string nowt = string.Format("{0:yyyyMMddHHmmssf}", dt);
                string sql = $"insert into RESV_HOTELS(resvNum,custID,resvType,resvHotelName) values('{nowt}','{CustData.CustID}','HTL','{hotelname}');update HOTELS set numAvail = numAvail - 1 where hotelName = '{hotelname}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show($"用户{CustData.CustName}预定了{hotelname}", "消息提示");
                    Table();
                }
            }
        }
    }
}
