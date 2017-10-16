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
    public partial class addCustomers : UserControl
    {
        private static addCustomers _instance;
        public static addCustomers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addCustomers();
                return _instance;
            }
        }
        public addCustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            dbms.connect();
            OracleCommand cmd = new OracleCommand("INSERT INTO CUSTOMER (NAME, ADDRESS, DATE_OF_BIRTH, AADHAR_NO, MOBILE_NO, EMAIL_ID) VALUES (:p1, :p2, :p3, :p4, :p5, :p6)", dbms.con);
            cmd.Parameters.Add("p1", name.Text);
            cmd.Parameters.Add("p2", address.Text);
            cmd.Parameters.Add("p3", dob.Value.Date);
            cmd.Parameters.Add("p4", aadharNo.Text);
            cmd.Parameters.Add("p5", mobileNo.Text);
            cmd.Parameters.Add("p6", email.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully", "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch(Exception exp)
            { 
                MessageBox.Show("Customer not added\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
