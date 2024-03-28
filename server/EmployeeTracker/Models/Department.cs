using System.Net.Sockets;

namespace EmployeeTracker.Models
{
    public class Department
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();
    }
}
