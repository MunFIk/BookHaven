namespace BookHaven
{
    partial class Cleark
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
            groupBox1 = new GroupBox();
            btnBook = new Button();
            button9 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            label4 = new Label();
            dgvBooks = new DataGridView();
            label2 = new Label();
            txtSearchBook = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnBook);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 694);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 12F);
            btnBook.Location = new Point(17, 124);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(270, 51);
            btnBook.TabIndex = 15;
            btnBook.Text = "Book Management";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(76, 623);
            button9.Name = "button9";
            button9.Size = new Size(141, 42);
            button9.TabIndex = 14;
            button9.Text = "Log Out >>>";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(266, 48);
            label1.TabIndex = 5;
            label1.Text = "Sales Cleark";
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
            button3.Click += button3_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(730, 43);
            label4.Name = "label4";
            label4.Size = new Size(150, 24);
            label4.TabIndex = 24;
            label4.Text = "Avialable Books";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(360, 125);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(901, 528);
            dgvBooks.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1068, 92);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 28;
            label2.Text = "Search";
            // 
            // txtSearchBook
            // 
            txtSearchBook.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBook.Location = new Point(1134, 89);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(127, 29);
            txtSearchBook.TabIndex = 27;
            txtSearchBook.TextChanged += txtQty_TextChanged;
            // 
            // Cleark
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 694);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(txtSearchBook);
            Controls.Add(dgvBooks);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Cleark";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cleark Dasboard";
            Load += Cleark_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button9;
        private Label label1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Label label4;
        private DataGridView dgvBooks;
        private Button btnBook;
        private Label label2;
        private TextBox txtSearchBook;
    }
}