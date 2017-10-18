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
using Oracle.ManagedDataAccess.Types;

namespace HotelMgmtSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            try
            {
                dbms.connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the DB\r\n" + "Error Message: \r\n" + ex.Message);
            }
            
            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM EMP_LOGIN WHERE USERID= :p1 AND PASSWORD= :p2", dbms.con);
            cmd.Parameters.Add("p1", user.Text);
            cmd.Parameters.Add("p2", pass.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["COUNT(*)"].ToString() == "1")
            {
                cmd = new OracleCommand("SELECT USERID, ROLE FROM EMP_LOGIN WHERE USERID= :p1 AND PASSWORD= :p2", dbms.con);
                cmd.Parameters.Add("p1", user.Text);
                cmd.Parameters.Add("p2", pass.Text);
                reader = cmd.ExecuteReader();
                reader.Read();
                globalVar.loginStatus = true;
                globalVar.userid = reader["USERID"].ToString();
                globalVar.role = reader["ROLE"].ToString();
                MessageBox.Show("User " + globalVar.userid + " logged in as " + globalVar.role, "Success");
                this.Close();
            }
            else
                MessageBox.Show("Username/Password invalid");
        }
    }
}
