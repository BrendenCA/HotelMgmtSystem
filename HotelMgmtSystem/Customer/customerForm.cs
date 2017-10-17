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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Size = new Size(517, 300);
            panel.Controls.Clear();
            addCustomers uc = new addCustomers();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Size = new Size(517, 300);
            panel.Controls.Clear();
            modifyCustomers uc = new modifyCustomers();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }
    }
}