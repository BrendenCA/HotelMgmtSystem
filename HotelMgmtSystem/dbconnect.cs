using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace HotelMgmtSystem
{
    class dbconnect
    {
        public OracleConnection con;
        public dbconnect()
        {
            con = new OracleConnection("DATA SOURCE=oracle.root.sx:49161/XE;PASSWORD=DBMS;USER ID=DBMS");
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("DB connection failed\n" + e.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
