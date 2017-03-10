namespace Project_Client_WinForm
{
    partial class Form1
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
            this.comboBox_Emp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Deparment = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_SSN = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.L_Department = new System.Windows.Forms.Label();
            this.L_Salary = new System.Windows.Forms.Label();
            this.L_SSN = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Emp
            // 
            this.comboBox_Emp.FormattingEnabled = true;
            this.comboBox_Emp.Location = new System.Drawing.Point(26, 27);
            this.comboBox_Emp.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Emp.Name = "comboBox_Emp";
            this.comboBox_Emp.Size = new System.Drawing.Size(320, 21);
            this.comboBox_Emp.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Deparment);
            this.groupBox1.Controls.Add(this.textBox_Salary);
            this.groupBox1.Controls.Add(this.textBox_Phone);
            this.groupBox1.Controls.Add(this.textBox_SSN);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.L_Department);
            this.groupBox1.Controls.Add(this.L_Salary);
            this.groupBox1.Controls.Add(this.L_SSN);
            this.groupBox1.Controls.Add(this.L_Phone);
            this.groupBox1.Controls.Add(this.L_Name);
            this.groupBox1.Location = new System.Drawing.Point(26, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(320, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // textBox_Deparment
            // 
            this.textBox_Deparment.Enabled = false;
            this.textBox_Deparment.Location = new System.Drawing.Point(97, 159);
            this.textBox_Deparment.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Deparment.Name = "textBox_Deparment";
            this.textBox_Deparment.Size = new System.Drawing.Size(204, 20);
            this.textBox_Deparment.TabIndex = 2;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Enabled = false;
            this.textBox_Salary.Location = new System.Drawing.Point(97, 128);
            this.textBox_Salary.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(204, 20);
            this.textBox_Salary.TabIndex = 2;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Enabled = false;
            this.textBox_Phone.Location = new System.Drawing.Point(97, 96);
            this.textBox_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(204, 20);
            this.textBox_Phone.TabIndex = 2;
            // 
            // textBox_SSN
            // 
            this.textBox_SSN.Enabled = false;
            this.textBox_SSN.Location = new System.Drawing.Point(97, 32);
            this.textBox_SSN.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SSN.Name = "textBox_SSN";
            this.textBox_SSN.Size = new System.Drawing.Size(204, 20);
            this.textBox_SSN.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(97, 64);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(204, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // L_Department
            // 
            this.L_Department.AutoSize = true;
            this.L_Department.Location = new System.Drawing.Point(22, 162);
            this.L_Department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Department.Name = "L_Department";
            this.L_Department.Size = new System.Drawing.Size(62, 13);
            this.L_Department.TabIndex = 1;
            this.L_Department.Text = "Department";
            // 
            // L_Salary
            // 
            this.L_Salary.AutoSize = true;
            this.L_Salary.Location = new System.Drawing.Point(22, 130);
            this.L_Salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Salary.Name = "L_Salary";
            this.L_Salary.Size = new System.Drawing.Size(36, 13);
            this.L_Salary.TabIndex = 0;
            this.L_Salary.Text = "Salary";
            // 
            // L_SSN
            // 
            this.L_SSN.AutoSize = true;
            this.L_SSN.Location = new System.Drawing.Point(22, 34);
            this.L_SSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_SSN.Name = "L_SSN";
            this.L_SSN.Size = new System.Drawing.Size(29, 13);
            this.L_SSN.TabIndex = 0;
            this.L_SSN.Text = "SSN";
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Location = new System.Drawing.Point(22, 98);
            this.L_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(38, 13);
            this.L_Phone.TabIndex = 0;
            this.L_Phone.Text = "Phone";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(22, 67);
            this.L_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(35, 13);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 272);
            this.Controls.Add(this.comboBox_Emp);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Emp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Deparment;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_SSN;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label L_Department;
        private System.Windows.Forms.Label L_Salary;
        private System.Windows.Forms.Label L_SSN;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Name;
    }
}

