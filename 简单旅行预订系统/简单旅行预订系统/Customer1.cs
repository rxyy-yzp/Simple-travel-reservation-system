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
    public partial class Customer1 : Form
    {
        public Customer1()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 预定机票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerQuery customerquery = new CustomerQuery();
            customerquery.ShowDialog();
        }

        private void 预定巴士ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerResvFlight customerresvflight = new CustomerResvFlight();
            customerresvflight.ShowDialog();
        }

        private void 预定旅馆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerResvBus customerresvbus = new CustomerResvBus();
            customerresvbus.ShowDialog();
        }

        private void 预定旅馆ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerResvHotel customerresvhotel = new CustomerResvHotel();
            customerresvhotel.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerMyResv customermyresv = new CustomerMyResv();
            customermyresv.ShowDialog();
        }
    }
}
