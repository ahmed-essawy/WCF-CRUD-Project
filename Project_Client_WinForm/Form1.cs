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
        private WebClient client;
        private Employee[] emplist;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            string response = client.DownloadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Employees"));
            emplist = JsonConvert.DeserializeObject<Employee[]>(response);
            foreach (Employee emp in emplist)
                comboBox_Emp.Items.Add(emp.Name);
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
            if (emp.DP_ID != null)
            {
                client = new WebClient();
                string response = client.DownloadString(new Uri("http://localhost:83/Proj.svc/Proj/REST/Department/" + emp.DP_ID));
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
        }
    }
}