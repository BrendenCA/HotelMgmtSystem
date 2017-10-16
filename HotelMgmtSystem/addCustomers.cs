using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgmtSystem
{
    public partial class addCustomers : UserControl
    {
        private static addCustomers _instance;
        public static addCustomers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addCustomers();
                return _instance;
            }
        }
        public addCustomers()
        {
            InitializeComponent();
        }
    }
}
