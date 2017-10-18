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
    public partial class roomChooseForm : Form
    {
        public string roomChoiceId;
        public string roomBeds;

        public roomChooseForm()
        {
            InitializeComponent();
        }

        private void roomChooseForm_Load(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT ROOM_TYPE, ROOM_DESC, NO_OF_BEDS, PRICE FROM ROOM_TYPE", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
                this.dataGridView.Rows.Add(reader["ROOM_TYPE"], reader["ROOM_DESC"], reader["NO_OF_BEDS"], reader["PRICE"]);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                roomChoiceId = row.Cells[0].Value.ToString();
                roomBeds = row.Cells[2].Value.ToString();
            }
            this.Close();
        }
    }
}
