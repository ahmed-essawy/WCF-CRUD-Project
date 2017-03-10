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
            this.L_Name = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Salary = new System.Windows.Forms.Label();
            this.L_Department = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.textBox_Deparment = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.L_SSN = new System.Windows.Forms.Label();
            this.textBox_SSN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Emp
            // 
            this.comboBox_Emp.FormattingEnabled = true;
            this.comboBox_Emp.Location = new System.Drawing.Point(25, 23);
            this.comboBox_Emp.Name = "comboBox_Emp";
            this.comboBox_Emp.Size = new System.Drawing.Size(426, 24);
            this.comboBox_Emp.TabIndex = 1;
            this.comboBox_Emp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(25, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(29, 82);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(45, 17);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "Name";
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Location = new System.Drawing.Point(29, 121);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(49, 17);
            this.L_Phone.TabIndex = 0;
            this.L_Phone.Text = "Phone";
            // 
            // L_Salary
            // 
            this.L_Salary.AutoSize = true;
            this.L_Salary.Location = new System.Drawing.Point(29, 160);
            this.L_Salary.Name = "L_Salary";
            this.L_Salary.Size = new System.Drawing.Size(48, 17);
            this.L_Salary.TabIndex = 0;
            this.L_Salary.Text = "Salary";
            // 
            // L_Department
            // 
            this.L_Department.AutoSize = true;
            this.L_Department.Location = new System.Drawing.Point(29, 199);
            this.L_Department.Name = "L_Department";
            this.L_Department.Size = new System.Drawing.Size(82, 17);
            this.L_Department.TabIndex = 1;
            this.L_Department.Text = "Department";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(129, 79);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(270, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Enabled = false;
            this.textBox_Phone.Location = new System.Drawing.Point(129, 118);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(270, 22);
            this.textBox_Phone.TabIndex = 2;
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Enabled = false;
            this.textBox_Salary.Location = new System.Drawing.Point(129, 157);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(270, 22);
            this.textBox_Salary.TabIndex = 2;
            // 
            // textBox_Deparment
            // 
            this.textBox_Deparment.Enabled = false;
            this.textBox_Deparment.Location = new System.Drawing.Point(129, 196);
            this.textBox_Deparment.Name = "textBox_Deparment";
            this.textBox_Deparment.Size = new System.Drawing.Size(270, 22);
            this.textBox_Deparment.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 412);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Delete);
            this.tabPage1.Controls.Add(this.Save);
            this.tabPage1.Controls.Add(this.Edit);
            this.tabPage1.Controls.Add(this.comboBox_Emp);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(25, 320);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(138, 35);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(169, 320);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(138, 35);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(313, 320);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 35);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(171, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(426, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(128, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(270, 22);
            this.textBox8.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // L_SSN
            // 
            this.L_SSN.AutoSize = true;
            this.L_SSN.Location = new System.Drawing.Point(29, 42);
            this.L_SSN.Name = "L_SSN";
            this.L_SSN.Size = new System.Drawing.Size(36, 17);
            this.L_SSN.TabIndex = 0;
            this.L_SSN.Text = "SSN";
            // 
            // textBox_SSN
            // 
            this.textBox_SSN.Enabled = false;
            this.textBox_SSN.Location = new System.Drawing.Point(129, 39);
            this.textBox_SSN.Name = "textBox_SSN";
            this.textBox_SSN.Size = new System.Drawing.Size(270, 22);
            this.textBox_SSN.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 706);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Emp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Deparment;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label L_Department;
        private System.Windows.Forms.Label L_Salary;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SSN;
        private System.Windows.Forms.Label L_SSN;
    }
}

