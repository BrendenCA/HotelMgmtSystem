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
    public partial class addOrder : UserControl
    {
        public addOrder()
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
                panel.Visible = false;
                resId.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("Reservation ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            itemChooseForm newForm = new itemChooseForm();
            newForm.ShowDialog();
            btnChoose.Text = newForm.itemChoiceId;
            btnChoose.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("INSERT INTO ORDERS (RESERVATION_ID, ITEM_ID, ORDER_DATE) VALUES (:p1, :p2, :p3)", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            cmd.Parameters.Add("p2", btnChoose.Text);
            cmd.Parameters.Add("p3", DateTime.Now.Date);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT ORDER_ID_SEQ.CURRVAL FROM DUAL", dbms.con);
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show("Order created successfully ID:" + reader[0].ToString(), "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Order not created\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
