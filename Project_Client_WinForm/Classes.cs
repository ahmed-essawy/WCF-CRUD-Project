namespace Project_Client_WinForm
{
    public class Employee
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal? Salary { get; set; }
        public int? DP_ID { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}