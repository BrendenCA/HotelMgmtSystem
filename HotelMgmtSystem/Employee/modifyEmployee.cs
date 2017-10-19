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
    public partial class modifyEmployee : UserControl
    {
        public modifyEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM EMPLOYEE WHERE EMP_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", empId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                panel.Visible = false;
                empId.Enabled = false;
                btnSearch.Enabled = false;
                name.Text = reader["NAME"].ToString();
                address.Text = reader["ADDRESS"].ToString();
                aadharNo.Text = reader["AADHAR_NO"].ToString();
                mobileNo.Text = reader["MOBILE_NO"].ToString();
                userId.Text = reader["USER_ID"].ToString();
                salary.Text = reader["SALARY"].ToString();
            }
            else
            {
                MessageBox.Show("Employee ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("UPDATE EMPLOYEE SET NAME=:p1, ADDRESS=:p2, AADHAR_NO=:p3, MOBILE_NO=:p4, USER_ID=:p5, SALARY=:p6 WHERE EMP_ID=:p7", dbms.con);
            cmd.Parameters.Add("p1", name.Text);
            cmd.Parameters.Add("p2", address.Text);
            cmd.Parameters.Add("p3", aadharNo.Text);
            cmd.Parameters.Add("p4", mobileNo.Text);
            cmd.Parameters.Add("p5", userId.Text);
            cmd.Parameters.Add("p6", salary.Text);
            cmd.Parameters.Add("p7", empId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("UPDATE EMP_LOGIN SET USER_ID=:p1 , PASSWORD=:p2 , ROLE=:p3 WHERE EMP_ID=:p4", dbms.con);
                cmd.Parameters.Add("p1", userId.Text);
                cmd.Parameters.Add("p2", password.Text);
                cmd.Parameters.Add("p3", role.Text);
                cmd.Parameters.Add("p4", empId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee modified successfully ID:" + empId.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Employee not modified\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("DELETE FROM EMPLOYEE WHERE EMP_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", empId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("DELETE FROM EMP_LOGIN WHERE EMP_ID=:p1", dbms.con);
                cmd.Parameters.Add("p1", empId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully ID:" + empId.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Employee not deleted\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
