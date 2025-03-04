namespace BookHaven
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUname = new TextBox();
            btnCl = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnLog = new Button();
            label3 = new Label();
            txtPW = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 36);
            label1.Name = "label1";
            label1.Size = new Size(372, 72);
            label1.TabIndex = 0;
            label1.Text = "BookHevan";
            // 
            // txtUname
            // 
            txtUname.Location = new Point(262, 241);
            txtUname.Name = "txtUname";
            txtUname.Size = new Size(277, 27);
            txtUname.TabIndex = 1;
            txtUname.TextChanged += textBox1_TextChanged;
            // 
            // btnCl
            // 
            btnCl.Location = new Point(203, 256);
            btnCl.Name = "btnCl";
            btnCl.Size = new Size(94, 51);
            btnCl.TabIndex = 2;
            btnCl.Text = "Clear";
            btnCl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnLog);
            groupBox1.Controls.Add(btnCl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPW);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(76, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 338);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnLog
            // 
            btnLog.Location = new Point(367, 256);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(94, 51);
            btnLog.TabIndex = 7;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // txtPW
            // 
            txtPW.Location = new Point(186, 141);
            txtPW.Name = "txtPW";
            txtPW.PasswordChar = '*';
            txtPW.Size = new Size(277, 43);
            txtPW.TabIndex = 5;
            txtPW.TextChanged += textBox2_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(648, 592);
            Controls.Add(txtUname);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUname;
        private Button btnCl;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtPW;
        private Button btnLog;
    }
}
