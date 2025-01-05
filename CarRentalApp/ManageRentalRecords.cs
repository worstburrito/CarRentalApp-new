using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addRentalRecord = new AddEditRentalRecord(this);
            addRentalRecord.MdiParent = this.MdiParent;
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            if (dgvManageRentalRecords.SelectedRows.Count > 0)
            {
                // get ID of selected row
                var id = (int)dgvManageRentalRecords.SelectedRows[0].Cells["Id"].Value;

                // query database for record
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                // launch AddEditVehicle window with data
                var addEditRentalRecord = new AddEditRentalRecord(record, this);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.Show();
            }

            else
            {
                MessageBox.Show("Please select a row to proceed.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvManageRentalRecords.SelectedRows.Count > 0)
                {
                    // Get ID of selected row
                    var id = (int)dgvManageRentalRecords.SelectedRows[0].Cells["Id"].Value;

                    // Query database for the record
                    var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                    if (record != null)
                    {
                        // Show confirmation dialog
                        var result = MessageBox.Show("Are you sure you want to delete this record?",
                                                     "Delete Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        // Check user's response
                        if (result == DialogResult.Yes)
                        {
                            // Delete record from the database
                            _db.CarRentalRecords.Remove(record);
                            _db.SaveChanges();

                            // Notify user of successful deletion
                            MessageBox.Show("Record has been successfully deleted.",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected record could not be found. Please refresh and try again.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to proceed.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void PopulateGrid()
        {
            var records = _db.CarRentalRecords.Select(q => new 
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model
            })
            .ToList();

            dgvManageRentalRecords.DataSource = records;
            dgvManageRentalRecords.Columns["Customer"].HeaderText = "NAME";
            dgvManageRentalRecords.Columns["DateOut"].HeaderText = "RENTAL DATE";
            dgvManageRentalRecords.Columns["DateIn"].HeaderText = "RETURN DATE";
            dgvManageRentalRecords.Columns["Id"].Visible = false;
            dgvManageRentalRecords.Columns["Cost"].HeaderText = "RENTAL COST";
            dgvManageRentalRecords.Columns["Car"].HeaderText = "MAKE AND MODEL";

        }
    }
}
