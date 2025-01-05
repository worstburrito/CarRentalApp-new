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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
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


        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

            if (dgvManageVehicleListing.SelectedRows.Count > 0)
            {
                // get ID of selected row
                var id = (int)dgvManageVehicleListing.SelectedRows[0].Cells["Id"].Value;

                // query database for record
                var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                // launch AddEditVehicle window with data
                var addEditVehicle = new AddEditVehicle(car, this);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to proceed.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
            }
            

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvManageVehicleListing.SelectedRows.Count > 0)
                {
                    // Get ID of selected row
                    var id = (int)dgvManageVehicleListing.SelectedRows[0].Cells["Id"].Value;

                    // Query database for the record
                    var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                    if (car != null)
                    {
                        // Show confirmation dialog
                        var result = MessageBox.Show("Are you sure you want to delete this vehicle?",
                                                     "Delete Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                        // Check user's response
                        if (result == DialogResult.Yes)
                        {
                            // Delete vehicle from the database
                            _db.TypeOfCars.Remove(car);
                            _db.SaveChanges();

                            // Notify user of successful deletion
                            MessageBox.Show("Vehicle has been successfully deleted.",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected vehicle could not be found. Please refresh and try again.",
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

        public void PopulateGrid()
        {
            var cars = _db.TypeOfCars
               .Select(q => new {
                   q.Make,
                   q.Model,
                   q.VIN,
                   q.LicensePlateNumber,
                   q.Year,
                   q.Id,
               })
               .ToList();

            dgvManageVehicleListing.DataSource = cars;
            dgvManageVehicleListing.Columns[0].HeaderText = "MAKE";
            dgvManageVehicleListing.Columns[1].HeaderText = "MODEL";
            dgvManageVehicleListing.Columns[2].HeaderText = "VIN";
            dgvManageVehicleListing.Columns[3].HeaderText = "PLATE";
            dgvManageVehicleListing.Columns[4].HeaderText = "YEAR";
            dgvManageVehicleListing.Columns[5].Visible = false;
        }
    }
}
