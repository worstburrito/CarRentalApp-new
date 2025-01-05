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
    public partial class AddEditRentalRecord : Form
    {
        private readonly CarRentalEntities _db;
        private ManageRentalRecords _manageRentalRecords;
        private bool isEditMode;
        string message = String.Empty;
        public AddEditRentalRecord(ManageRentalRecords manageRentalRecords = null)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            lblAddEditRecord.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            isEditMode = false;
            _manageRentalRecords = manageRentalRecords;
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit, ManageRentalRecords manageRentalRecords = null)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            lblAddEditRecord.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            isEditMode = true;
            _manageRentalRecords = manageRentalRecords;
            PopulateFields(recordToEdit);
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            txtCustomerName.Text = recordToEdit.CustomerName;
            dtDateRented.Value = (DateTime)recordToEdit.DateRented;
            dtDateReturned.Value = (DateTime)recordToEdit.DateReturned;
            txtTotalCost.Text = recordToEdit.Cost.ToString();
            lblId.Text = recordToEdit.id.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var customerName = txtCustomerName.Text;
                var dateOut = dtDateRented.Value;
                var dateIn = dtDateReturned.Value;
                var carType = comboTypeOfCar.Text;
                var cost = Convert.ToDouble(txtTotalCost.Text);
                var isValid = true;
                var errorMsg = string.Empty;

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMsg += "Error: Please enter missing data.\n\r";
                } 

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMsg += "Error: Invalid date selection.\n\r";
                }

                if (isValid)
                {
                    // Declare an object of the record to be added
                    var rentalRecord = new CarRentalRecord();

                    // if is in edit mode, get the ID and the matching record and place in object
                    if (isEditMode)
                    {
                        
                        var id = int.Parse(lblId.Text);
                        rentalRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                        message = $"RECORD HAS BEEN SAVED.\n\r" +
                            $"Customer name: {customerName}\n\r" +
                            $"Date Rented: {dateOut}\n\r" +
                            $"Date Returned: {dateIn}\n\r" +
                            $"Car Type: {carType}\n\r" +
                            $"Cost: {cost:C}";

                    }

                    // Populate record object with values
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)comboTypeOfCar.SelectedValue;

                    // if not in edit mode, add the record object to the database
                    if (!isEditMode)
                    {
                        
                        _db.CarRentalRecords.Add(rentalRecord);

                        message = $"Customer name: {customerName}\n\r" +
                            $"Date Rented: {dateOut}\n\r" +
                            $"Date Returned: {dateIn}\n\r" +
                            $"Car Type: {carType}\n\r" +
                            $"Cost: {cost:C}\n\r" +
                            $"THANK YOU FOR YOUR BUSINESS!";
                        
                    }

                    // Save changes, serve message, close window.
                    _db.SaveChanges();
                    _manageRentalRecords.PopulateGrid();
                    MessageBox.Show($"{message}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"An error occurred: {errorMsg}",
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
                //throw;
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = _db.TypeOfCars
                .Select(q => new { 
                    Id = q.Id, 
                    Name = q.Make + " " + q.Model 
                })
                .ToList();
            comboTypeOfCar.DisplayMember = "Name";
            comboTypeOfCar.ValueMember = "Id";
            comboTypeOfCar.DataSource = cars;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
