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
            button7 = new Button();
            button8 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dgvBooks = new DataGridView();
            dgvClerks = new DataGridView();
            dgvCustomers = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button10 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
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
            button9.Location = new Point(76, 646);
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
            button7.Location = new Point(14, 471);
            button7.Name = "button7";
            button7.Size = new Size(270, 51);
            button7.TabIndex = 11;
            button7.Text = "Reporting Analysis";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F);
            button8.Location = new Point(14, 397);
            button8.Name = "button8";
            button8.Size = new Size(270, 51);
            button8.TabIndex = 10;
            button8.Text = "Suplier Management";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(14, 328);
            button3.Name = "button3";
            button3.Size = new Size(270, 51);
            button3.TabIndex = 9;
            button3.Text = "Order Management";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(14, 259);
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
            button2.Location = new Point(14, 192);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(336, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(442, 254);
            dataGridView1.TabIndex = 15;
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
            // button10
            // 
            button10.BackColor = Color.Blue;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonFace;
            button10.Location = new Point(1096, 12);
            button10.Name = "button10";
            button10.Size = new Size(148, 32);
            button10.TabIndex = 15;
            button10.Text = "Add New Cleark";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 735);
            Controls.Add(button10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvClerks);
            Controls.Add(dgvCustomers);
            Controls.Add(dgvBooks);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClerks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button4;
        private Button button9;
        private DataGridView dataGridView1;
        private DataGridView dgvBooks;
        private DataGridView dgvClerks;
        private DataGridView dgvCustomers;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button10;
    }
}