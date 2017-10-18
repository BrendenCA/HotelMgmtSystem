namespace HotelMgmtSystem
{
    partial class roomChooseForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfBeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomType,
            this.roomDesc,
            this.noOfBeds,
            this.roomPrice});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(519, 184);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // roomType
            // 
            this.roomType.HeaderText = "ID";
            this.roomType.Name = "roomType";
            this.roomType.ReadOnly = true;
            this.roomType.Width = 50;
            // 
            // roomDesc
            // 
            this.roomDesc.HeaderText = "Description";
            this.roomDesc.Name = "roomDesc";
            this.roomDesc.ReadOnly = true;
            this.roomDesc.Width = 300;
            // 
            // noOfBeds
            // 
            this.noOfBeds.HeaderText = "Beds";
            this.noOfBeds.Name = "noOfBeds";
            this.noOfBeds.ReadOnly = true;
            this.noOfBeds.Width = 50;
            // 
            // roomPrice
            // 
            this.roomPrice.HeaderText = "Price";
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.ReadOnly = true;
            this.roomPrice.Width = 75;
            // 
            // roomChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 184);
            this.Controls.Add(this.dataGridView);
            this.Name = "roomChooseForm";
            this.Text = "Room Chooser";
            this.Load += new System.EventHandler(this.roomChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfBeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPrice;
    }
}