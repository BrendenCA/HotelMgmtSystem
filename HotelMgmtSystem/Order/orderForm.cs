using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgmtSystem
{
    public partial class orderForm : Form
    {
        public orderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(317, 149);
            panel.Controls.Clear();
            addOrder uc = new addOrder();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(317, 149);
            panel.Controls.Clear();
            modifyOrder uc = new modifyOrder();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }
    }
}
