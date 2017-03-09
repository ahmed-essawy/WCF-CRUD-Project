using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Project_Server
{
    [ServiceContract]
    public interface IProj
    {
        // Employees
        [WebGet(UriTemplate = "Employees")]
        [OperationContract]
        List<Employee> GetAllEmployees();

        [WebGet(UriTemplate = "Employee/{SSN}")]
        [OperationContract]
        Employee GetEmployeeByID(string SSN);

        [WebGet(UriTemplate = "Employees?Dept={ID}")]
        [OperationContract]
        List<Employee> GetEmployeesinDept(string ID);

        [WebInvoke(Method = "POST", UriTemplate = "Employee")]
        [OperationContract]
        bool AddEmployee(Employee emp);

        [WebInvoke(Method = "PUT", UriTemplate = "Employee/{SSN}")]
        [OperationContract]
        bool UpdateEmployee(Employee emp, string SSN);

        [WebInvoke(Method = "DELETE", UriTemplate = "Employee/{SSN}")]
        [OperationContract]
        bool RemoveEmployee(string SSN);

        // Departments
        [WebGet(UriTemplate = "Departments")]
        [OperationContract]
        List<Department> GetAllDepartments();

        [WebGet(UriTemplate = "Department/{ID}")]
        [OperationContract]
        Department GetDepartmentByID(string ID);

        [WebGet(UriTemplate = "Department?SSN={SSN}")]
        [OperationContract]
        Department GetDepartmentofEmp(string SSN);

        [WebInvoke(Method = "POST", UriTemplate = "Department")]
        [OperationContract]
        bool AddDepartment(Department dept);

        [WebInvoke(Method = "PUT", UriTemplate = "Department/{ID}")]
        [OperationContract]
        bool UpdateDepartment(string ID, string name);

        [WebInvoke(Method = "DELETE", UriTemplate = "Department/{ID}")]
        [OperationContract]
        bool RemoveDepartment(string ID);
    }
}