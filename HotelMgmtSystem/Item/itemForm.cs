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
    public partial class itemForm : Form
    {
        public itemForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Size = new Size(286, 139);
            panel.Controls.Clear();
            addItem uc = new addItem();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Size = new Size(286, 139);
            panel.Controls.Clear();
            modifyItem uc = new modifyItem();
            panel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }
    }
}
