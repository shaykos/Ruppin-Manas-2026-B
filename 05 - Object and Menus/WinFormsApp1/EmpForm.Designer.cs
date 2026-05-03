namespace WinFormsApp1
{
    partial class EmpForm
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
            btnContinue = new Button();
            label1 = new Label();
            txtxSalary = new TextBox();
            SuspendLayout();
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(151, 47);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Salary";
            // 
            // txtxSalary
            // 
            txtxSalary.Location = new Point(27, 47);
            txtxSalary.Name = "txtxSalary";
            txtxSalary.Size = new Size(100, 23);
            txtxSalary.TabIndex = 2;
            // 
            // EmpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 104);
            Controls.Add(txtxSalary);
            Controls.Add(label1);
            Controls.Add(btnContinue);
            Name = "EmpForm";
            Text = "EmpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContinue;
        private Label label1;
        private TextBox txtxSalary;
    }
}