using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HotelMgmtSystem
{
    public partial class invoiceForm : Form
    {
        public invoiceForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM RESERVATION WHERE RESERVATION_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["COUNT(*)"].ToString() == "1")
            {
                panel.Visible = true;
                //change panel to recipt
                this.Size = new Size(619, 419);
                panel.Controls.Clear();
                receipt uc = new receipt(resId.Text);
                panel.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
            {
                MessageBox.Show("Invalid reservation ID", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
