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
    public partial class addReservation : UserControl
    {
        private int roomSize;
        public addReservation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM CUSTOMER WHERE CUST_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", custId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader["COUNT(*)"].ToString() == "1")
            {
                panel.Visible = false;
                custId.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("Customer ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnChoose.Enabled == true)
            {
                MessageBox.Show("Please choose a room", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkInDate.Value > checkOutDate.Value)
            {
                MessageBox.Show("Check-out date can't be before check-in", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(noOfGuests.Text) > roomSize)
            {
                MessageBox.Show("Room too small! Choose again", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnChoose.Text = "Choose";
                btnChoose.Enabled = true;
                return;
            }
            if(!checkAvailability())
            {
                MessageBox.Show("Room type not available on selected days", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnChoose.Text = "Choose";
                btnChoose.Enabled = true;
                return;
            }
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("INSERT INTO RESERVATION (NO_OF_GUESTS, CHECK_IN, CHECK_OUT, CUST_ID, ROOM_TYPE) VALUES (:p1, :p2, :p3, :p4, :p5)", dbms.con);
            cmd.Parameters.Add("p1", noOfGuests.Text);
            cmd.Parameters.Add("p2", checkInDate.Value.Date);
            cmd.Parameters.Add("p3", checkOutDate.Value.Date);
            cmd.Parameters.Add("p4", custId.Text);
            cmd.Parameters.Add("p5", btnChoose.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT RESERVATION_ID_SEQ.CURRVAL FROM DUAL", dbms.con);
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show("Reservation created successfully ID:" + reader[0].ToString(), "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Reservation not created\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            roomChooseForm newForm = new roomChooseForm();
            newForm.ShowDialog();
            btnChoose.Text = newForm.roomChoiceId;
            btnChoose.Enabled = false;
            roomSize = Convert.ToInt32(newForm.roomBeds);
        }

        private bool checkAvailability()
        {
            int booked;
            int total;
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT TOTAL_ROOMS FROM ROOM_TYPE WHERE ROOM_TYPE=:p1", dbms.con);
            cmd.Parameters.Add("p1", btnChoose.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            total = Convert.ToInt32(reader["TOTAL_ROOMS"].ToString());

            for (DateTime date = checkInDate.Value; date <= checkOutDate.Value; date = date.AddDays(1))
            {
                cmd = new OracleCommand("SELECT COUNT(*) FROM RESERVATION WHERE ROOM_TYPE=:p1 AND CHECK_IN<=:p2 AND CHECK_OUT>=:p2", dbms.con);
                cmd.Parameters.Add("p1", btnChoose.Text);
                cmd.Parameters.Add("p2", date.Date);
                cmd.Parameters.Add("p2", date.Date);
                reader = cmd.ExecuteReader();
                reader.Read();
                booked = Convert.ToInt32(reader["COUNT(*)"].ToString());
                if ((total - booked) <= 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
