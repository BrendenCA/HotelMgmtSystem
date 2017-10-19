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
    public partial class transactionForm : Form
    {
        public string transId;
        public bool transSuccess = false;

        public transactionForm()
        {
            InitializeComponent();
        }

        public transactionForm(double amt)
        {
            InitializeComponent();
            transAmt.Text = amt.ToString();
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked == true)
            {
                cardType.Enabled = false;
                cardNo.Enabled = false;
                cardExpDate.Enabled = false;
                cardCvv.Enabled = false;
            }
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCard.Checked == true)
            {
                cardType.Enabled = true;
                cardNo.Enabled = true;
                cardExpDate.Enabled = true;
                cardCvv.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rbCard.Checked == true)
            {
                if (cardNo.Text == "")
                {
                    MessageBox.Show("Enter valid card number", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cardName.Text == "")
                {
                    MessageBox.Show("Enter valid name on card", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cardExpDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Card expired", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cardCvv.Text == "")
                {
                    MessageBox.Show("Enter valid card cvv", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dbconnect dbms = new dbconnect();
                OracleCommand cmd = new OracleCommand("INSERT INTO TRANSACTION (PAYMENT_METHOD, CARD_TYPE, CARD_NO, CARD_NAME, CARD_EXP, CARD_CVV) values (:p1, :p2, :p3, :p4, :p5, :p6)", dbms.con);
                cmd.Parameters.Add("p1", rbCard.Text);
                if(rbVisa.Checked)
                    cmd.Parameters.Add("p2", rbVisa.Text);
                else
                    cmd.Parameters.Add("p2", rbMaster.Text);
                cmd.Parameters.Add("p3", cardNo.Text);
                cmd.Parameters.Add("p4", cardName.Text);
                cmd.Parameters.Add("p5", cardExpDate.Value.Date);
                cmd.Parameters.Add("p6", cardCvv.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd = new OracleCommand("SELECT TRANSACTION_ID_SEQ.CURRVAL FROM DUAL", dbms.con);
                    OracleDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    MessageBox.Show("Payment successful ID:" + reader[0].ToString(), "Success");
                    transId = reader[0].ToString();
                    transSuccess = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Payment not successful\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
