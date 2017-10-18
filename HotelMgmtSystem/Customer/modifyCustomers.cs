using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace HotelMgmtSystem
{
    public partial class modifyCustomers : UserControl
    {
        public modifyCustomers()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            dbms.connect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM CUSTOMER WHERE CUST_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", custId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                panel.Visible = false;
                custId.Enabled = false;
                btnSearch.Enabled = false;
                name.Text = reader["NAME"].ToString();
                address.Text = reader["ADDRESS"].ToString();
                dob.Text = reader["DATE_OF_BIRTH"].ToString();
                aadharNo.Text = reader["AADHAR_NO"].ToString();
                mobileNo.Text = reader["MOBILE_NO"].ToString();
                email.Text = reader["EMAIL_ID"].ToString();
            }
            else
            {
                MessageBox.Show("Customer ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            dbms.connect();
            OracleCommand cmd = new OracleCommand("UPDATE CUSTOMER SET NAME=:p1, ADDRESS=:p2, DATE_OF_BIRTH=:p3, AADHAR_NO=:p4, MOBILE_NO=:p5, EMAIL_ID=:p6 WHERE CUST_ID=:p7", dbms.con);
            cmd.Parameters.Add("p1", name.Text);
            cmd.Parameters.Add("p2", address.Text);
            cmd.Parameters.Add("p3", dob.Value.Date);
            cmd.Parameters.Add("p4", aadharNo.Text);
            cmd.Parameters.Add("p5", mobileNo.Text);
            cmd.Parameters.Add("p6", email.Text);
            cmd.Parameters.Add("p7", custId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer modified successfully", "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Customer not modified\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}