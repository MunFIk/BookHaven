using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookHaven
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text.Trim();
            string password = txtPW.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-1GJVH2O;Initial Catalog=BookHaven;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string role = result.ToString();
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide(); 

                            if (role == "Admin")
                            {
                                Admin adminForm = new Admin();
                                adminForm.Show();
                            }
                            else if (role == "Clerk") 
                            {
                                Cleark clerkForm = new Cleark();
                                clerkForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}