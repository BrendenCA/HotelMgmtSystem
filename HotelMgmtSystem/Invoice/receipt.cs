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
    public partial class receipt : UserControl
    {
        private double amt = 0;
        public receipt()
        {
            InitializeComponent();
        }

        public receipt(string reservationid)
        {
            InitializeComponent();
            resId.Text = reservationid;
            btnPay.Visible = false;
            dbconnect dbms = new dbconnect();
            TimeSpan days;
            OracleCommand cmd = new OracleCommand("SELECT rt.ROOM_DESC, rt.PRICE, r.CHECK_IN, r.CHECK_OUT FROM RESERVATION r INNER JOIN ROOM_TYPE rt ON r.ROOM_TYPE=rt.ROOM_TYPE WHERE RESERVATION_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            days = Convert.ToDateTime(reader["CHECK_OUT"].ToString()) - Convert.ToDateTime(reader["CHECK_IN"].ToString());
            dataGridView.Rows.Add(reader["ROOM_DESC"].ToString() + " x" + days.TotalDays, "₹" + reader["PRICE"].ToString());
            amt += Convert.ToInt32(reader["PRICE"]) * days.TotalDays;

            cmd = new OracleCommand("SELECT i.ITEM_NAME, i.ITEM_PRICE FROM ORDERS o INNER JOIN ITEMS i ON o.ITEM_ID=i.ITEM_ID WHERE o.RESERVATION_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView.Rows.Add(reader["ITEM_NAME"].ToString(), "₹" + reader["ITEM_PRICE"].ToString());
                amt += Convert.ToInt32(reader["ITEM_PRICE"]);
            }
            date.Text = DateTime.Now.ToShortDateString();
            invoiceAmt.Text = amt.ToString();

            cmd = new OracleCommand("SELECT * FROM INVOICE WHERE RESERVATION_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //invoice already exists
                invoiceId.Text = reader["INVOICE_ID"].ToString();
                invoiceStatus.Text = reader["STATUS"].ToString();
                invoiceTransId.Text = reader["TRANSACTION_ID"].ToString();
                cmd = new OracleCommand("UPDATE INVOICE SET AMOUNT= :p1 WHERE INVOICE_ID=:p2", dbms.con);
                cmd.Parameters.Add("p1", invoiceAmt.Text);
                cmd.Parameters.Add("p2", invoiceId.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                //invoice doesn't exist
                cmd = new OracleCommand("INSERT INTO INVOICE (AMOUNT, STATUS, RESERVATION_ID) values (:p1, :p2, :p3)", dbms.con);
                cmd.Parameters.Add("p1", invoiceAmt.Text);
                cmd.Parameters.Add("p2", "Pending");
                cmd.Parameters.Add("p3", resId.Text);
                cmd.ExecuteNonQuery();
                invoiceStatus.Text = "Pending";
                cmd = new OracleCommand("SELECT INVOICE_ID_SEQ.CURRVAL FROM DUAL", dbms.con);
                reader = cmd.ExecuteReader();
                reader.Read();
                invoiceId.Text = reader[0].ToString();
            }
            if (invoiceStatus.Text != "Paid")
                btnPay.Visible = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            transactionForm newForm = new transactionForm(amt);
            newForm.ShowDialog();
            if (newForm.transSuccess)
            {
                invoiceStatus.Text = "Paid";
                btnPay.Visible = false;
            }
        }

        private void receipt_Load(object sender, EventArgs e)
        {

        }
    }

}