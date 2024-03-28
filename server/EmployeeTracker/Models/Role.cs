namespace EmployeeTracker.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public Guid DeptId { get; set; }
        public bool IsManagement { get; set; }
        public Department Department { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
