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
    public partial class MainWindow : Form
    {
        // Need to add function to Utils to check for open windows.

        private Login _login;
        public string _roleName;
        public User _user;
        public MainWindow(Login login)
        {
            InitializeComponent();
        }

        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }


        private void viewAllVehicleListings_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");

            if (!isOpen)
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }
        }

        private void viewAllRecords_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageRentalRecords");

            if (!isOpen)
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "AddEditRentalRecord");

            if (!isOpen)
            {
                AddEditRentalRecord addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this;
                addRentalRecord.Show();
            }
        }

        private void addVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "AddEditVehicle");

            if (!isOpen)
            {
                AddEditVehicle addEditVehicle = new AddEditVehicle();
                addEditVehicle.MdiParent = this;
                addEditVehicle.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void tlsManageUsers_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageUsers");

            if (!isOpen)
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }

            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }
            
            var username = _user.username;
            mainStatusLabel.Text = $"Logged in as: {username}";

            if (_roleName != "admin")
            {
                tlsManageUsers.Visible = false;
            }
        }
    }
}
