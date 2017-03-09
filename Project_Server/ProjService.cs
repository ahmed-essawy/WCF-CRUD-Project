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
            bool done = false;
            DB.Departments.Add(dept);
            if (DB.SaveChanges() > 0)
                done = true;
            return done;
        }

        public bool AddEmployee(Employee emp)
        {
            bool done = false;
            DB.Employees.Add(emp);
            if (DB.SaveChanges() > 0)
                done = true;
            return done;
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> temp_list = new List<Department>();
            temp_list.AddRange(DB.Departments.ToList());
            return temp_list;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> temp_list = new List<Employee>();
            temp_list.AddRange(DB.Employees.ToList());
            return temp_list;
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

        public List<Employee> GetEmployeesinDept(string ID)
        {
            List<Employee> temp_list = new List<Employee>();
            Department temp_dept = DB.Departments.ToList().Find(dept => dept.ID == int.Parse(ID));
            temp_list.AddRange(DB.Employees.ToList().FindAll(emp => emp.DP_ID == temp_dept.ID));
            return temp_list;
        }

        public bool RemoveDepartment(string ID)
        {
            bool done = false;
            Department temp_dept = DB.Departments.ToList().Find(dept => dept.ID == int.Parse(ID));
            if (temp_dept != null)
            {
                DB.Departments.Remove(temp_dept);
                if (DB.SaveChanges() > 0)
                    done = true;
            }
            return done;
        }

        public bool RemoveEmployee(string SSN)
        {
            bool done = false;
            Employee temp_emp = DB.Employees.ToList().Find(emp => emp.SSN == int.Parse(SSN));
            if (temp_emp != null)
            {
                DB.Employees.Remove(temp_emp);
                if (DB.SaveChanges() > 0)
                    done = true;
            }
            return done;
        }

        public bool UpdateDepartment(string ID, string name)
        {
            bool done = false;
            Department temp_dept = DB.Departments.ToList().Find(tdept => tdept.ID == int.Parse(ID));
            if (temp_dept != null)
            {
                temp_dept.Name = name;
                if (DB.SaveChanges() > 0)
                    done = true;
            }
            return done;
        }

        public bool UpdateEmployee(Employee emp, string SSN)
        {
            bool done = false;
            Employee temp_emp = DB.Employees.ToList().Find(temp => temp.SSN == int.Parse(SSN));
            if (temp_emp != null)
            {
                temp_emp.Name = emp.Name;
                temp_emp.Phone = emp.Phone;
                temp_emp.Salary = emp.Salary;
                temp_emp.DP_ID = emp.DP_ID;
                if (DB.SaveChanges() > 0)
                    done = true;
            }
            return done;
        }
    }
}