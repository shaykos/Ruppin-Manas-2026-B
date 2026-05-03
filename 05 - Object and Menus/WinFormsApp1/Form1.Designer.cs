namespace WinFormsApp1
{
    partial class Form1
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
            btnCreate = new Button();
            txtName = new TextBox();
            label1 = new Label();
            cboRole = new ComboBox();
            label2 = new Label();
            txtSalary = new TextBox();
            label3 = new Label();
            pnlEmployee = new Panel();
            pnlManager = new Panel();
            txtBonus = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblAllPeople = new Label();
            pnlEmployee.SuspendLayout();
            pnlManager.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(27, 120);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Person", "Employee", "Manager" });
            cboRole.Location = new Point(239, 27);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(121, 23);
            cboRole.TabIndex = 3;
            cboRole.SelectedIndexChanged += cboRole_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 30);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Role:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(57, 20);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 23);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Salary:";
            // 
            // pnlEmployee
            // 
            pnlEmployee.Controls.Add(txtSalary);
            pnlEmployee.Controls.Add(label3);
            pnlEmployee.Location = new Point(27, 53);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(175, 61);
            pnlEmployee.TabIndex = 7;
            // 
            // pnlManager
            // 
            pnlManager.Controls.Add(txtBonus);
            pnlManager.Controls.Add(label4);
            pnlManager.Location = new Point(208, 53);
            pnlManager.Name = "pnlManager";
            pnlManager.Size = new Size(175, 61);
            pnlManager.TabIndex = 8;
            // 
            // txtBonus
            // 
            txtBonus.Location = new Point(57, 20);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(100, 23);
            txtBonus.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 23);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Bonus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 185);
            label5.Name = "label5";
            label5.Size = new Size(79, 30);
            label5.TabIndex = 9;
            label5.Text = "People";
            // 
            // lblAllPeople
            // 
            lblAllPeople.AutoSize = true;
            lblAllPeople.Location = new Point(31, 226);
            lblAllPeople.Name = "lblAllPeople";
            lblAllPeople.Size = new Size(10, 15);
            lblAllPeople.TabIndex = 10;
            lblAllPeople.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(lblAllPeople);
            Controls.Add(label5);
            Controls.Add(pnlManager);
            Controls.Add(pnlEmployee);
            Controls.Add(label2);
            Controls.Add(cboRole);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Name = "Form1";
            Text = "Form1";
            pnlEmployee.ResumeLayout(false);
            pnlEmployee.PerformLayout();
            pnlManager.ResumeLayout(false);
            pnlManager.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox txtName;
        private Label label1;
        private ComboBox cboRole;
        private Label label2;
        private TextBox txtSalary;
        private Label label3;
        private Panel pnlEmployee;
        private Panel pnlManager;
        private TextBox txtBonus;
        private Label label4;
        private Label label5;
        private Label lblAllPeople;
    }
}
