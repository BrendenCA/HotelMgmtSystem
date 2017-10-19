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
    public partial class roomForm : Form
    {
        public roomForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Size = new Size(313, 217);
            panel.Controls.Clear();
            addRoom uc = new addRoom();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Size = new Size(313, 217);
            panel.Controls.Clear();
            modifyRoom uc = new modifyRoom();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }
    }
}
