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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }   

        private void 管理航班信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFlight adminflight = new AdminFlight();
            adminflight.ShowDialog();
        }

        private void 管理巴士信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBus adminbus = new AdminBus();
            adminbus.ShowDialog();
        }

        private void 管理旅馆信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHotel adminhotel = new AdminHotel();
            adminhotel.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 消费者账户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUserManage adm = new AdminUserManage();
            adm.ShowDialog();
        }

        private void 航班订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminViewFlight admvf = new AdminViewFlight();
            admvf.ShowDialog();
        }

        private void 巴士订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminViewBus admvb = new AdminViewBus();
            admvb.ShowDialog();
        }

        private void 旅馆订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminViewHotel admvh = new AdminViewHotel();
            admvh.ShowDialog();
        }

        private void 消费者旅行线路查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminViewCity admvc = new AdminViewCity();
            admvc.ShowDialog();
        }
    }
}
