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
    public partial class modifyReservation : UserControl
    {
        private int roomSize;

        public modifyReservation()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT * FROM RESERVATION WHERE RESERVATION_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                noOfGuests.Text = reader["NO_OF_GUESTS"].ToString();
                checkInDate.Text = reader["CHECK_IN"].ToString();
                checkOutDate.Text = reader["CHECK_OUT"].ToString();
                if (checkInDate.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Cannot modify", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
            roomChooseForm newForm = new roomChooseForm();
            newForm.ShowDialog();
            btnChoose.Text = newForm.roomChoiceId;
            btnChoose.Enabled = false;
            roomSize = Convert.ToInt32(newForm.roomBeds);
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
            if (!checkAvailability())
            {
                MessageBox.Show("Room type not available on selected days", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnChoose.Text = "Choose";
                btnChoose.Enabled = true;
                return;
            }
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("UPDATE RESERVATION SET NO_OF_GUESTS= :p1, CHECK_IN= :p2, CHECK_OUT= :p3, ROOM_TYPE= :p4 WHERE RESERVATION_ID= :p5", dbms.con);
            cmd.Parameters.Add("p1", noOfGuests.Text);
            cmd.Parameters.Add("p2", checkInDate.Value.Date);
            cmd.Parameters.Add("p3", checkOutDate.Value.Date);
            cmd.Parameters.Add("p4", btnChoose.Text);
            cmd.Parameters.Add("p5", resId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully modified ID:" + resId.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Reservation not created\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("DELETE FROM RESERVATION WHERE RESERVATION_ID=:p1", dbms.con);
            cmd.Parameters.Add("p1", resId.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully deleted", "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Reservation not deleted\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cmd = new OracleCommand("SELECT COUNT(*) FROM RESERVATION WHERE ROOM_TYPE=:p1 AND CHECK_IN<=:p2 AND CHECK_OUT>=:p2 AND RESERVATION_ID!= :p3", dbms.con);
                cmd.Parameters.Add("p1", btnChoose.Text);
                cmd.Parameters.Add("p2", date.Date);
                cmd.Parameters.Add("p2", date.Date);
                cmd.Parameters.Add("p3", resId.Text);
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
