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
    public partial class addEmployee : UserControl
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string empId;
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("INSERT INTO EMPLOYEES (NAME, ADDRESS, AADHAR_NO, MOBILE_NO, USER_ID, SALARY) VALUES (:p1, :p2, :p3, :p4, :p5, :p6)", dbms.con);
            cmd.Parameters.Add("p1", name.Text);
            cmd.Parameters.Add("p2", address.Text);
            cmd.Parameters.Add("p3", aadharNo.Text);
            cmd.Parameters.Add("p4", mobileNo.Text);
            cmd.Parameters.Add("p5", userId.Text);
            cmd.Parameters.Add("p6", salary.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT EMP_ID_SEQ.CURRVAL FROM DUAL", dbms.con);
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                empId = reader[0].ToString();
                cmd = new OracleCommand("INSERT INTO EMP_LOGIN (EMP_ID, USER_ID, PASSWORD, ROLE) VALUES (:p1, :p2, :p3, :p4)", dbms.con);
                cmd.Parameters.Add("p1", empId);
                cmd.Parameters.Add("p2", userId.Text);
                cmd.Parameters.Add("p3", password.Text);
                cmd.Parameters.Add("p4", role.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added successfully ID:" + empId, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Employee not added\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
