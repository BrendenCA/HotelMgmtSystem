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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.welcomeText = new System.Windows.Forms.Label();
            this.roleText = new System.Windows.Forms.Label();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnReservations2 = new System.Windows.Forms.Button();
            this.btnCustomers2 = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnRooms2 = new System.Windows.Forms.Button();
            this.btnItems2 = new System.Windows.Forms.Button();
            this.btnOrders2 = new System.Windows.Forms.Button();
            this.btnStats2 = new System.Windows.Forms.Button();
            this.btnEmployees2 = new System.Windows.Forms.Button();
            this.btnInvoices2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(38, 21);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(106, 18);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Welcome <user>";
            // 
            // roleText
            // 
            this.roleText.AutoSize = true;
            this.roleText.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleText.Location = new System.Drawing.Point(417, 22);
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(77, 17);
            this.roleText.TabIndex = 1;
            this.roleText.Text = "Role: <role>";
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.SystemColors.Control;
            this.btnInvoices.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.invoice;
            this.btnInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Location = new System.Drawing.Point(170, 191);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(80, 80);
            this.btnInvoices.TabIndex = 4;
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrders.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.service;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Location = new System.Drawing.Point(299, 191);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(80, 80);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.employees;
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Location = new System.Drawing.Point(41, 191);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(80, 80);
            this.btnEmployees.TabIndex = 7;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.Control;
            this.btnStats.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.stats;
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Location = new System.Drawing.Point(426, 191);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(80, 80);
            this.btnStats.TabIndex = 8;
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.SystemColors.Control;
            this.btnItems.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.menu;
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnItems.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Location = new System.Drawing.Point(426, 62);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(80, 80);
            this.btnItems.TabIndex = 10;
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnReservations2
            // 
            this.btnReservations2.BackColor = System.Drawing.SystemColors.Control;
            this.btnReservations2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations2.ForeColor = System.Drawing.Color.Black;
            this.btnReservations2.Location = new System.Drawing.Point(170, 145);
            this.btnReservations2.Name = "btnReservations2";
            this.btnReservations2.Size = new System.Drawing.Size(80, 23);
            this.btnReservations2.TabIndex = 12;
            this.btnReservations2.Text = "Reservation";
            this.btnReservations2.UseVisualStyleBackColor = false;
            this.btnReservations2.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnCustomers2
            // 
            this.btnCustomers2.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomers2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers2.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers2.Location = new System.Drawing.Point(41, 145);
            this.btnCustomers2.Name = "btnCustomers2";
            this.btnCustomers2.Size = new System.Drawing.Size(80, 23);
            this.btnCustomers2.TabIndex = 13;
            this.btnCustomers2.Text = "Customers";
            this.btnCustomers2.UseVisualStyleBackColor = false;
            this.btnCustomers2.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.SystemColors.Control;
            this.btnRooms.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.rooms;
            this.btnRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnRooms.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Location = new System.Drawing.Point(299, 62);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(80, 80);
            this.btnRooms.TabIndex = 6;
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.SystemColors.Control;
            this.btnReservations.BackgroundImage = global::HotelMgmtSystem.Properties.Resources.reservation;
            this.btnReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservations.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnReservations.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Location = new System.Drawing.Point(170, 62);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(80, 80);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Location = new System.Drawing.Point(41, 62);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(80, 80);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRooms2
            // 
            this.btnRooms2.BackColor = System.Drawing.SystemColors.Control;
            this.btnRooms2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms2.ForeColor = System.Drawing.Color.Black;
            this.btnRooms2.Location = new System.Drawing.Point(299, 145);
            this.btnRooms2.Name = "btnRooms2";
            this.btnRooms2.Size = new System.Drawing.Size(80, 23);
            this.btnRooms2.TabIndex = 15;
            this.btnRooms2.Text = "Rooms";
            this.btnRooms2.UseVisualStyleBackColor = false;
            this.btnRooms2.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnItems2
            // 
            this.btnItems2.BackColor = System.Drawing.SystemColors.Control;
            this.btnItems2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems2.ForeColor = System.Drawing.Color.Black;
            this.btnItems2.Location = new System.Drawing.Point(426, 145);
            this.btnItems2.Name = "btnItems2";
            this.btnItems2.Size = new System.Drawing.Size(80, 23);
            this.btnItems2.TabIndex = 14;
            this.btnItems2.Text = "Menu Items";
            this.btnItems2.UseVisualStyleBackColor = false;
            this.btnItems2.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnOrders2
            // 
            this.btnOrders2.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrders2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders2.ForeColor = System.Drawing.Color.Black;
            this.btnOrders2.Location = new System.Drawing.Point(299, 277);
            this.btnOrders2.Name = "btnOrders2";
            this.btnOrders2.Size = new System.Drawing.Size(80, 23);
            this.btnOrders2.TabIndex = 19;
            this.btnOrders2.Text = "Service";
            this.btnOrders2.UseVisualStyleBackColor = false;
            this.btnOrders2.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStats2
            // 
            this.btnStats2.BackColor = System.Drawing.SystemColors.Control;
            this.btnStats2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats2.ForeColor = System.Drawing.Color.Black;
            this.btnStats2.Location = new System.Drawing.Point(426, 277);
            this.btnStats2.Name = "btnStats2";
            this.btnStats2.Size = new System.Drawing.Size(80, 23);
            this.btnStats2.TabIndex = 18;
            this.btnStats2.Text = "View Stats";
            this.btnStats2.UseVisualStyleBackColor = false;
            this.btnStats2.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnEmployees2
            // 
            this.btnEmployees2.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployees2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees2.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees2.Location = new System.Drawing.Point(41, 277);
            this.btnEmployees2.Name = "btnEmployees2";
            this.btnEmployees2.Size = new System.Drawing.Size(80, 23);
            this.btnEmployees2.TabIndex = 17;
            this.btnEmployees2.Text = "Employees";
            this.btnEmployees2.UseVisualStyleBackColor = false;
            this.btnEmployees2.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnInvoices2
            // 
            this.btnInvoices2.BackColor = System.Drawing.SystemColors.Control;
            this.btnInvoices2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices2.ForeColor = System.Drawing.Color.Black;
            this.btnInvoices2.Location = new System.Drawing.Point(170, 277);
            this.btnInvoices2.Name = "btnInvoices2";
            this.btnInvoices2.Size = new System.Drawing.Size(80, 23);
            this.btnInvoices2.TabIndex = 16;
            this.btnInvoices2.Text = "Invoices";
            this.btnInvoices2.UseVisualStyleBackColor = false;
            this.btnInvoices2.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 322);
            this.Controls.Add(this.btnOrders2);
            this.Controls.Add(this.btnStats2);
            this.Controls.Add(this.btnEmployees2);
            this.Controls.Add(this.btnInvoices2);
            this.Controls.Add(this.btnRooms2);
            this.Controls.Add(this.btnItems2);
            this.Controls.Add(this.btnCustomers2);
            this.Controls.Add(this.btnReservations2);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.roleText);
            this.Controls.Add(this.welcomeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Dashboard - Baywatch Villas";
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
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnReservations2;
        private System.Windows.Forms.Button btnCustomers2;
        private System.Windows.Forms.Button btnRooms2;
        private System.Windows.Forms.Button btnItems2;
        private System.Windows.Forms.Button btnOrders2;
        private System.Windows.Forms.Button btnStats2;
        private System.Windows.Forms.Button btnEmployees2;
        private System.Windows.Forms.Button btnInvoices2;
    }
}