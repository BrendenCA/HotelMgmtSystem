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
    public partial class modifyRoom : UserControl
    {
        private int originalBeds;
        private int originalTotal;
        public modifyRoom()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("SELECT NO_OF_BEDS, PRICE, ROOM_DESC, TOTAL_ROOMS FROM ROOM_TYPE WHERE ROOM_TYPE=:p1", dbms.con);
            cmd.Parameters.Add("p1", roomType.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                noOfBeds.Value = Convert.ToInt32(reader["NO_OF_BEDS"].ToString());
                roomPrice.Text = reader["PRICE"].ToString();
                roomDesc.Text = reader["ROOM_DESC"].ToString();
                roomTotal.Text = reader["TOTAL_ROOMS"].ToString();
                panel.Visible = false;
                roomType.Enabled = false;
                btnSearch.Enabled = false;
                originalBeds = Convert.ToInt32(reader["NO_OF_BEDS"].ToString());
                originalTotal = Convert.ToInt32(reader["TOTAL_ROOMS"].ToString());
            }
            else
            {
                MessageBox.Show("Room type ID not found", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(roomPrice.Text) <= 0)
            {
                MessageBox.Show("Enter valid price", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(roomTotal.Text) < originalTotal)
            {
                MessageBox.Show("Enter valid no. of rooms", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roomTotal.Text = originalTotal.ToString();
                return;
            }
            if (Convert.ToInt32(noOfBeds.Text) < originalBeds)
            {
                MessageBox.Show("Enter valid no. of beds", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                noOfBeds.Text = originalBeds.ToString();
                return;
            }
            if (roomDesc.Text == "")
            {
                MessageBox.Show("Enter valid room type description", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("UPDATE ROOM_TYPE SET NO_OF_BEDS= :p1, PRICE= :p2, ROOM_DESC= :p3, TOTAL_ROOMS= :p4 WHERE ROOM_TYPE=:p5", dbms.con);
            cmd.Parameters.Add("p1", noOfBeds.Text);
            cmd.Parameters.Add("p2", roomPrice.Text);
            cmd.Parameters.Add("p3", roomDesc.Text);
            cmd.Parameters.Add("p4", roomTotal.Text);
            cmd.Parameters.Add("p5", roomType.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room type modified successfully ID:" + roomType.Text, "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Room type not modified\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
