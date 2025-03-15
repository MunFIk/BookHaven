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
    public partial class Cleark : Form
    {

        string connectionString = @"Data Source=DESKTOP-1GJVH2O;Initial Catalog=BookHaven;Integrated Security=True;TrustServerCertificate=True;";

        public Cleark()
        {
            InitializeComponent();
            LoadBooks();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cleark_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form7 = new Form6();
            form7.Show();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Customer form4 = new Customer();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookManagement book = new BookManagement();
            book.Show();
            this.Hide();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            (dgvBooks.DataSource as DataTable).DefaultView.RowFilter =
        string.Format("Title LIKE '%{0}%'", txtSearchBook.Text);
        }
    }
}
