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
    public partial class addRoom : UserControl
    {
        public addRoom()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(roomPrice.Text) <= 0)
            {
                MessageBox.Show("Enter valid price", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(roomTotal.Text) <= 0)
            {
                MessageBox.Show("Enter valid no. of rooms", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (roomDesc.Text == "")
            {
                MessageBox.Show("Enter valid room type description", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbconnect dbms = new dbconnect();
            OracleCommand cmd = new OracleCommand("INSERT INTO ROOM_TYPE (NO_OF_BEDS, PRICE, ROOM_DESC, TOTAL_ROOMS) VALUES (:p1, :p2, :p3, :p4)", dbms.con);
            cmd.Parameters.Add("p1", noOfBeds.Text);
            cmd.Parameters.Add("p2", roomPrice.Text);
            cmd.Parameters.Add("p3", roomDesc.Text);
            cmd.Parameters.Add("p4", roomTotal.Text);
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("SELECT ROOM_TYPE_SEQ.CURRVAL FROM DUAL", dbms.con);
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show("Room type added successfully ID:" + reader[0].ToString(), "Success");
                ((Form)this.TopLevelControl).Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Room type not added\n" + exp.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
