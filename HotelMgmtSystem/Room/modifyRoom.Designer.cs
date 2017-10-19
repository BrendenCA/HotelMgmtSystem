namespace HotelMgmtSystem
{
    partial class modifyRoom
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
            this.roomTotal = new System.Windows.Forms.TextBox();
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.roomDesc = new System.Windows.Forms.RichTextBox();
            this.noOfBeds = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.noOfBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 146);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // roomTotal
            // 
            this.roomTotal.Location = new System.Drawing.Point(80, 148);
            this.roomTotal.Name = "roomTotal";
            this.roomTotal.Size = new System.Drawing.Size(119, 20);
            this.roomTotal.TabIndex = 16;
            // 
            // roomPrice
            // 
            this.roomPrice.Location = new System.Drawing.Point(79, 119);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(120, 20);
            this.roomPrice.TabIndex = 15;
            // 
            // roomDesc
            // 
            this.roomDesc.Location = new System.Drawing.Point(79, 64);
            this.roomDesc.Name = "roomDesc";
            this.roomDesc.Size = new System.Drawing.Size(120, 49);
            this.roomDesc.TabIndex = 14;
            this.roomDesc.Text = "";
            // 
            // noOfBeds
            // 
            this.noOfBeds.Location = new System.Drawing.Point(79, 37);
            this.noOfBeds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noOfBeds.Name = "noOfBeds";
            this.noOfBeds.Size = new System.Drawing.Size(120, 20);
            this.noOfBeds.TabIndex = 13;
            this.noOfBeds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "No. of rooms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "No. of beds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Room ID:";
            // 
            // roomType
            // 
            this.roomType.Location = new System.Drawing.Point(80, 8);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(119, 20);
            this.roomType.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(214, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 34);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(297, 144);
            this.panel.TabIndex = 22;
            // 
            // modifyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.roomTotal);
            this.Controls.Add(this.roomPrice);
            this.Controls.Add(this.roomDesc);
            this.Controls.Add(this.noOfBeds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modifyRoom";
            this.Size = new System.Drawing.Size(297, 178);
            ((System.ComponentModel.ISupportInitialize)(this.noOfBeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox roomTotal;
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.RichTextBox roomDesc;
        private System.Windows.Forms.NumericUpDown noOfBeds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel;
    }
}
