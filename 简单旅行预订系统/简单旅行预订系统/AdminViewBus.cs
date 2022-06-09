﻿using System;
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
    public partial class AdminViewBus : Form
    {
        public AdminViewBus()
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
            string sql = "select * from RESV_BUS";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        public void TableBusWithFA()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql = $"select * from RESV_BUS where resvNum LIKE '%{textBox1.Text}%' and custID LIKE '%{textBox2.Text}%' and  resvBusNum LIKE '%{textBox3.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableBusWithFA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认取消吗?", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string busnum = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string sql = $"delete from RESV_BUS where resvNum='{no}';update BUS set numAvail=numAvail+1 where BusNum='{busnum}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show("取消成功!", "消息提示");
                    Table();
                }
            }
            Table();
        }

        private void AdminViewBus_Load(object sender, EventArgs e)
        {
            Table();
        }
    }
}
