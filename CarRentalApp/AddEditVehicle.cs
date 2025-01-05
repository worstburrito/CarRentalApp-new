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
    public partial class AddEditVehicle : Form
    {
        private readonly CarRentalEntities _db;
        private ManageVehicleListing _manageVehicleListing;
        private bool isEditMode;

        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblAddEditVehicle.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypeOfCar carToEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblAddEditVehicle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            isEditMode = true;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
            PopulateFields(carToEdit);
        }

        private void PopulateFields(TypeOfCar car)
        {
            lblId.Text = car.Id.ToString();
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtVIN.Text = car.VIN;
            txtYear.Text = car.Year.ToString();
            txtPlate.Text = car.LicensePlateNumber;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var message = String.Empty;
                // Input Validation
                if (string.IsNullOrWhiteSpace(txtMake.Text) ||
                    string.IsNullOrWhiteSpace(txtModel.Text) ||
                    string.IsNullOrWhiteSpace(txtYear.Text))
                {
                    MessageBox.Show("Error: Make, Model, and Year are required to save.",
                                    "Input Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return; // Stop further execution
                }

                if (isEditMode)
                {
                    // Edit Code Here
                    var id = int.Parse(lblId.Text);
                    var car = _db.TypeOfCars.FirstOrDefault(q => q.Id == id);

                    if (car != null)
                    {
                        car.Make = txtMake.Text;
                        car.Model = txtModel.Text;
                        car.VIN = txtVIN.Text;
                        car.Year = int.Parse(txtYear.Text);
                        car.LicensePlateNumber = txtPlate.Text;


                        message = "Vehicle has been successfully updated!";

                    }
                    else
                    {
                        MessageBox.Show("Vehicle not found. Please refresh and try again.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Add Code Here
                    var newCar = new TypeOfCar
                    {
                        Make = txtMake.Text,
                        Model = txtModel.Text,
                        VIN = txtVIN.Text,
                        Year = int.Parse(txtYear.Text),
                        LicensePlateNumber = txtPlate.Text,
                    };

                    message = "Vehicle has been successfully added!";

                    _db.TypeOfCars.Add(newCar);
                    

                    
                }
                
                _db.SaveChanges();
                _manageVehicleListing.PopulateGrid();
                MessageBox.Show($"{message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show($"An error occurred: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
