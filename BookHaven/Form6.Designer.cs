﻿namespace BookHaven
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            dgvCart = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qtyleft = new DataGridViewTextBoxColumn();
            Totalprice = new DataGridViewTextBoxColumn();
            button13 = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            lblQty = new Label();
            label9 = new Label();
            lblPrice = new Label();
            lblAutor = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbBook = new ComboBox();
            cmbCus = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            txtQty = new TextBox();
            groupBox1 = new GroupBox();
            btnBack = new Button();
            btnADash = new Button();
            button9 = new Button();
            btnReport = new Button();
            btnSupplier = new Button();
            btnOrder = new Button();
            btnSale = new Button();
            btnCus = new Button();
            btnBook = new Button();
            label1 = new Label();
            txtDiscount = new TextBox();
            txtSub = new TextBox();
            lblTotal = new Label();
            label7 = new Label();
            label5 = new Label();
            label10 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveBorder;
            groupBox3.Controls.Add(dgvCart);
            groupBox3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(346, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1056, 174);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { ID, Customer, Book, Qty, Author, Price, Qtyleft, Totalprice });
            dgvCart.Location = new Point(16, 34);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1034, 123);
            dgvCart.TabIndex = 23;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.MinimumWidth = 6;
            Customer.Name = "Customer";
            Customer.Width = 125;
            // 
            // Book
            // 
            Book.HeaderText = "Book";
            Book.MinimumWidth = 6;
            Book.Name = "Book";
            Book.Width = 125;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Qtyleft
            // 
            Qtyleft.HeaderText = "Qtyleft";
            Qtyleft.MinimumWidth = 6;
            Qtyleft.Name = "Qtyleft";
            Qtyleft.Width = 125;
            // 
            // Totalprice
            // 
            Totalprice.HeaderText = "Totalprice";
            Totalprice.MinimumWidth = 6;
            Totalprice.Name = "Totalprice";
            Totalprice.Width = 125;
            // 
            // button13
            // 
            button13.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(1159, 621);
            button13.Name = "button13";
            button13.Size = new Size(137, 29);
            button13.TabIndex = 22;
            button13.Text = "Place Order";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(771, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(lblQty);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(lblPrice);
            groupBox2.Controls.Add(lblAutor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmbBook);
            groupBox2.Controls.Add(cmbCus);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtQty);
            groupBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(345, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(983, 162);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select details";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(588, 108);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(0, 22);
            lblQty.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(497, 108);
            label9.Name = "label9";
            label9.Size = new Size(69, 22);
            label9.TabIndex = 31;
            label9.Text = "Qty left";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(365, 108);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 22);
            lblPrice.TabIndex = 30;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(105, 108);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(0, 22);
            lblAutor.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(253, 108);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 28;
            label4.Text = "Unit Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 27;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(497, 52);
            label2.Name = "label2";
            label2.Size = new Size(38, 22);
            label2.TabIndex = 26;
            label2.Text = "Qty";
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(333, 41);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(145, 32);
            cmbBook.TabIndex = 25;
            cmbBook.SelectedIndexChanged += cmbBook_SelectedIndexChanged;
            // 
            // cmbCus
            // 
            cmbCus.FormattingEnabled = true;
            cmbCus.Location = new Point(105, 39);
            cmbCus.Name = "cmbCus";
            cmbCus.Size = new Size(145, 32);
            cmbCus.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(277, 44);
            label8.Name = "label8";
            label8.Size = new Size(50, 22);
            label8.TabIndex = 23;
            label8.Text = "Book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 39);
            label6.Name = "label6";
            label6.Size = new Size(85, 22);
            label6.TabIndex = 21;
            label6.Text = "Customer";
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(563, 44);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(86, 29);
            txtQty.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnADash);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(btnReport);
            groupBox1.Controls.Add(btnSupplier);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnSale);
            groupBox1.Controls.Add(btnCus);
            groupBox1.Controls.Add(btnBook);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 699);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(2, 67);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 38);
            btnBack.TabIndex = 16;
            btnBack.Text = "<<<Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnADash
            // 
            btnADash.BackColor = Color.ForestGreen;
            btnADash.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnADash.ForeColor = SystemColors.ButtonFace;
            btnADash.Location = new Point(2, 27);
            btnADash.Name = "btnADash";
            btnADash.Size = new Size(146, 42);
            btnADash.TabIndex = 15;
            btnADash.Text = "<<<Dashboard";
            btnADash.UseVisualStyleBackColor = false;
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
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 12F);
            btnReport.Location = new Point(14, 405);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(270, 51);
            btnReport.TabIndex = 11;
            btnReport.Text = "Reporting Analysis";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.Font = new Font("Segoe UI", 12F);
            btnSupplier.Location = new Point(14, 348);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(270, 51);
            btnSupplier.TabIndex = 10;
            btnSupplier.Text = "Suplier Management";
            btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 12F);
            btnOrder.Location = new Point(14, 291);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(270, 51);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += button3_Click;
            // 
            // btnSale
            // 
            btnSale.Font = new Font("Segoe UI", 12F);
            btnSale.Location = new Point(14, 234);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(270, 51);
            btnSale.TabIndex = 8;
            btnSale.Text = "Sales Transaction";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += button4_Click;
            // 
            // btnCus
            // 
            btnCus.Font = new Font("Segoe UI", 12F);
            btnCus.Location = new Point(14, 181);
            btnCus.Name = "btnCus";
            btnCus.Size = new Size(270, 51);
            btnCus.TabIndex = 7;
            btnCus.Text = "Customer Management";
            btnCus.UseVisualStyleBackColor = true;
            btnCus.Click += button2_Click;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 12F);
            btnBook.Location = new Point(14, 124);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(270, 51);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book Management";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(619, 16);
            label1.Name = "label1";
            label1.Size = new Size(191, 36);
            label1.TabIndex = 24;
            label1.Text = "Place Ordre";
            label1.Click += label1_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(1139, 513);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(165, 29);
            txtDiscount.TabIndex = 34;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtSub
            // 
            txtSub.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSub.Location = new Point(1139, 563);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(165, 29);
            txtSub.TabIndex = 35;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(1139, 467);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 22);
            lblTotal.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(999, 467);
            label7.Name = "label7";
            label7.Size = new Size(118, 22);
            label7.TabIndex = 36;
            label7.Text = "Total Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1005, 513);
            label5.Name = "label5";
            label5.Size = new Size(78, 22);
            label5.TabIndex = 37;
            label5.Text = "Discount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1005, 563);
            label10.Name = "label10";
            label10.Size = new Size(86, 22);
            label10.TabIndex = 38;
            label10.Text = "Sub Total";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 678);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(lblTotal);
            Controls.Add(txtSub);
            Controls.Add(txtDiscount);
            Controls.Add(groupBox3);
            Controls.Add(button13);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dgvCart;
        private Button button13;
        private Button btnAdd;
        private GroupBox groupBox2;
        private ComboBox cmbCus;
        private Label label8;
        private Label label6;
        private TextBox txtQty;
        private GroupBox groupBox1;
        private Button btnADash;
        private Button button9;
        private Button btnReport;
        private Button btnSupplier;
        private Button btnOrder;
        private Button btnSale;
        private Button btnCus;
        private Button btnBook;
        private Label label1;
        private Label lblQty;
        private Label label9;
        private Label lblPrice;
        private Label lblAutor;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbBook;
        private TextBox txtDiscount;
        private TextBox txtSub;
        private Label lblTotal;
        private Label label7;
        private Label label5;
        private Label label10;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qtyleft;
        private DataGridViewTextBoxColumn Totalprice;
        private Button btnBack;
    }
}