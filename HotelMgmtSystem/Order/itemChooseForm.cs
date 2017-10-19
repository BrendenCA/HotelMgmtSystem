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
    public partial class itemChooseForm : Form
    {
        public string itemChoiceId;
        public itemChooseForm()
        {
            InitializeComponent();
        }

        private void itemChooseForm_Load(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT ITEM_ID, ITEM_NAME, ITEM_PRICE FROM ITEMS", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                this.dataGridView.Rows.Add(reader["ITEM_ID"], reader["ITEM_NAME"], reader["ITEM_PRICE"]);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                itemChoiceId = row.Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}
