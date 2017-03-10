﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Client_ASP.NET.ProjRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Project_Server")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SSNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> SalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> DepartmentField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SSN {
            get {
                return this.SSNField;
            }
            set {
                if ((this.SSNField.Equals(value) != true)) {
                    this.SSNField = value;
                    this.RaisePropertyChanged("SSN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.Nullable<decimal> Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.Nullable<int> Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((this.DepartmentField.Equals(value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Department", Namespace="http://schemas.datacontract.org/2004/07/Project_Server")]
    [System.SerializableAttribute()]
    public partial class Department : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProjRef.IProj")]
    public interface IProj {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetAllEmployees", ReplyAction="http://tempuri.org/IProj/GetAllEmployeesResponse")]
        System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee> GetAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetAllEmployees", ReplyAction="http://tempuri.org/IProj/GetAllEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee>> GetAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetEmployeeByID", ReplyAction="http://tempuri.org/IProj/GetEmployeeByIDResponse")]
        Project_Client_ASP.NET.ProjRef.Employee GetEmployeeByID(string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetEmployeeByID", ReplyAction="http://tempuri.org/IProj/GetEmployeeByIDResponse")]
        System.Threading.Tasks.Task<Project_Client_ASP.NET.ProjRef.Employee> GetEmployeeByIDAsync(string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetEmployeesinDept", ReplyAction="http://tempuri.org/IProj/GetEmployeesinDeptResponse")]
        System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee> GetEmployeesinDept(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetEmployeesinDept", ReplyAction="http://tempuri.org/IProj/GetEmployeesinDeptResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee>> GetEmployeesinDeptAsync(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/AddEmployee", ReplyAction="http://tempuri.org/IProj/AddEmployeeResponse")]
        bool AddEmployee(Project_Client_ASP.NET.ProjRef.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/AddEmployee", ReplyAction="http://tempuri.org/IProj/AddEmployeeResponse")]
        System.Threading.Tasks.Task<bool> AddEmployeeAsync(Project_Client_ASP.NET.ProjRef.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/UpdateEmployee", ReplyAction="http://tempuri.org/IProj/UpdateEmployeeResponse")]
        bool UpdateEmployee(Project_Client_ASP.NET.ProjRef.Employee emp, string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/UpdateEmployee", ReplyAction="http://tempuri.org/IProj/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(Project_Client_ASP.NET.ProjRef.Employee emp, string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/RemoveEmployee", ReplyAction="http://tempuri.org/IProj/RemoveEmployeeResponse")]
        bool RemoveEmployee(string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/RemoveEmployee", ReplyAction="http://tempuri.org/IProj/RemoveEmployeeResponse")]
        System.Threading.Tasks.Task<bool> RemoveEmployeeAsync(string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetAllDepartments", ReplyAction="http://tempuri.org/IProj/GetAllDepartmentsResponse")]
        System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Department> GetAllDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetAllDepartments", ReplyAction="http://tempuri.org/IProj/GetAllDepartmentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Department>> GetAllDepartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetDepartmentByID", ReplyAction="http://tempuri.org/IProj/GetDepartmentByIDResponse")]
        Project_Client_ASP.NET.ProjRef.Department GetDepartmentByID(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetDepartmentByID", ReplyAction="http://tempuri.org/IProj/GetDepartmentByIDResponse")]
        System.Threading.Tasks.Task<Project_Client_ASP.NET.ProjRef.Department> GetDepartmentByIDAsync(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetDepartmentofEmp", ReplyAction="http://tempuri.org/IProj/GetDepartmentofEmpResponse")]
        Project_Client_ASP.NET.ProjRef.Department GetDepartmentofEmp(string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/GetDepartmentofEmp", ReplyAction="http://tempuri.org/IProj/GetDepartmentofEmpResponse")]
        System.Threading.Tasks.Task<Project_Client_ASP.NET.ProjRef.Department> GetDepartmentofEmpAsync(string SSN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/AddDepartment", ReplyAction="http://tempuri.org/IProj/AddDepartmentResponse")]
        bool AddDepartment(Project_Client_ASP.NET.ProjRef.Department dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/AddDepartment", ReplyAction="http://tempuri.org/IProj/AddDepartmentResponse")]
        System.Threading.Tasks.Task<bool> AddDepartmentAsync(Project_Client_ASP.NET.ProjRef.Department dept);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/UpdateDepartment", ReplyAction="http://tempuri.org/IProj/UpdateDepartmentResponse")]
        bool UpdateDepartment(string ID, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/UpdateDepartment", ReplyAction="http://tempuri.org/IProj/UpdateDepartmentResponse")]
        System.Threading.Tasks.Task<bool> UpdateDepartmentAsync(string ID, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/RemoveDepartment", ReplyAction="http://tempuri.org/IProj/RemoveDepartmentResponse")]
        bool RemoveDepartment(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProj/RemoveDepartment", ReplyAction="http://tempuri.org/IProj/RemoveDepartmentResponse")]
        System.Threading.Tasks.Task<bool> RemoveDepartmentAsync(string ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProjChannel : Project_Client_ASP.NET.ProjRef.IProj, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProjClient : System.ServiceModel.ClientBase<Project_Client_ASP.NET.ProjRef.IProj>, Project_Client_ASP.NET.ProjRef.IProj {
        
        public ProjClient() {
        }
        
        public ProjClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProjClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee> GetAllEmployees() {
            return base.Channel.GetAllEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee>> GetAllEmployeesAsync() {
            return base.Channel.GetAllEmployeesAsync();
        }
        
        public Project_Client_ASP.NET.ProjRef.Employee GetEmployeeByID(string SSN) {
            return base.Channel.GetEmployeeByID(SSN);
        }
        
        public System.Threading.Tasks.Task<Project_Client_ASP.NET.ProjRef.Employee> GetEmployeeByIDAsync(string SSN) {
            return base.Channel.GetEmployeeByIDAsync(SSN);
        }
        
        public System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee> GetEmployeesinDept(string ID) {
            return base.Channel.GetEmployeesinDept(ID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Employee>> GetEmployeesinDeptAsync(string ID) {
            return base.Channel.GetEmployeesinDeptAsync(ID);
        }
        
        public bool AddEmployee(Project_Client_ASP.NET.ProjRef.Employee emp) {
            return base.Channel.AddEmployee(emp);
        }
        
        public System.Threading.Tasks.Task<bool> AddEmployeeAsync(Project_Client_ASP.NET.ProjRef.Employee emp) {
            return base.Channel.AddEmployeeAsync(emp);
        }
        
        public bool UpdateEmployee(Project_Client_ASP.NET.ProjRef.Employee emp, string SSN) {
            return base.Channel.UpdateEmployee(emp, SSN);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(Project_Client_ASP.NET.ProjRef.Employee emp, string SSN) {
            return base.Channel.UpdateEmployeeAsync(emp, SSN);
        }
        
        public bool RemoveEmployee(string SSN) {
            return base.Channel.RemoveEmployee(SSN);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveEmployeeAsync(string SSN) {
            return base.Channel.RemoveEmployeeAsync(SSN);
        }
        
        public System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Department> GetAllDepartments() {
            return base.Channel.GetAllDepartments();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Project_Client_ASP.NET.ProjRef.Department>> GetAllDepartmentsAsync() {
            return base.Channel.GetAllDepartmentsAsync();
        }
        
        public Project_Client_ASP.NET.ProjRef.Department GetDepartmentByID(string ID) {
            return base.Channel.GetDepartmentByID(ID);
        }
        
        public System.Threading.Tasks.Task<Project_Client_ASP.NET.ProjRef.Department> GetDepartmentByIDAsync(string ID) {
            return base.Channel.GetDepartmentByIDAsync(ID);
        }
        
        public Project_Client_ASP.NET.ProjRef.Department GetDepartmentofEmp(string SSN) {
            return base.Channel.GetDepartmentofEmp(SSN);
        }
        
        public System.Threading.Tasks.Task<Project_Client_ASP.NET.ProjRef.Department> GetDepartmentofEmpAsync(string SSN) {
            return base.Channel.GetDepartmentofEmpAsync(SSN);
        }
        
        public bool AddDepartment(Project_Client_ASP.NET.ProjRef.Department dept) {
            return base.Channel.AddDepartment(dept);
        }
        
        public System.Threading.Tasks.Task<bool> AddDepartmentAsync(Project_Client_ASP.NET.ProjRef.Department dept) {
            return base.Channel.AddDepartmentAsync(dept);
        }
        
        public bool UpdateDepartment(string ID, string name) {
            return base.Channel.UpdateDepartment(ID, name);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateDepartmentAsync(string ID, string name) {
            return base.Channel.UpdateDepartmentAsync(ID, name);
        }
        
        public bool RemoveDepartment(string ID) {
            return base.Channel.RemoveDepartment(ID);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveDepartmentAsync(string ID) {
            return base.Channel.RemoveDepartmentAsync(ID);
        }
    }
}