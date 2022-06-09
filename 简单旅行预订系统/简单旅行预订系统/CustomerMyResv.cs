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
    public partial class CustomerMyResv : Form
    {
        public CustomerMyResv()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //从数据库读取数据显示在表格中
        public void Table1()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select RESV_FLIGHTS.resvNum,RESV_FLIGHTS.resvType,RESV_FLIGHTS.resvFlightNum,FLIGHTS.FromCity,FLIGHTS.ArivCity from RESV_FLIGHTS,FLIGHTS where custID='{CustData.CustID}' and FLIGHTS.flightNum=RESV_FLIGHTS.resvFlightNum";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        public void Table2()
        {
            dataGridView2.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select RESV_BUS.resvNum,RESV_BUS.resvType,RESV_BUS.resvBusNum,BUS.FromCity,BUS.ArivCity from RESV_BUS,BUS where custID='{CustData.CustID}' and BUS.BusNum=RESV_BUS.resvBusNum";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView2.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        public void Table3()
        {
            dataGridView3.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select RESV_HOTELS.resvNum,RESV_HOTELS.resvType,RESV_HOTELS.resvHotelName,HOTELS.location from RESV_HOTELS,HOTELS where custID='{CustData.CustID}' and HOTELS.hotelName=RESV_HOTELS.resvHotelName";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView3.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void CustomerMyResv_Load(object sender, EventArgs e)
        {
            Table1();
            Table2();
            Table3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认取消吗?", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string flightnum = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string sql = $"delete from RESV_FLIGHTS where resvNum='{no}';update FLIGHTS set numAvail=numAvail+1 where flightNum='{flightnum}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show("取消成功!", "消息提示");
                    Table1();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认取消吗?", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string no = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string busnum = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                string sql = $"delete from RESV_BUS where resvNum='{no}';update BUS set numAvail=numAvail+1 where BusNum='{busnum}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show("取消成功!", "消息提示");
                    Table2();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认取消吗?", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string no = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                string sql = $"delete from RESV_HOTELS where resvNum='{no}';update HOTELS set numAvail=numAvail+1 where hotelName='{name}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show("取消成功!", "消息提示");
                    Table3();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table1();
            Table2();
            Table3();
        }
    }
}
