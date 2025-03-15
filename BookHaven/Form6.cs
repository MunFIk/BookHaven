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
    public partial class Form6 : Form
    {
        string connectionString = @"Data Source=DESKTOP-1GJVH2O;Initial Catalog=BookHaven;Integrated Security=True;TrustServerCertificate=True;";
        private decimal totalAmount = 0;

        public Form6()
        {
            InitializeComponent();
            LoadCustomers();
            LoadBooks();
            if (LoggedInUserDetails.UserRole == "Clerk")
            {
                btnADash.Visible = false;
                btnBook.Visible = false;
                btnReport.Visible = false;
                btnSale.Visible = false;
                btnSupplier.Visible = false;
                btnOrder.Visible = false;
                btnCus.Visible = false;
                btnBack.Visible = true;

            }
            else
            {
                btnADash.Visible = true;
                btnBook.Visible = true;
                btnReport.Visible = true;
                btnSale.Visible = true;
                btnSupplier.Visible = true;
                btnOrder.Visible = true;
                btnCus.Visible = true;
                btnBack.Visible = false;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustomerID, FullName FROM Customers";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCus.DataSource = dt;
                        cmbCus.DisplayMember = "FullName";
                        cmbCus.ValueMember = "CustomerID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 2️⃣ Load Books into ComboBox
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BookID, Title, Author, Price, Stock FROM Books";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbBook.DataSource = dt;
                        cmbBook.DisplayMember = "Title";
                        cmbBook.ValueMember = "BookID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBook.SelectedValue != null)
            {
                DataRowView drv = (DataRowView)cmbBook.SelectedItem;
                lblAutor.Text = drv["Author"].ToString();
                lblPrice.Text = drv["Price"].ToString();
                lblQty.Text = drv["Stock"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBook.SelectedValue == null || string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Please select a book and enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stock = int.Parse(lblQty.Text);
            if (quantity > stock)
            {
                MessageBox.Show("Not enough stock available!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = decimal.Parse(lblPrice.Text);
            decimal totalPrice = price * quantity;
            totalAmount += totalPrice;

            // ✅ Ensure dgvCart has a "BookID" column
            dgvCart.Rows.Add(cmbBook.SelectedValue, cmbCus.Text, cmbBook.Text, txtQty.Text, lblAutor.Text, lblPrice.Text, lblQty.Text, totalAmount);
            dgvCart.Refresh();

            lblTotal.Text = totalAmount.ToString("F2");

            txtQty.Clear();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal discount = 0;
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text) && decimal.TryParse(txtDiscount.Text, out discount))
            {
                if (discount < 0 || discount > totalAmount)
                {
                    MessageBox.Show("Invalid discount amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Clear();
                    return;
                }
            }

            decimal subtotal = totalAmount - discount;
            txtSub.Text = subtotal.ToString("F2");
        }

        private void button13_Click(object sender, EventArgs e)
        {
                if (cmbCus.SelectedValue == null || dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Please select a customer and add books to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal discount = string.IsNullOrWhiteSpace(txtDiscount.Text) ? 0 : decimal.Parse(txtDiscount.Text);
            decimal subtotal = totalAmount - discount;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction(); // ✅ Start Transaction

                    try
                    {
                        // 1️⃣ Insert into Sales Table
                        string querySale = @"
                    INSERT INTO Sales (CustomerID, TotalAmount, Discount, SubTotal, SaleDate) 
                    VALUES (@CustomerID, @TotalAmount, @Discount, @SubTotal, GETDATE()); 
                    SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdSale = new SqlCommand(querySale, conn, transaction);
                        cmdSale.Parameters.AddWithValue("@CustomerID", cmbCus.SelectedValue);
                        cmdSale.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmdSale.Parameters.AddWithValue("@Discount", discount);
                        cmdSale.Parameters.AddWithValue("@SubTotal", subtotal);

                        int saleID = Convert.ToInt32(cmdSale.ExecuteScalar()); // Get SaleID

                        // 2️⃣ Insert SaleDetails & Update Stock
                        StringBuilder orderPreview = new StringBuilder();
                        orderPreview.AppendLine($"Order ID: {saleID}");
                        orderPreview.AppendLine($"Customer ID: {cmbCus.SelectedValue}");
                        orderPreview.AppendLine($"-----------------------------------");
                        orderPreview.AppendLine($"Book ID\tQty");

                        foreach (DataGridViewRow row in dgvCart.Rows)
                        {
                            if (row.IsNewRow || row.Cells["ID"].Value == null || row.Cells["ID"].Value == DBNull.Value)
                            {
                                continue; // Skip this row
                            }

                            int bookID = Convert.ToInt32(row.Cells["ID"].Value);
                            int quantity = Convert.ToInt32(row.Cells["Qty"].Value);

                            // Insert into SaleDetails
                            string querySaleDetails = "INSERT INTO SaleDetails (SaleID, BookID, Quantity) VALUES (@SaleID, @BookID, @Quantity)";
                            using (SqlCommand cmdSaleDetails = new SqlCommand(querySaleDetails, conn, transaction))
                            {
                                cmdSaleDetails.Parameters.AddWithValue("@SaleID", saleID);
                                cmdSaleDetails.Parameters.AddWithValue("@BookID", bookID);
                                cmdSaleDetails.Parameters.AddWithValue("@Quantity", quantity);
                                cmdSaleDetails.ExecuteNonQuery();
                            }

                            // Update Book Stock
                            string queryUpdateStock = "UPDATE Books SET Stock = Stock - @Quantity WHERE BookID = @BookID";
                            using (SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, conn, transaction))
                            {
                                cmdUpdateStock.Parameters.AddWithValue("@Quantity", quantity);
                                cmdUpdateStock.Parameters.AddWithValue("@BookID", bookID);
                                cmdUpdateStock.ExecuteNonQuery();
                            }

                            // Add to order preview
                            orderPreview.AppendLine($"{bookID}\t{quantity}");
                        }

                        transaction.Commit(); // ✅ Commit Transaction
                                              // MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3️⃣ Show Order Preview
                        orderPreview.AppendLine($"-----------------------------------");
                        orderPreview.AppendLine($"Total: {totalAmount:C}");
                        orderPreview.AppendLine($"Discount: {discount:C}");
                        orderPreview.AppendLine($"Subtotal: {subtotal:C}");

                        MessageBox.Show(orderPreview.ToString(), "Order Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4️⃣ Reset Form
                        dgvCart.Rows.Clear();
                        totalAmount = 0;
                        lblTotal.Text = "0.00";
                        txtDiscount.Clear();
                        txtSub.Text = "0.00";
                        cmbBook.SelectedIndex = 0;
                        cmbCus.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // ❌ Rollback in case of error
                        MessageBox.Show("Error saving sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form7 = new Form6();
            form7.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
    }
}


