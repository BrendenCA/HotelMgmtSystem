namespace HotelMgmtSystem
{
    partial class modifyCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.aadharNo = new System.Windows.Forms.TextBox();
            this.mobileNo = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.custId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(333, 201);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(305, 39);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(134, 20);
            this.dob.TabIndex = 24;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(305, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(134, 20);
            this.email.TabIndex = 23;
            // 
            // aadharNo
            // 
            this.aadharNo.Location = new System.Drawing.Point(305, 120);
            this.aadharNo.Name = "aadharNo";
            this.aadharNo.Size = new System.Drawing.Size(134, 20);
            this.aadharNo.TabIndex = 22;
            // 
            // mobileNo
            // 
            this.mobileNo.Location = new System.Drawing.Point(305, 82);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(134, 20);
            this.mobileNo.TabIndex = 21;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(77, 82);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(135, 133);
            this.address.TabIndex = 20;
            this.address.Text = "";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(77, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 20);
            this.name.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Aadhar No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mobile No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Customer ID:";
            // 
            // custId
            // 
            this.custId.Location = new System.Drawing.Point(77, 10);
            this.custId.Name = "custId";
            this.custId.Size = new System.Drawing.Size(134, 20);
            this.custId.TabIndex = 27;
            this.custId.TextChanged += new System.EventHandler(this.custId_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(232, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(476, 198);
            this.panel.TabIndex = 29;
            // 
            // modifyCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.custId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.email);
            this.Controls.Add(this.aadharNo);
            this.Controls.Add(this.mobileNo);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modifyCustomers";
            this.Size = new System.Drawing.Size(476, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox aadharNo;
        private System.Windows.Forms.TextBox mobileNo;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox custId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel;
    }
}
