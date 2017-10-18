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
    public partial class reservationForm : Form
    {
        public reservationForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Size = new Size(350, 213);
            panel.Controls.Clear();
            addReservation uc = new addReservation();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Size = new Size(350, 213);
            panel.Controls.Clear();
            modifyReservation uc = new modifyReservation();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }
    }
}
