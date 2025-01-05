namespace CarRentalApp
{
    partial class AddEditVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddEditVehicle = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.74963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.25037F));
            this.tableLayoutPanel1.Controls.Add(this.lblMake, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblModel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVIN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMake, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPlate, 1, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveChanges.Location = new System.Drawing.Point(12, 319);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(238, 38);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(399, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddEditVehicle
            // 
            this.lblAddEditVehicle.AutoSize = true;
            this.lblAddEditVehicle.Font = new System.Drawing.Font("Ravie", 16F);
            this.lblAddEditVehicle.Location = new System.Drawing.Point(12, 9);
            this.lblAddEditVehicle.Name = "lblAddEditVehicle";
            this.lblAddEditVehicle.Size = new System.Drawing.Size(261, 31);
            this.lblAddEditVehicle.TabIndex = 3;
            this.lblAddEditVehicle.Text = "Placeholder Text";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(3, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(48, 20);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(3, 51);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(3, 102);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(36, 20);
            this.lblVIN.TabIndex = 2;
            this.lblVIN.Text = "VIN";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(3, 153);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(3, 204);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(104, 20);
            this.lblPlate.TabIndex = 4;
            this.lblPlate.Text = "License Plate";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(188, 3);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(385, 26);
            this.txtMake.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(188, 54);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(385, 26);
            this.txtModel.TabIndex = 6;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(188, 105);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(385, 26);
            this.txtVIN.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(188, 156);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(385, 26);
            this.txtYear.TabIndex = 8;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(188, 207);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(385, 26);
            this.txtPlate.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(553, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAddEditVehicle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddEditVehicle;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblId;
    }
}