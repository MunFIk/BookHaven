namespace BookHaven
{
    partial class BookManagement
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
            button10 = new Button();
            button9 = new Button();
            button7 = new Button();
            button8 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            button11 = new Button();
            groupBox2 = new GroupBox();
            lblBID = new Label();
            label9 = new Label();
            cmbSupp = new ComboBox();
            label8 = new Label();
            button12 = new Button();
            label6 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtISBN = new TextBox();
            label4 = new Label();
            txtGen = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            groupBox3 = new GroupBox();
            dgvBooks = new DataGridView();
            button13 = new Button();
            button14 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
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
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 699);
            groupBox1.TabIndex = 8;
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
            button10.Click += button10_Click;
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
            label1.Location = new Point(535, 48);
            label1.Name = "label1";
            label1.Size = new Size(399, 48);
            label1.TabIndex = 5;
            label1.Text = "Book management";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(112, 88);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(176, 29);
            txtTitle.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 91);
            label2.Name = "label2";
            label2.Size = new Size(44, 22);
            label2.TabIndex = 10;
            label2.Text = "Title";
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(lblBID);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbSupp);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtStock);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtISBN);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtGen);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAuthor);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(343, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 494);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book inventory management";
            // 
            // lblBID
            // 
            lblBID.AutoSize = true;
            lblBID.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBID.Location = new Point(112, 46);
            lblBID.Name = "lblBID";
            lblBID.Size = new Size(0, 22);
            lblBID.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 46);
            label9.Name = "label9";
            label9.Size = new Size(29, 22);
            label9.TabIndex = 25;
            label9.Text = "ID";
            // 
            // cmbSupp
            // 
            cmbSupp.FormattingEnabled = true;
            cmbSupp.Location = new Point(156, 371);
            cmbSupp.Name = "cmbSupp";
            cmbSupp.Size = new Size(145, 32);
            cmbSupp.TabIndex = 24;
            cmbSupp.SelectedIndexChanged += cmbSupp_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 376);
            label8.Name = "label8";
            label8.Size = new Size(125, 22);
            label8.TabIndex = 23;
            label8.Text = "Select Supplier";
            // 
            // button12
            // 
            button12.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(214, 440);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 22;
            button12.Text = "Add";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 329);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 21;
            label6.Text = "Stock Qty";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(112, 326);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(176, 29);
            txtStock.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 280);
            label7.Name = "label7";
            label7.Size = new Size(47, 22);
            label7.TabIndex = 19;
            label7.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(112, 277);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(176, 29);
            txtPrice.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 232);
            label5.Name = "label5";
            label5.Size = new Size(50, 22);
            label5.TabIndex = 17;
            label5.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(112, 229);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(176, 29);
            txtISBN.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 183);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 15;
            label4.Text = "genre";
            // 
            // txtGen
            // 
            txtGen.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGen.Location = new Point(112, 180);
            txtGen.Name = "txtGen";
            txtGen.Size = new Size(176, 29);
            txtGen.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 136);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 13;
            label3.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(112, 133);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(176, 29);
            txtAuthor.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveBorder;
            groupBox3.Controls.Add(dgvBooks);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(button14);
            groupBox3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(734, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(544, 494);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(14, 49);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(518, 366);
            dgvBooks.TabIndex = 23;
            dgvBooks.CellClick += dgvBooks_CellClick;
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
            // BookManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 708);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "BookManagement";
            Text = "BookManagement";
            Load += BookManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private Button button11;
        private GroupBox groupBox2;
        private Button button12;
        private Label label6;
        private TextBox txtStock;
        private Label label7;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtISBN;
        private Label label4;
        private TextBox txtGen;
        private Label label3;
        private TextBox txtAuthor;
        private GroupBox groupBox3;
        private Button button13;
        private Button button14;
        private DataGridView dgvBooks;
        private ComboBox cmbSupp;
        private Label label8;
        private Label lblBID;
        private Label label9;
    }
}