using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Client_ASP.NET
{
    public partial class index : System.Web.UI.Page
    {
        private ProjRef.ProjClient client = new ProjRef.ProjClient("WSHttpBinding_IProj");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeTable.DataSource = client.GetAllEmployees();
                EmployeeTable.DataBind();
                DepartmentTable.DataSource = client.GetAllDepartments();
                DepartmentTable.DataBind();
            }
        }

        protected void DropDownList1_Init(object sender, EventArgs e)
        {
            DropDownList emps_dept = (DropDownList)sender;
            emps_dept.DataSource = client.GetAllDepartments();
            emps_dept.DataBind();
        }

        public string DeptName(string ID)
        {
            return client.GetDepartmentByID(ID).Name;
        }

        public int LastSSN()
        {
            return client.GetAllEmployees().Last().SSN + 1;
        }

        public int LastID()
        {
            return client.GetAllDepartments().Last().ID + 1;
        }

        protected void EmployeeTable_RowEditing(object sender, GridViewEditEventArgs e)
        {
            EmployeeTable.EditIndex = e.NewEditIndex;
            EmployeeTable.DataSource = client.GetAllEmployees();
            EmployeeTable.DataBind();
        }

        protected void EmployeeTable_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string SSN = ((Label)EmployeeTable.Rows[e.RowIndex].Cells[1].FindControl("Label1")).Text;
            ProjRef.Employee temp_emp = new ProjRef.Employee
            {
                SSN = int.Parse(SSN),
                Name = ((TextBox)EmployeeTable.Rows[e.RowIndex].Cells[2].FindControl("TextBox2")).Text,
                Salary = decimal.Parse(((TextBox)EmployeeTable.Rows[e.RowIndex].Cells[3].FindControl("TextBox4")).Text),
                Phone = ((TextBox)EmployeeTable.Rows[e.RowIndex].Cells[4].FindControl("TextBox3")).Text,
                Department = int.Parse(((DropDownList)EmployeeTable.Rows[e.RowIndex].Cells[5].FindControl("DropDownList1")).SelectedValue)
            };
            client.UpdateEmployee(temp_emp, SSN);
            EmployeeTable.EditIndex = -1;
            EmployeeTable.DataSource = client.GetAllEmployees();
            EmployeeTable.DataBind();
        }

        protected void EmployeeTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string SSN = ((Label)EmployeeTable.Rows[e.RowIndex].Cells[1].FindControl("Label1")).Text;
            client.RemoveEmployee(SSN);
            EmployeeTable.DataSource = client.GetAllEmployees();
            EmployeeTable.DataBind();
        }

        protected void EmployeeTable_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            EmployeeTable.EditIndex = -1;
            EmployeeTable.DataSource = client.GetAllEmployees();
            EmployeeTable.DataBind();
        }

        protected void Add_Emp(object sender, EventArgs e)
        {
            string SSN = ((Label)EmployeeTable.FooterRow.Cells[1].FindControl("Label1")).Text;
            ProjRef.Employee temp_emp = new ProjRef.Employee
            {
                SSN = int.Parse(SSN),
                Name = ((TextBox)EmployeeTable.FooterRow.Cells[2].FindControl("TextBox2")).Text,
                Salary = decimal.Parse(((TextBox)EmployeeTable.FooterRow.Cells[3].FindControl("TextBox4")).Text),
                Phone = ((TextBox)EmployeeTable.FooterRow.Cells[4].FindControl("TextBox3")).Text,
                Department = int.Parse(((DropDownList)EmployeeTable.FooterRow.Cells[5].FindControl("DropDownList1")).SelectedValue)
            };
            client.AddEmployee(temp_emp);
            EmployeeTable.DataSource = client.GetAllEmployees();
            EmployeeTable.DataBind();
        }

        protected void DepartmentTable_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DepartmentTable.EditIndex = -1;
            DepartmentTable.DataSource = client.GetAllDepartments();
            DepartmentTable.DataBind();
        }

        protected void DepartmentTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ID = ((Label)DepartmentTable.Rows[e.RowIndex].Cells[0].FindControl("Label1")).Text;

            client.RemoveDepartment(ID);
            DepartmentTable.DataSource = client.GetAllDepartments();
            DepartmentTable.DataBind();
        }

        protected void DepartmentTable_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DepartmentTable.EditIndex = e.NewEditIndex;
            DepartmentTable.DataSource = client.GetAllDepartments();
            DepartmentTable.DataBind();
        }

        protected void DepartmentTable_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string ID = ((Label)DepartmentTable.Rows[e.RowIndex].Cells[0].FindControl("Label1")).Text;
            string Name = ((TextBox)DepartmentTable.Rows[e.RowIndex].Cells[0].FindControl("TextBox1")).Text;
            client.UpdateDepartment(ID, Name);
            DepartmentTable.EditIndex = -1;
            DepartmentTable.DataSource = client.GetAllDepartments();
            DepartmentTable.DataBind();
        }

        protected void Add_Dept(object sender, EventArgs e)
        {
            string ID = ((Label)DepartmentTable.FooterRow.Cells[0].FindControl("Label1")).Text;
            ProjRef.Department temp_dept = new ProjRef.Department
            {
                ID = int.Parse(ID),
                Name = ((TextBox)DepartmentTable.FooterRow.Cells[0].FindControl("TextBox1")).Text
            };
            client.AddDepartment(temp_dept);
            DepartmentTable.DataSource = client.GetAllDepartments();
            DepartmentTable.DataBind();
        }
    }
}