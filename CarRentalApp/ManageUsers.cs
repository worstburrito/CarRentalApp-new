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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "AddUser");

            if (!isOpen)
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }
            
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvManageUsers.SelectedRows.Count > 0)
                {
                    // Get ID of selected row
                    var id = (int)dgvManageUsers.SelectedRows[0].Cells["id"].Value;

                    // Query database for the record
                    var user = _db.Users.FirstOrDefault(q => q.id == id);

                    var hashed_password = Utils.DefaultHashPassword();
                    user.password = hashed_password;
                    _db.SaveChanges();

                    MessageBox.Show($"{user.username}'s password has been reset!",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    PopulateGrid();
                }
                else
                {
                    MessageBox.Show($"Please select a row to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvManageUsers.SelectedRows.Count > 0)
                {
                    // Get ID of selected row
                    var id = (int)dgvManageUsers.SelectedRows[0].Cells["id"].Value;

                    // Query database for the record
                    var user = _db.Users.FirstOrDefault(q => q.id == id);
                    user.isActive = false;
                    _db.SaveChanges();

                    MessageBox.Show($"{user.username}'s has been set to inactive.",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    PopulateGrid();
                }
                else
                {
                    MessageBox.Show($"Please select a row to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnActivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvManageUsers.SelectedRows.Count > 0)
                {
                    // Get ID of selected row
                    var id = (int)dgvManageUsers.SelectedRows[0].Cells["id"].Value;

                    // Query database for the record
                    var user = _db.Users.FirstOrDefault(q => q.id == id);
                    user.isActive = true;
                    _db.SaveChanges();

                    MessageBox.Show($"{user.username}'s has been set to active.",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    PopulateGrid();
                } 
                else
                {
                    MessageBox.Show($"Please select a row to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
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
            var records = _db.Users.Select(q => new
            {
                q.id,
                q.username,
                q.UserRoles.FirstOrDefault().Role.name,
                q.isActive,

            })
            .ToList();

            dgvManageUsers.DataSource = records;
            dgvManageUsers.Columns["id"].Visible = false;
            dgvManageUsers.Columns["username"].HeaderText = "Username";
            dgvManageUsers.Columns["name"].HeaderText = "Role Name";
            dgvManageUsers.Columns["isActive"].HeaderText = "Active Status";

        }
    }
}
