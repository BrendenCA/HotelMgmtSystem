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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + globalVar.userid;
            label2.Text = "Role: " + globalVar.role;

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            customerForm newForm = new customerForm();
            newForm.Show();
        }
    }
}
