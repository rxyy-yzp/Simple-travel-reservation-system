using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 简单旅行预订系统
{
    public partial class AdminViewCity : Form
    {
        public AdminViewCity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag1, flag2, flag3, flag4 = 0;
            dataGridView1.Rows.Clear();//清空已有数据
            ArrayList cityList = new ArrayList();
            Dao dao = new Dao();
            string sql1 = $"select DISTINCT FLIGHTS.FromCity from FLIGHTS,RESV_FLIGHTS where RESV_FLIGHTS.custID='{textBox1.Text}' and RESV_FLIGHTS.resvFlightNum=FLIGHTS.flightNum";
            IDataReader dc1 = dao.read(sql1);
            while (dc1.Read())//循环读取每行数据
            {
                flag1 = 0;
                for (int i = 0; i < cityList.Count; i++)
                {
                    if (cityList[i].ToString() == dc1[0].ToString())
                    {
                        flag1 = 1;
                        break;
                    }
                }
                if (flag1 == 0)
                {
                    cityList.Add(dc1[0].ToString());
                }
            }
            string sql2 = $"select DISTINCT FLIGHTS.ArivCity from FLIGHTS,RESV_FLIGHTS where RESV_FLIGHTS.custID='{textBox1.Text}' and RESV_FLIGHTS.resvFlightNum=FLIGHTS.flightNum";
            IDataReader dc2 = dao.read(sql2);
            while (dc2.Read())//循环读取每行数据
            {
                flag2 = 0;
                for (int i = 0; i < cityList.Count; i++)
                {
                    if (cityList[i].ToString() == dc2[0].ToString())
                    {
                        flag2 = 1;
                        break;
                    }
                    
                }
                if(flag2==0)
                {
                    cityList.Add(dc2[0].ToString());
                }
            }
            string sql3 = $"select DISTINCT BUS.FromCity from BUS,RESV_BUS where RESV_BUS.custID='{textBox1.Text}' and RESV_BUS.resvBusNum=BUS.BusNum";
            IDataReader dc3 = dao.read(sql3);
            while (dc3.Read())//循环读取每行数据
            {
                flag3 = 0;
                for (int i = 0; i < cityList.Count; i++)
                {
                    if (cityList[i].ToString() == dc3[0].ToString())
                    {
                        flag3 = 1;
                        break;
                    }

                }
                if (flag3 == 0)
                {
                    cityList.Add(dc3[0].ToString());
                }
            }
            string sql4 = $"select DISTINCT BUS.ArivCity from BUS,RESV_BUS where RESV_BUS.custID='{textBox1.Text}' and RESV_BUS.resvBusNum=BUS.BusNum";
            IDataReader dc4 = dao.read(sql4);
            while (dc4.Read())//循环读取每行数据
            {
                flag4 = 0;
                for (int i = 0; i < cityList.Count; i++)
                {
                    if (cityList[i].ToString() == dc4[0].ToString())
                    {
                        flag4 = 1;
                        break;
                    }

                }
                if (flag4 == 0)
                {
                    cityList.Add(dc4[0].ToString());
                }
            }
            for (int i = 0; i < cityList.Count; i++)
            {
                dataGridView1.Rows.Add(cityList[i].ToString());
            }
            dc1.Close();
            dc2.Close();
            dao.Daoclose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
