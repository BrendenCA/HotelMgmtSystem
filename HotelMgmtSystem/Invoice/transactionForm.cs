using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
