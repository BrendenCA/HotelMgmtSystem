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
    public partial class modifyOrder : UserControl
    {
        public modifyOrder()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT ITEM_ID FROM ORDERS WHERE ORDER_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", orderId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                panel.Visible = false;
                orderId.Enabled = false;
                btnSearch.Enabled = false;
                btnChoose.Text = reader["ITEM_ID"].ToString();
            }
            else
            {
                MessageBox.Show("Order ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            OracleCommand cmd = new OracleCommand("UPDATE ORDERS SET ITEM_ID=:p1 WHERE ORDER_ID=:p2", dbms.con);
            cmd.Parameters.Add("p1", btnChoose.Text);
            cmd.Parameters.Add("p2", orderId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order modified successfully ID:" + orderId.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Order not modified\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("DELETE FROM ORDERS WHERE ORDER_ID=:p2", dbms.con);
            cmd.Parameters.Add("p1", btnChoose.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order deleted successfully ID:" + orderId.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Order not deleted\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
