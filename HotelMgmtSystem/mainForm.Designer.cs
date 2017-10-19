namespace HotelMgmtSystem
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeText = new System.Windows.Forms.Label();
            this.roleText = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(12, 9);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(87, 13);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome <user>";
            // 
            // roleText
            // 
            this.roleText.AutoSize = true;
            this.roleText.Location = new System.Drawing.Point(153, 9);
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(64, 13);
            this.roleText.TabIndex = 1;
            this.roleText.Text = "Role: <role>";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(66, 59);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(100, 23);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(66, 88);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(100, 23);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(66, 204);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(100, 23);
            this.btnInvoices.TabIndex = 4;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(66, 175);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(100, 23);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Room Service";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(66, 117);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(100, 23);
            this.btnRooms.TabIndex = 6;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(66, 233);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(100, 23);
            this.btnEmployees.TabIndex = 7;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(66, 262);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(100, 23);
            this.btnStats.TabIndex = 8;
            this.btnStats.Text = "View Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(88, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Manage";
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(66, 146);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(100, 23);
            this.btnItems.TabIndex = 10;
            this.btnItems.Text = "Menu items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 293);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.roleText);
            this.Controls.Add(this.welcomeText);
            this.Name = "mainForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Label roleText;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnItems;
    }
}