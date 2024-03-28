namespace EmployeeTracker.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid RoleId { get; set; }
        public Guid? ManagerId { get; set; }
        public Role Role { get; set; }
        public Employee? Manager { get; set; }
        public List<Employee> Subordinates { get; set; } = new List<Employee>();
    }
}
