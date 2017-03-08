using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Server
{
    public class ProjService : IProj
    {
        private Database DB = new Database();

        public bool AddDepartment(Department dept)
        {
            DB.Departments.Add(dept);
            DB.SaveChanges();
            return true;
        }

        public bool AddEmployee(Employee emp)
        {
            DB.Employees.Add(emp);
            DB.SaveChanges();
            return true;
        }

        public List<Department> GetAllDepartments()
        {
            return DB.Departments.ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return DB.Employees.ToList();
        }

        public Department GetDepartmentByID(string ID)
        {
            return DB.Departments.ToList().Find(dept => dept.ID == int.Parse(ID));
        }

        public Department GetDepartmentofEmp(string SSN)
        {
            Employee temp_emp = DB.Employees.ToList().Find(emp => emp.SSN == int.Parse(SSN));
            return DB.Departments.ToList().Find(dept => dept.ID == temp_emp.DP_ID);
        }

        public Employee GetEmployeeByID(string SSN)
        {
            return DB.Employees.ToList().Find(emp => emp.SSN == int.Parse(SSN));
        }

        public bool RemoveDepartment(string ID)
        {
            Department temp_dept = DB.Departments.ToList().Find(dept => dept.ID == int.Parse(ID));
            DB.Departments.Remove(temp_dept);
            DB.SaveChanges();
            return true;
        }

        public bool RemoveEmployee(string SSN)
        {
            Employee temp_emp = DB.Employees.ToList().Find(emp => emp.SSN == int.Parse(SSN));
            DB.Employees.Remove(temp_emp);
            DB.SaveChanges();
            return true;
        }

        public bool UpdateDepartment(string ID, string name)
        {
            Department temp_dept = DB.Departments.ToList().Find(tdept => tdept.ID == int.Parse(ID));
            temp_dept.Name = name;
            DB.SaveChanges();
            return true;
        }

        public bool UpdateEmployee(Employee emp, string SSN)
        {
            Employee temp_emp = DB.Employees.ToList().Find(temp => temp.SSN == int.Parse(SSN));
            temp_emp.Name = emp.Name;
            temp_emp.Phone = emp.Phone;
            temp_emp.Salary = emp.Salary;
            temp_emp.DP_ID = emp.DP_ID;
            DB.SaveChanges();
            return true;
        }
    }
}