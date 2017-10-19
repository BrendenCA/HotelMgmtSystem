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
    public partial class addItem : UserControl
    {
        public addItem()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(itemName.Text == "")
            {
                MessageBox.Show("Enter valid name", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(itemPrice.Text)<=0)
            {
                MessageBox.Show("Enter valid price", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("INSERT INTO ITEMS (ITEM_NAME, ITEM_PRICE) VALUES (:p1, :p2)", dbms.con);
            cmd.Parameters.Add("p1", itemName.Text);
            cmd.Parameters.Add("p2", itemPrice.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT ITEM_ID_SEQ.CURRVAL FROM DUAL", dbms.con);
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show("Item added successfully ID:" + reader[0].ToString(), "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Item not added\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
