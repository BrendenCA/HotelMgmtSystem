namespace HotelMgmtSystem
{
    partial class receipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceId = new System.Windows.Forms.Label();
            this.invoiceStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.invoiceTransId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.invoiceAmt = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice ID: ";
            // 
            // invoiceId
            // 
            this.invoiceId.AutoSize = true;
            this.invoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceId.Location = new System.Drawing.Point(122, 95);
            this.invoiceId.Name = "invoiceId";
            this.invoiceId.Size = new System.Drawing.Size(63, 20);
            this.invoiceId.TabIndex = 1;
            this.invoiceId.Text = "<invID>";
            // 
            // invoiceStatus
            // 
            this.invoiceStatus.AutoSize = true;
            this.invoiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceStatus.Location = new System.Drawing.Point(364, 349);
            this.invoiceStatus.Name = "invoiceStatus";
            this.invoiceStatus.Size = new System.Drawing.Size(71, 20);
            this.invoiceStatus.TabIndex = 3;
            this.invoiceStatus.Text = "<status>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status: ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(126, 59);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(59, 20);
            this.date.TabIndex = 5;
            this.date.Text = "<date>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date:";
            // 
            // invoiceTransId
            // 
            this.invoiceTransId.AutoSize = true;
            this.invoiceTransId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTransId.Location = new System.Drawing.Point(478, 95);
            this.invoiceTransId.Name = "invoiceTransId";
            this.invoiceTransId.Size = new System.Drawing.Size(80, 20);
            this.invoiceTransId.TabIndex = 7;
            this.invoiceTransId.Text = "<transID>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Transaction ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hotel Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(544, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(544, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "------------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(298, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total:";
            // 
            // invoiceAmt
            // 
            this.invoiceAmt.AutoSize = true;
            this.invoiceAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceAmt.Location = new System.Drawing.Point(364, 317);
            this.invoiceAmt.Name = "invoiceAmt";
            this.invoiceAmt.Size = new System.Drawing.Size(102, 20);
            this.invoiceAmt.TabIndex = 14;
            this.invoiceAmt.Text = "<totalCost>";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDesc,
            this.itemPrice});
            this.dataGridView.Location = new System.Drawing.Point(109, 154);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(345, 148);
            this.dataGridView.TabIndex = 15;
            // 
            // itemDesc
            // 
            this.itemDesc.HeaderText = "Description";
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.ReadOnly = true;
            this.itemDesc.Width = 200;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // resId
            // 
            this.resId.AutoSize = true;
            this.resId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resId.Location = new System.Drawing.Point(478, 59);
            this.resId.Name = "resId";
            this.resId.Size = new System.Drawing.Size(66, 20);
            this.resId.TabIndex = 17;
            this.resId.Text = "<resID>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Reservation ID:";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(496, 317);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(82, 56);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.resId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.invoiceAmt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.invoiceTransId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invoiceStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invoiceId);
            this.Controls.Add(this.label1);
            this.Name = "receipt";
            this.Size = new System.Drawing.Size(602, 380);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label invoiceId;
        private System.Windows.Forms.Label invoiceStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label invoiceTransId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label invoiceAmt;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.Label resId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPay;
    }
}