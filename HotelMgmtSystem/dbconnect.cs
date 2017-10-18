using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace HotelMgmtSystem
{
    class dbconnect
    {
        public OracleConnection con;
        public void connect()
        {
            con = new OracleConnection("DATA SOURCE=oracle.kozow.com:1521/XE;PASSWORD=DBMS;USER ID=DBMS");
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                throw e;        
            }
           
        }
    }
}
