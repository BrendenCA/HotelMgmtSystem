namespace HotelMgmtSystem
{
    partial class addRoom
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noOfBeds = new System.Windows.Forms.NumericUpDown();
            this.roomDesc = new System.Windows.Forms.RichTextBox();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.roomTotal = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noOfBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. of beds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. of rooms:";
            // 
            // noOfBeds
            // 
            this.noOfBeds.Location = new System.Drawing.Point(87, 17);
            this.noOfBeds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noOfBeds.Name = "noOfBeds";
            this.noOfBeds.Size = new System.Drawing.Size(120, 20);
            this.noOfBeds.TabIndex = 4;
            this.noOfBeds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roomDesc
            // 
            this.roomDesc.Location = new System.Drawing.Point(87, 44);
            this.roomDesc.Name = "roomDesc";
            this.roomDesc.Size = new System.Drawing.Size(120, 61);
            this.roomDesc.TabIndex = 5;
            this.roomDesc.Text = "";
            // 
            // roomPrice
            // 
            this.roomPrice.Location = new System.Drawing.Point(86, 111);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(120, 20);
            this.roomPrice.TabIndex = 6;
            // 
            // roomTotal
            // 
            this.roomTotal.Location = new System.Drawing.Point(87, 140);
            this.roomTotal.Name = "roomTotal";
            this.roomTotal.Size = new System.Drawing.Size(119, 20);
            this.roomTotal.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(228, 138);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // addRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.roomTotal);
            this.Controls.Add(this.roomPrice);
            this.Controls.Add(this.roomDesc);
            this.Controls.Add(this.noOfBeds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addRoom";
            this.Size = new System.Drawing.Size(297, 178);
            ((System.ComponentModel.ISupportInitialize)(this.noOfBeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown noOfBeds;
        private System.Windows.Forms.RichTextBox roomDesc;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.TextBox roomTotal;
        private System.Windows.Forms.Button btnSubmit;
    }
}
