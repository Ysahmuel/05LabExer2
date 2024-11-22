namespace Lab1
{
    partial class FrmRegistration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRegister = new Button();
            txtStudNo = new TextBox();
            txtLName = new TextBox();
            txtAge = new TextBox();
            txtCNo = new TextBox();
            txtFName = new TextBox();
            txtMI = new TextBox();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            dtBirthday = new DateTimePicker();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 116);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 168);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 221);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 74);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 116);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 168);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 7;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(626, 116);
            label9.Name = "label9";
            label9.Size = new Size(32, 20);
            label9.TabIndex = 8;
            label9.Text = "M.I.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(416, 221);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 9;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(328, 303);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtStudNo
            // 
            txtStudNo.Location = new Point(135, 72);
            txtStudNo.Name = "txtStudNo";
            txtStudNo.Size = new Size(164, 27);
            txtStudNo.TabIndex = 11;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(135, 113);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(164, 27);
            txtLName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(135, 165);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 13;
            // 
            // txtCNo
            // 
            txtCNo.Location = new Point(509, 221);
            txtCNo.Name = "txtCNo";
            txtCNo.Size = new Size(226, 27);
            txtCNo.TabIndex = 15;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(416, 113);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(195, 27);
            txtFName.TabIndex = 16;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(664, 113);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(71, 27);
            txtMI.TabIndex = 17;
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Hospitality Management", "BS Business Administration", "BS Computer Engineering" });
            cbProgram.Location = new Point(416, 66);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(319, 28);
            cbProgram.TabIndex = 18;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Others" });
            cbGender.Location = new Point(416, 165);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 19;
            // 
            // dtBirthday
            // 
            dtBirthday.Location = new Point(135, 221);
            dtBirthday.MaxDate = new DateTime(2024, 11, 9, 0, 0, 0, 0);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(250, 27);
            dtBirthday.TabIndex = 20;
            dtBirthday.Value = new DateTime(2024, 11, 9, 0, 0, 0, 0);
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(641, 303);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(94, 29);
            btnRecords.TabIndex = 21;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 353);
            Controls.Add(btnRecords);
            Controls.Add(dtBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(txtMI);
            Controls.Add(txtFName);
            Controls.Add(txtCNo);
            Controls.Add(txtAge);
            Controls.Add(txtLName);
            Controls.Add(txtStudNo);
            Controls.Add(btnRegister);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRegister;
        private TextBox txtStudNo;
        private TextBox txtLName;
        private TextBox txtAge;
        private TextBox txtCNo;
        private TextBox txtFName;
        private TextBox txtMI;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private DateTimePicker dtBirthday;
        private Button btnRecords;
    }
}