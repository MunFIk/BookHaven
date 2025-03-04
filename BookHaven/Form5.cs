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
    public partial class Supplier : Form
    {
        string connectionString = @"Data Source=DESKTOP-1GJVH2O;Initial Catalog=BookHaven;Integrated Security=True;TrustServerCertificate=True;";

        public Supplier()
        {
            InitializeComponent();
            LoadSuppliers();


        }

        private void InitializeComponent()
        {
            DTGsup = new GroupBox();
            dgvSuppliers = new DataGridView();
            button13 = new Button();
            button14 = new Button();
            groupBox2 = new GroupBox();
            lblSID = new Label();
            label6 = new Label();
            btnAdd = new Button();
            label7 = new Label();
            txtAdd = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtConNo = new TextBox();
            label3 = new Label();
            txtContPerson = new TextBox();
            button11 = new Button();
            label2 = new Label();
            txtSname = new TextBox();
            groupBox1 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            button8 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            DTGsup.SuspendLayout();
            ((ISupportInitialize)dgvSuppliers).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DTGsup
            // 
            DTGsup.BackColor = SystemColors.ActiveBorder;
            DTGsup.Controls.Add(dgvSuppliers);
            DTGsup.Controls.Add(button13);
            DTGsup.Controls.Add(button14);
            DTGsup.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTGsup.Location = new Point(793, 128);
            DTGsup.Name = "DTGsup";
            DTGsup.Size = new Size(544, 494);
            DTGsup.TabIndex = 27;
            DTGsup.TabStop = false;
            DTGsup.Text = "Update";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(14, 49);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(518, 366);
            dgvSuppliers.TabIndex = 23;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // button13
            // 
            button13.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(195, 441);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 22;
            button13.Text = "Update";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Location = new Point(53, 440);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 11;
            button14.Text = "Delete";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(lblSID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtAdd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtConNo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtContPerson);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSname);
            groupBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(389, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 494);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Supplier Management";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblSID
            // 
            lblSID.AutoSize = true;
            lblSID.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSID.Location = new Point(142, 49);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(0, 22);
            lblSID.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 49);
            label6.Name = "label6";
            label6.Size = new Size(29, 22);
            label6.TabIndex = 23;
            label6.Text = "ID";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(214, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button12_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 284);
            label7.Name = "label7";
            label7.Size = new Size(62, 22);
            label7.TabIndex = 19;
            label7.Text = "Adress";
            // 
            // txtAdd
            // 
            txtAdd.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdd.Location = new Point(147, 281);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(213, 29);
            txtAdd.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 236);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 17;
            label5.Text = "Email ";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(147, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 29);
            txtEmail.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(132, 22);
            label4.TabIndex = 15;
            label4.Text = "Contact Numbe";
            // 
            // txtConNo
            // 
            txtConNo.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConNo.Location = new Point(147, 184);
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(213, 29);
            txtConNo.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 13;
            label3.Text = "Contact Person";
            // 
            // txtContPerson
            // 
            txtContPerson.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContPerson.Location = new Point(147, 137);
            txtContPerson.Name = "txtContPerson";
            txtContPerson.Size = new Size(213, 29);
            txtContPerson.TabIndex = 12;
            // 
            // button11
            // 
            button11.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(53, 440);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 11;
            button11.Text = "Clear";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 10;
            label2.Text = "Supplier Name";
            // 
            // txtSname
            // 
            txtSname.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSname.Location = new Point(147, 92);
            txtSname.Name = "txtSname";
            txtSname.Size = new Size(213, 29);
            txtSname.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(47, -7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 699);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = Color.ForestGreen;
            button10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonFace;
            button10.Location = new Point(2, 27);
            button10.Name = "button10";
            button10.Size = new Size(146, 42);
            button10.TabIndex = 15;
            button10.Text = "<<<Dashboard";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(137, 646);
            button9.Name = "button9";
            button9.Size = new Size(141, 42);
            button9.TabIndex = 14;
            button9.Text = "Log Out >>>";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(14, 405);
            button7.Name = "button7";
            button7.Size = new Size(270, 51);
            button7.TabIndex = 11;
            button7.Text = "Reporting Analysis";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F);
            button8.Location = new Point(14, 348);
            button8.Name = "button8";
            button8.Size = new Size(270, 51);
            button8.TabIndex = 10;
            button8.Text = "Suplier Management";
            button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(14, 291);
            button3.Name = "button3";
            button3.Size = new Size(270, 51);
            button3.TabIndex = 9;
            button3.Text = "Order Management";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(14, 234);
            button4.Name = "button4";
            button4.Size = new Size(270, 51);
            button4.TabIndex = 8;
            button4.Text = "Sales Transaction";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(14, 181);
            button2.Name = "button2";
            button2.Size = new Size(270, 51);
            button2.TabIndex = 7;
            button2.Text = "Customer Management";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(14, 124);
            button1.Name = "button1";
            button1.Size = new Size(270, 51);
            button1.TabIndex = 2;
            button1.Text = "Book Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 39);
            label1.Name = "label1";
            label1.Size = new Size(462, 48);
            label1.TabIndex = 24;
            label1.Text = "Supplier Management";
            // 
            // Supplier
            // 
            ClientSize = new Size(1371, 685);
            Controls.Add(DTGsup);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Supplier";
            Text = "Supplier";
            DTGsup.ResumeLayout(false);
            ((ISupportInitialize)dgvSuppliers).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox DTGsup;
        private DataGridView dgvSuppliers;
        private Button button13;
        private Button button14;
        private GroupBox groupBox2;
        private Button btnAdd;
        private Label label7;
        private TextBox txtAdd;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtConNo;
        private Label label3;
        private TextBox txtContPerson;
        private Button button11;
        private Label label2;
        private TextBox txtSname;
        private GroupBox groupBox1;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label lblSID;
        private Label label6;
        private Label label1;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtSname.Text) ||
                string.IsNullOrWhiteSpace(txtContPerson.Text) ||
                string.IsNullOrWhiteSpace(txtConNo.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAdd.Text))
            {
                MessageBox.Show("Please fill in all fields before adding a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Suppliers (SupplierName, ContactPerson, ContactNumber, Email, Address) " +
                                   "VALUES (@SupplierName, @ContactPerson, @ContactNumber, @Email, @Address)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", txtSname.Text);
                        cmd.Parameters.AddWithValue("@ContactPerson", txtContPerson.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", txtConNo.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAdd.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadSuppliers(); // Reload data to update the list
                        }
                        else
                        {
                            MessageBox.Show("Failed to add supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtSname.Clear();
            txtContPerson.Clear();
            txtConNo.Clear();
            txtEmail.Clear();
            txtAdd.Clear();
        }

        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName, ContactPerson, ContactNumber, Email, Address FROM Suppliers";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvSuppliers.DataSource = dt; // Bind data to DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Ensure the user clicked on a valid row (not the header row)
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];

                    // Assign selected row values to text fields
                    lblSID.Text = row.Cells["SupplierID"].Value.ToString();
                    txtSname.Text = row.Cells["SupplierName"].Value.ToString();
                    txtContPerson.Text = row.Cells["ContactPerson"].Value.ToString();
                    txtConNo.Text = row.Cells["ContactNumber"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtAdd.Text = row.Cells["Address"].Value.ToString();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblSID.Text))
            {
                MessageBox.Show("Please select a supplier to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Suppliers SET SupplierName=@SupplierName, ContactPerson=@ContactPerson, " +
                                   "ContactNumber=@ContactNumber, Email=@Email, Address=@Address WHERE SupplierID=@SupplierID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", lblSID.Text);
                        cmd.Parameters.AddWithValue("@SupplierName", txtSname.Text);
                        cmd.Parameters.AddWithValue("@ContactPerson", txtContPerson.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", txtConNo.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAdd.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSuppliers(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblSID.Text))
            {
                MessageBox.Show("Please select a supplier to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Suppliers WHERE SupplierID=@SupplierID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SupplierID", lblSID.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields(); // Clear input fields after deletion
                                LoadSuppliers(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form7 = new Form6();
            form7.Show();
            this.Close();
        }
    }
}