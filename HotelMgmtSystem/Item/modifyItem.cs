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
    public partial class modifyItem : UserControl
    {
        public modifyItem()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM ITEMS WHERE ITEM_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", itemId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                panel.Visible = false;
                itemId.Enabled = false;
                btnSearch.Enabled = false;
                itemName.Text = reader["ITEM_NAME"].ToString();
                itemPrice.Text = reader["ITEM_PRICE"].ToString();
            }
            else
            {
                MessageBox.Show("Item ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("UPDATE ITEMS SET ITEM_NAME=:p1, ITEM_PRICE=:p2 WHERE ITEM_ID=:p3", dbms.con);
            cmd.Parameters.Add("p1", itemName.Text);
            cmd.Parameters.Add("p2", itemPrice.Text);
            cmd.Parameters.Add("p3", itemId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item modified successfully ID:" + itemId.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Item not modified\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
