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
    public partial class AdminUserManage : Form
    {
        public AdminUserManage()
        {
            InitializeComponent();
        }

        //从数据库读取数据显示在表格中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空已有数据
            Dao dao = new Dao();
            string sql1 = "select * from CUSTOMERS";
            IDataReader dc = dao.read(sql1);
            while (dc.Read())//循环读取每行数据
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void AdminUserManage_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminInsertUser admininsertuser = new AdminInsertUser();
            admininsertuser.ShowDialog();
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string custid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取账户ID
                DialogResult dr = MessageBox.Show("确认删除吗?", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    //退还所有预定
                    Dao dao1 = new Dao();
                    string sql1 = $"select * from RESV_FLIGHTS where custID ='{custid}'";
                    IDataReader dc1 = dao1.read(sql1);
                    while (dc1.Read())//循环读取每行数据
                    {
                        string flightnum = dc1[3].ToString();
                        string sql11 = $"update FLIGHTS set numAvail=numAvail+1 where flightNum='{flightnum}'";
                        dao1.Execute(sql11);
                    }
                    string sql2 = $"select * from RESV_BUS where custID ='{custid}'";
                    IDataReader dc2 = dao1.read(sql2);
                    while (dc2.Read())//循环读取每行数据
                    {
                        string busnum = dc2[3].ToString();
                        string sql21 = $"update BUS set numAvail=numAvail+1 where BusNum='{busnum}'";
                        dao1.Execute(sql21);
                    }
                    string sql3 = $"select * from RESV_HOTELS where custID ='{custid}'";
                    IDataReader dc3 = dao1.read(sql3);
                    while (dc3.Read())//循环读取每行数据
                    {
                        string hotelname = dc3[3].ToString();
                        string sql31 = $"update HOTELS set numAvail=numAvail+1 where hotelName='{hotelname}'";
                        dao1.Execute(sql31);
                    }
                    dao1.Daoclose();
                    //执行删除
                    string sql = $"delete from CUSTOMERS where custID ='{custid}'";
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
                MessageBox.Show("请先选中要删除的消费者账户信息!", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUpdateUser adminupdateuser = new AdminUpdateUser();
            adminupdateuser.ShowDialog();
            Table();
        }
    }
}

