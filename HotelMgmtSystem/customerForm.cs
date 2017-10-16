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
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!panel.Controls.Contains(addCustomers.Instance))
            {
                panel.Controls.Add(addCustomers.Instance);
                addCustomers.Instance.Dock = DockStyle.Fill;
                addCustomers.Instance.BringToFront();
            }
            else
                addCustomers.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(modifyCustomers.Instance))
            {
                panel.Controls.Add(modifyCustomers.Instance);
                modifyCustomers.Instance.Dock = DockStyle.Fill;
                modifyCustomers.Instance.BringToFront();
            }
            else
                modifyCustomers.Instance.BringToFront();
        }
    }
}
