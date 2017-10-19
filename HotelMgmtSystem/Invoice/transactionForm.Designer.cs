namespace HotelMgmtSystem
{
    partial class transactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.paymentMethod = new System.Windows.Forms.GroupBox();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.rbMaster = new System.Windows.Forms.RadioButton();
            this.cardType = new System.Windows.Forms.GroupBox();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.cardName = new System.Windows.Forms.TextBox();
            this.cardExpDate = new System.Windows.Forms.DateTimePicker();
            this.cardCvv = new System.Windows.Forms.TextBox();
            this.transAmt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentMethod.SuspendLayout();
            this.cardType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Card no.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name on card:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Card Exp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CVV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Charge amount:";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(173, 179);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(102, 37);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Checked = true;
            this.rbCard.Location = new System.Drawing.Point(15, 9);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(47, 17);
            this.rbCard.TabIndex = 11;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(86, 9);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(49, 17);
            this.rbCash.TabIndex = 12;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // paymentMethod
            // 
            this.paymentMethod.Controls.Add(this.rbCash);
            this.paymentMethod.Controls.Add(this.rbCard);
            this.paymentMethod.Location = new System.Drawing.Point(108, 12);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(166, 28);
            this.paymentMethod.TabIndex = 13;
            this.paymentMethod.TabStop = false;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Checked = true;
            this.rbVisa.Location = new System.Drawing.Point(15, 8);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(45, 17);
            this.rbVisa.TabIndex = 14;
            this.rbVisa.TabStop = true;
            this.rbVisa.Text = "Visa";
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.Location = new System.Drawing.Point(86, 8);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(79, 17);
            this.rbMaster.TabIndex = 15;
            this.rbMaster.Text = "MasterCard";
            this.rbMaster.UseVisualStyleBackColor = true;
            // 
            // cardType
            // 
            this.cardType.Controls.Add(this.rbVisa);
            this.cardType.Controls.Add(this.rbMaster);
            this.cardType.Location = new System.Drawing.Point(108, 44);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(166, 28);
            this.cardType.TabIndex = 16;
            this.cardType.TabStop = false;
            // 
            // cardNo
            // 
            this.cardNo.Location = new System.Drawing.Point(108, 88);
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(166, 20);
            this.cardNo.TabIndex = 17;
            // 
            // cardName
            // 
            this.cardName.Location = new System.Drawing.Point(108, 116);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(167, 20);
            this.cardName.TabIndex = 18;
            // 
            // cardExpDate
            // 
            this.cardExpDate.CustomFormat = "MM/yyyy";
            this.cardExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cardExpDate.Location = new System.Drawing.Point(109, 147);
            this.cardExpDate.Name = "cardExpDate";
            this.cardExpDate.Size = new System.Drawing.Size(61, 20);
            this.cardExpDate.TabIndex = 19;
            // 
            // cardCvv
            // 
            this.cardCvv.Location = new System.Drawing.Point(230, 147);
            this.cardCvv.Name = "cardCvv";
            this.cardCvv.Size = new System.Drawing.Size(45, 20);
            this.cardCvv.TabIndex = 20;
            // 
            // transAmt
            // 
            this.transAmt.AutoSize = true;
            this.transAmt.Location = new System.Drawing.Point(108, 191);
            this.transAmt.Name = "transAmt";
            this.transAmt.Size = new System.Drawing.Size(43, 13);
            this.transAmt.TabIndex = 21;
            this.transAmt.Text = "<$100>";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 126);
            this.panel1.TabIndex = 22;
            // 
            // transactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transAmt);
            this.Controls.Add(this.cardCvv);
            this.Controls.Add(this.cardExpDate);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.cardNo);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentMethod);
            this.Controls.Add(this.cardType);
            this.Name = "transactionForm";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.transactionForm_Load);
            this.paymentMethod.ResumeLayout(false);
            this.paymentMethod.PerformLayout();
            this.cardType.ResumeLayout(false);
            this.cardType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.GroupBox paymentMethod;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.RadioButton rbMaster;
        private System.Windows.Forms.GroupBox cardType;
        private System.Windows.Forms.TextBox cardNo;
        private System.Windows.Forms.TextBox cardName;
        private System.Windows.Forms.DateTimePicker cardExpDate;
        private System.Windows.Forms.TextBox cardCvv;
        private System.Windows.Forms.Label transAmt;
        private System.Windows.Forms.Panel panel1;
    }
}