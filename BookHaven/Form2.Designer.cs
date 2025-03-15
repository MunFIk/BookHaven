namespace BookHaven
{
    partial class Admin
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button9 = new Button();
            btnReport = new Button();
            btnSuplier = new Button();
            btnOrder = new Button();
            btnSale = new Button();
            btnCus = new Button();
            btnBook = new Button();
            label2 = new Label();
            dgvSales = new DataGridView();
            dgvBooks = new DataGridView();
            dgvClerks = new DataGridView();
            dgvCustomers = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddClerk = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClerks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 22);
            label1.Name = "label1";
            label1.Size = new Size(148, 48);
            label1.TabIndex = 5;
            label1.Text = "Admin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnReport);
            groupBox1.Controls.Add(btnSuplier);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnSale);
            groupBox1.Controls.Add(btnCus);
            groupBox1.Controls.Add(btnBook);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(-2, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 719);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(76, 616);
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
            btnReport.Location = new Point(14, 471);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(270, 51);
            btnReport.TabIndex = 11;
            btnReport.Text = "Reporting Analysis";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += button7_Click;
            // 
            // btnSuplier
            // 
            btnSuplier.Font = new Font("Segoe UI", 12F);
            btnSuplier.Location = new Point(14, 397);
            btnSuplier.Name = "btnSuplier";
            btnSuplier.Size = new Size(270, 51);
            btnSuplier.TabIndex = 10;
            btnSuplier.Text = "Suplier Management";
            btnSuplier.UseVisualStyleBackColor = true;
            btnSuplier.Click += button8_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 12F);
            btnOrder.Location = new Point(14, 328);
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
            btnSale.Location = new Point(14, 259);
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
            btnCus.Location = new Point(14, 192);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 67);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 3;
            label2.Text = "Total Sales";
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(336, 95);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(442, 254);
            dgvSales.TabIndex = 15;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(795, 95);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(442, 254);
            dgvBooks.TabIndex = 16;
            // 
            // dgvClerks
            // 
            dgvClerks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClerks.Location = new Point(795, 393);
            dgvClerks.Name = "dgvClerks";
            dgvClerks.RowHeadersWidth = 51;
            dgvClerks.Size = new Size(442, 254);
            dgvClerks.TabIndex = 18;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(336, 393);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(442, 254);
            dgvCustomers.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(804, 67);
            label3.Name = "label3";
            label3.Size = new Size(143, 24);
            label3.TabIndex = 19;
            label3.Text = "Book inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 366);
            label4.Name = "label4";
            label4.Size = new Size(166, 24);
            label4.TabIndex = 20;
            label4.Text = "Customer Activity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(795, 366);
            label5.Name = "label5";
            label5.Size = new Size(169, 24);
            label5.TabIndex = 21;
            label5.Text = "Staff Performance";
            // 
            // btnAddClerk
            // 
            btnAddClerk.BackColor = Color.Blue;
            btnAddClerk.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClerk.ForeColor = SystemColors.ButtonFace;
            btnAddClerk.Location = new Point(1075, 20);
            btnAddClerk.Name = "btnAddClerk";
            btnAddClerk.Size = new Size(169, 48);
            btnAddClerk.TabIndex = 15;
            btnAddClerk.Text = "Add New Cleark";
            btnAddClerk.UseVisualStyleBackColor = false;
            btnAddClerk.Click += button10_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 735);
            ControlBox = false;
            Controls.Add(btnAddClerk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvClerks);
            Controls.Add(dgvCustomers);
            Controls.Add(dgvBooks);
            Controls.Add(dgvSales);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClerks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Button btnCus;
        private Button btnBook;
        private Label label2;
        private Button btnReport;
        private Button btnSuplier;
        private Button btnOrder;
        private Button btnSale;
        private Button button9;
        private DataGridView dgvSales;
        private DataGridView dgvBooks;
        private DataGridView dgvClerks;
        private DataGridView dgvCustomers;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddClerk;
    }
}