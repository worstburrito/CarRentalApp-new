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
    public partial class AddUser : Form
    {
        private readonly CarRentalEntities _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cboRole.DataSource = roles;
            cboRole.ValueMember = "id";
            cboRole.DisplayMember = "name";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text;
                var roleId = (int)cboRole.SelectedValue;
                var password = Utils.DefaultHashPassword();
                var user = new User
                {
                    username = username,
                    password = password,
                    isActive = true,
                };

                _db.Users.Add(user);
                _db.SaveChanges();

                var userid = user.id;

                var userRole = new UserRole
                {
                    roleid = roleId,
                    userid = userid
                };

                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                _manageUsers.PopulateGrid();
                MessageBox.Show($"{user.username} has been created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
