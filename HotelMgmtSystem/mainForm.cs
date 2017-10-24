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
            welcomeText.Text = "Welcome " + globalVar.userid;
            roleText.Text = "Role: " + globalVar.role;
            if (globalVar.role == "staff")
            {
                btnStats.Hide();
                btnStats2.Hide();
                btnEmployees.Hide();
                btnEmployees2.Hide();
            }
            this.Refresh();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            customerForm newForm = new customerForm();
            newForm.Show();
        }
        
        private void btnReservations_Click(object sender, EventArgs e)
        {
            reservationForm newForm = new reservationForm();
            newForm.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            roomForm newForm = new roomForm();
            newForm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            itemForm newForm = new itemForm();
            newForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            orderForm newForm = new orderForm();
            newForm.Show();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            invoiceForm newForm = new invoiceForm();
            newForm.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            employeeForm newForm = new employeeForm();
            newForm.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            statsForm newForm = new statsForm();
            newForm.Show();
        }
    }
}
