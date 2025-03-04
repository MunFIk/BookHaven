using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BCrypt.Net;


namespace BookHaven
{
    public partial class Form7 : Form
    {
        string connectionString = @"Data Source=DESKTOP-1GJVH2O;Initial Catalog=BookHaven;Integrated Security=True;TrustServerCertificate=True;";

        public Form7()
        {
            InitializeComponent();
            LoadClerks(); // Load clerks when the form opens

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtFname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUname.Text) ||
                string.IsNullOrWhiteSpace(txtPw.Text))
            {
                MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the password before saving
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPw.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (FullName, Email, Username, Password, Role) VALUES (@FullName, @Email, @Username, @Password, @Role)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFname.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUname.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPw.Text);
                        cmd.Parameters.AddWithValue("@Role", "Clerk"); // Role is always "Clerk"

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Clerk registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after successful registration
                txtFname.Clear();
                txtEmail.Clear();
                txtUname.Clear();
                txtPw.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering clerk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void LoadClerks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserID, FullName, Email, Username FROM Users WHERE Role = 'Clerk'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvClerks.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clerks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblClerk.Text))
            {
                MessageBox.Show("Please select a clerk to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET FullName = @FullName, Email = @Email, Username = @Username WHERE UserID = @UserID AND Role = 'Clerk'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFname.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUname.Text);
                        cmd.Parameters.AddWithValue("@UserID", int.Parse(lblClerk.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Clerk details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadClerks(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Ensure the role is 'Clerk'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating clerk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClerks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dgvClerks.Rows[e.RowIndex];

                // Assign selected row values to textboxes
                lblClerk.Text = row.Cells["UserID"].Value.ToString();
                txtFname.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtUname.Text = row.Cells["Username"].Value.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblClerk.Text))
            {
                MessageBox.Show("Please select a clerk to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this clerk?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Users WHERE UserID = @UserID AND Role = 'Clerk'";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", int.Parse(lblClerk.Text));

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Clerk deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadClerks(); // Refresh DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Deletion failed. Ensure the role is 'Clerk'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            lblClerk.Text = "";
                            txtFname.Text = "";
                            txtEmail.Text = string.Empty;
                            txtUname.Text = string.Empty;
                            txtPw.Text = string.Empty;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting clerk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            lblClerk.Text = "";
            txtFname.Text = "";
            txtEmail.Text = string.Empty;
            txtUname.Text = string.Empty;
            txtPw.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adamin = new Admin();
            adamin.Show();
            this.Hide();
        }
    }
}
    
