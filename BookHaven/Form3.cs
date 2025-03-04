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

namespace BookHaven
{
    public partial class BookManagement : Form
    {
        string connectionString = @"Data Source=DESKTOP-1GJVH2O;Initial Catalog=BookHaven;Integrated Security=True;TrustServerCertificate=True;";

        public BookManagement()
        {
            InitializeComponent();
            LoadSuppliers();
            ClearFields();
            LoadBooks();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) || cmbSupp.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Books (Title, Author, Genre, ISBN, Price, Stock, SupplierID) " +
                                   "VALUES (@Title, @Author, @Genre, @ISBN, @Price, @Stock, @SupplierID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                        cmd.Parameters.AddWithValue("@Genre", txtGen.Text);
                        cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@SupplierID", cmbSupp.SelectedValue); // Get SupplierID

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks(); // Refresh the DataGridView
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void cmbSupp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName FROM Suppliers";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbSupp.DataSource = dt;
                        cmbSupp.DisplayMember = "SupplierName";  // Show supplier name in ComboBox
                        cmbSupp.ValueMember = "SupplierID";  // Store SupplierID internally
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            lblBID.Text = "";
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGen.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cmbSupp.SelectedIndex = -1; // Reset selection
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Books.BookID, Books.Title, Books.Author, Books.Genre, Books.ISBN, " +
                                   "Books.Price, Books.Stock, Suppliers.SupplierName " +
                                   "FROM Books " +
                                   "INNER JOIN Suppliers ON Books.SupplierID = Suppliers.SupplierID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvBooks.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is clicked
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                lblBID.Text = row.Cells["BookID"].Value.ToString(); // Hidden in UI
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtGen.Text = row.Cells["Genre"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                cmbSupp.Text = row.Cells["SupplierName"].Value.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBID.Text))
            {
                MessageBox.Show("Please select a book to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Books SET Title = @Title, Author = @Author, Genre = @Genre, ISBN = @ISBN, " +
                                   "Price = @Price, Stock = @Stock, SupplierID = (SELECT SupplierID FROM Suppliers WHERE SupplierName = @SupplierName) " +
                                   "WHERE BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", lblBID.Text);
                        cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                        cmd.Parameters.AddWithValue("@Genre", txtGen.Text);
                        cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@SupplierName", cmbSupp.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks(); // Refresh Grid
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBID.Text))
            {
                MessageBox.Show("Please select a book to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Books WHERE BookID = @BookID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookID", lblBID.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBooks(); // Refresh Grid

                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form7 = new Form6();
            form7.Show();
            this.Close();
        }
    }
}
