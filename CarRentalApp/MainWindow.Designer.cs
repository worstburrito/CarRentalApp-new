namespace CarRentalApp
{
    partial class MainWindow
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.manageVehicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllVehicleListings = new System.Windows.Forms.ToolStripMenuItem();
            this.addVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehicleListingToolStripMenuItem,
            this.manageRentalRecordsToolStripMenuItem,
            this.tlsManageUsers});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(984, 29);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // manageVehicleListingToolStripMenuItem
            // 
            this.manageVehicleListingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllVehicleListings,
            this.addVToolStripMenuItem});
            this.manageVehicleListingToolStripMenuItem.Name = "manageVehicleListingToolStripMenuItem";
            this.manageVehicleListingToolStripMenuItem.Size = new System.Drawing.Size(181, 25);
            this.manageVehicleListingToolStripMenuItem.Text = "Manage Vehicle Listing";
            // 
            // viewAllVehicleListings
            // 
            this.viewAllVehicleListings.Name = "viewAllVehicleListings";
            this.viewAllVehicleListings.Size = new System.Drawing.Size(196, 26);
            this.viewAllVehicleListings.Text = "View All Records";
            this.viewAllVehicleListings.Click += new System.EventHandler(this.viewAllVehicleListings_Click);
            // 
            // addVToolStripMenuItem
            // 
            this.addVToolStripMenuItem.Name = "addVToolStripMenuItem";
            this.addVToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.addVToolStripMenuItem.Text = "Add Vehicle";
            this.addVToolStripMenuItem.Click += new System.EventHandler(this.addVToolStripMenuItem_Click);
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            this.manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllRecords,
            this.addRentalRecordToolStripMenuItem});
            this.manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            this.manageRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(186, 25);
            this.manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // viewAllRecords
            // 
            this.viewAllRecords.Name = "viewAllRecords";
            this.viewAllRecords.Size = new System.Drawing.Size(209, 26);
            this.viewAllRecords.Text = "View All Records";
            this.viewAllRecords.Click += new System.EventHandler(this.viewAllRecords_Click);
            // 
            // addRentalRecordToolStripMenuItem
            // 
            this.addRentalRecordToolStripMenuItem.Name = "addRentalRecordToolStripMenuItem";
            this.addRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.addRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            this.addRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.addRentalRecordToolStripMenuItem_Click);
            // 
            // tlsManageUsers
            // 
            this.tlsManageUsers.Name = "tlsManageUsers";
            this.tlsManageUsers.Size = new System.Drawing.Size(121, 25);
            this.tlsManageUsers.Text = "Manage Users";
            this.tlsManageUsers.Click += new System.EventHandler(this.tlsManageUsers_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel});
            this.mainStatus.Location = new System.Drawing.Point(0, 639);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(984, 22);
            this.mainStatus.TabIndex = 2;
            this.mainStatus.Text = "statusStrip1";
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(93, 17);
            this.mainStatusLabel.Text = "Placeholder Text";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Pracht Family Rentals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllRecords;
        private System.Windows.Forms.ToolStripMenuItem viewAllVehicleListings;
        private System.Windows.Forms.ToolStripMenuItem addVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsManageUsers;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
    }
}