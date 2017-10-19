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
    public partial class statsForm : Form
    {
        public statsForm()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM CUSTOMER", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM RESERVATION", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM ROOM_TYPE", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM ORDERS", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM ITEMS", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM INVOICE", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM TRANSACTION", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM EMPLOYEES e INNER JOIN EMP_LOGIN el ON e.EMP_ID=el.EMP_ID", dbms.con);
            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }
    }
}
