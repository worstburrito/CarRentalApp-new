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
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities _db;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            _user = user;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var password = txtNewPassword.Text;
                var confirm_password = txtConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.id == _user.id);

                if (password == confirm_password)
                {
                    user.password = Utils.HashPassword(password);
                    _db.SaveChanges();
                    MessageBox.Show($"Your password has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show($"Password fields do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
