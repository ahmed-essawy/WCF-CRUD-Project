using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Client_WinForm
{
    public partial class Form1 : Form
    {
        private WebClient client = new WebClient();
        private Employee[] emplist;
        private Dictionary<string, int> Dept;

        public Form1()
        {
            InitializeComponent();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            client.Credentials = new NetworkCredential("", "");
            string response = client.DownloadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Employees"));
            emplist = JsonConvert.DeserializeObject<Employee[]>(response);
            foreach (Employee emp in emplist)
                comboBox_Emp.Items.Add(emp.Name);
            string depts = client.DownloadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Departments"));
            List<Department> temp_dept = JsonConvert.DeserializeObject<List<Department>>(depts);
            Dept = new Dictionary<string, int>();
            foreach (Department dept in temp_dept)
                Dept.Add(dept.Name, dept.ID);
            FillForm(0);
        }

        private void FillForm(int index)
        {
            comboBox_Emp.SelectedIndex = index;
            Employee emp = emplist[index];
            textBox_SSN.Text = emp.SSN.ToString();
            textBox_Name.Text = emp.Name;
            textBox_Phone.Text = emp.Phone;
            textBox_Salary.Text = emp.Salary.ToString();
            if (emp.Department != null)
            {
                string response = client.DownloadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Department/" + emp.Department));
                Department temp_dept = JsonConvert.DeserializeObject<Department>(response);
                textBox_Deparment.Text = temp_dept.Name;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillForm(comboBox_Emp.SelectedIndex);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            textBox_SSN.Enabled = true;
            textBox_Name.Enabled = true;
            textBox_Phone.Enabled = true;
            textBox_Salary.Enabled = true;
            textBox_Deparment.Enabled = true;
            ((Button)sender).Enabled = false;
            //  Save.Enabled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Employee temp_emp = new Employee
            {
                SSN = int.Parse(textBox_SSN.Text),
                Name = textBox_Name.Text,
                Phone = textBox_Phone.Text,
                Salary = decimal.Parse(textBox_Salary.Text),
                Department = Dept[textBox_Deparment.Text]
            };
            string response = client.UploadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Employees"), JsonConvert.SerializeObject(temp_emp));
            ((Button)sender).Enabled = false;
            // Edit.Enabled = true;
        }
    }
}