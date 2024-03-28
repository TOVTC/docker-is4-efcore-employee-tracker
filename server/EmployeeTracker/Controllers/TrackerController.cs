using EmployeeTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TrackerController : ControllerBase
    {
        // GET: api/tracker/departments
        [HttpGet("departments")]
        public IEnumerable<Department> GetDepartments()
        {
            return new Department[] {
                new Department
                {
                    
                    //Id = 6,
                    Id = Guid.Parse("945A5BFA-012A-4047-B1E4-02592A3156BD"),
                    DepartmentName = "Administration",
                },
                new Department
                {
                    
                    //Id = 1,
                    Id = Guid.Parse("107D6EB3-1F61-4A1A-ABA8-039454DB136B"),
                    DepartmentName = "Executive"
                },
                new Department
                {
                    
                    //Id = 4,
                    Id = Guid.Parse("AC532FDC-2D1B-426C-9B1E-043E7727EEAE"),
                    DepartmentName = "Finance"
                },
                new Department
                {
                    
                    //Id = 7,
                    Id = Guid.Parse("75209929-7231-432A-8FDA-04A84D4A59DD"),
                    DepartmentName = "Human Resources"
                },
                new Department
                {
                    
                    //Id = 3,
                    Id = Guid.Parse("89E84583-A348-42BB-BCA8-09A118A32521"),
                    DepartmentName = "Info Tech"
                },
                new Department
                {
                    
                    //Id = 2,
                    Id = Guid.Parse("A80A1414-A130-4785-939F-09E7DF7E00C2"),
                    DepartmentName = "Marketing"
                },
                new Department
                {
                    
                    //Id = 5,
                    Id = Guid.Parse("00E5B334-C661-4357-8DCF-0D1D0985DB18"),
                    DepartmentName = "Operations"
                },
                new Department
                {
                    
                    //Id = 8,
                    Id = Guid.Parse("7A815ECD-7AB8-4848-AF2E-114F9D38A719"),
                    DepartmentName = "Public Relations"
                }
            };
        }

        // GET: api/tracker/employees
        [HttpGet("roles")]
        public IEnumerable<Role> GetRoles()
        {
            return new Role[] {
                new Role {
                    
                    //Id = 1,
                    Id = Guid.Parse("CF744E92-3FE0-440D-ACAF-140607D33B8E"),
                    JobTitle = "President",
                    Salary = 70000,
                    
                    //DeptId = 1,
                    DeptId = Guid.Parse("107D6EB3-1F61-4A1A-ABA8-039454DB136B"),
                    IsManagement = true
                },
                new Role {
                    
                    //Id = 2,
                    Id = Guid.Parse("0126C299-2050-477D-99DA-16C471A0DBE0"),
                    JobTitle = "Vice President",
                    Salary = 60000,
                    
                    //DeptId = 1,
                    DeptId = Guid.Parse("107D6EB3-1F61-4A1A-ABA8-039454DB136B"),
                    IsManagement = true
                },
                new Role {
                    
                    //Id = 3,
                    Id = Guid.Parse("F30F67C8-8D16-4A2F-9103-1B54A3F41C35"),
                    JobTitle = "Marketing Manager",
                    Salary = 50000,
                    
                    //DeptId = 2,
                    DeptId = Guid.Parse("A80A1414-A130-4785-939F-09E7DF7E00C2"),
                    IsManagement = true
                },
                new Role {
                    
                    //Id = 4,
                    Id = Guid.Parse("0F9A68A3-7070-4644-AA22-1CEE71E53457"),
                    JobTitle = "IT Manager",
                    Salary = 55000,
                    
                    //DeptId = 3,
                    DeptId = Guid.Parse("89E84583-A348-42BB-BCA8-09A118A32521"),
                    IsManagement = true
                },
                new Role {
                    
                    //Id = 5,
                    Id = Guid.Parse("B2392061-EC9F-4435-8D08-25F0E0D62A72"),
                    JobTitle = "Finance Manager",
                    Salary = 50000,
                    
                    //DeptId = 4,
                    DeptId = Guid.Parse("AC532FDC-2D1B-426C-9B1E-043E7727EEAE"),
                    IsManagement = true
                },
                new Role {
                    
                    //Id = 6,
                    Id = Guid.Parse("CB5B26BD-BAFD-4998-AAC0-2CB019CF54B8"),
                    JobTitle = "Operations Manager",
                    Salary = 50000,
                    
                    //DeptId = 5,
                    DeptId = Guid.Parse("00E5B334-C661-4357-8DCF-0D1D0985DB18"),
                    IsManagement = true
                },
                new Role {
                    
                    //Id = 7,
                    Id = Guid.Parse("6A410106-A382-48A1-9442-2D9ED6BBD905"),
                    JobTitle = "Admin Assistant",
                    Salary = 35000,
                    
                    //DeptId = 6,
                    DeptId = Guid.Parse("945A5BFA-012A-4047-B1E4-02592A3156BD"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 8,
                    Id = Guid.Parse("27DB6AB3-0174-4312-BBBA-31A0C37FA29F"),
                    JobTitle = "HR Rep",
                    Salary = 35000,
                    
                    //DeptId = 7,
                    DeptId = Guid.Parse("75209929-7231-432A-8FDA-04A84D4A59DD"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 9,
                    Id = Guid.Parse("BA96796D-022C-4C80-BBD7-3C0BBBCCC2CB"),
                    JobTitle = "PR Rep",
                    Salary = 35000,
                    
                    //DeptId = 8,
                    DeptId = Guid.Parse("7A815ECD-7AB8-4848-AF2E-114F9D38A719"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 10,
                    Id = Guid.Parse("BDB8CB52-263C-4847-AF66-4A6EE96FA77E"),
                    JobTitle = "Marketing Rep",
                    Salary = 35000,
                    
                    //DeptId = 2,
                    DeptId = Guid.Parse("A80A1414-A130-4785-939F-09E7DF7E00C2"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 11,
                    Id = Guid.Parse("A930A5CF-2D6B-4D13-A5BA-4AECE0E48CF8"),
                    JobTitle = "Developer",
                    Salary = 40000,
                    
                    //DeptId = 3,
                    DeptId = Guid.Parse("89E84583-A348-42BB-BCA8-09A118A32521"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 12,
                    Id = Guid.Parse("DD4B442A-0E34-4A33-8FB2-5165BDCC6F2C"),
                    JobTitle = "Accountant",
                    Salary = 35000,
                    
                    //DeptId = 4,
                    DeptId = Guid.Parse("AC532FDC-2D1B-426C-9B1E-043E7727EEAE"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 13,
                    Id = Guid.Parse("59FFEF4E-0B57-485E-A01E-56F227882A32"),
                    JobTitle = "Data Clerk",
                    Salary = 31000,
                    
                    //DeptId = 5,
                    DeptId = Guid.Parse("00E5B334-C661-4357-8DCF-0D1D0985DB18"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 14,
                    Id = Guid.Parse("814DFFC8-AA86-45AC-BAFB-5B1443309B5F"),
                    JobTitle = "Customer Service",
                    Salary = 31000,
                    
                    //DeptId = 5,
                    DeptId = Guid.Parse("00E5B334-C661-4357-8DCF-0D1D0985DB18"),
                    IsManagement = false
                },
                new Role {
                    
                    //Id = 15,
                    Id = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    JobTitle = "Operations Attendant",
                    Salary = 31000,
                    
                    //DeptId = 5,
                    DeptId = Guid.Parse("00E5B334-C661-4357-8DCF-0D1D0985DB18"),
                    IsManagement = false
                }
            };
        }

        // GET: api/tracker/employees
        [HttpGet("employees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return new Employee[] {
                new Employee {
                    
                    //Id = 1,
                    Id = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                    FirstName = "Steven",
                    LastName = "King",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("CF744E92-3FE0-440D-ACAF-140607D33B8E"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 2,
                    Id = Guid.Parse("55A952D6-83E9-4247-B8F0-6C793F15F004"),
                    FirstName = "Lex",
                    LastName = "De Haan",
                    
                    //RoleId = 2,
                    RoleId = Guid.Parse("0126C299-2050-477D-99DA-16C471A0DBE0"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 3,
                    Id = Guid.Parse("C91A1B1A-CAFA-4525-8FDA-6D2E8DFDA8DE"),
                    FirstName = "Neena",
                    LastName = "Kochhar",
                    
                    //RoleId = 2,
                    RoleId = Guid.Parse("0126C299-2050-477D-99DA-16C471A0DBE0"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 4,
                    Id = Guid.Parse("9B28AD17-684A-4BEC-A751-773BDAB16283"),
                    FirstName = "Michael",
                    LastName = "Hartstein",
                    
                    //RoleId = 3,
                    RoleId = Guid.Parse("F30F67C8-8D16-4A2F-9103-1B54A3F41C35"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 5,
                    Id = Guid.Parse("3DACACF6-C451-41D9-9D86-79C24FA54A5D"),
                    FirstName = "Alexander",
                    LastName = "Hunold",
                    
                    //RoleId = 4,
                    RoleId = Guid.Parse("0F9A68A3-7070-4644-AA22-1CEE71E53457"),
                    
                    //ManagerId = 2
                    ManagerId = Guid.Parse("55A952D6-83E9-4247-B8F0-6C793F15F004"),
                },
                new Employee {
                    
                    //Id = 6,
                    Id = Guid.Parse("01078C07-691B-4FCD-800C-7B03467DB41F"),
                    FirstName = "Nancy",
                    LastName = "Greenberg",
                    
                    //RoleId = 5,
                    RoleId = Guid.Parse("B2392061-EC9F-4435-8D08-25F0E0D62A72"),
                    
                    //ManagerId = 3
                    ManagerId = Guid.Parse("C91A1B1A-CAFA-4525-8FDA-6D2E8DFDA8DE"),
                },
                new Employee {
                    
                    //Id = 7,
                    Id = Guid.Parse("BB20C8BA-86AC-4BC1-A0B6-7C22BD281834"),
                    FirstName = "Matthew",
                    LastName = "Weiss",
                    
                    //RoleId = 6,
                    RoleId = Guid.Parse("CB5B26BD-BAFD-4998-AAC0-2CB019CF54B8"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 8,
                    Id = Guid.Parse("087A1C96-DE0F-4330-B21C-82C9512F91D5"),
                    FirstName = "Adam",
                    LastName = "Fripp",
                    
                    //RoleId = 6,
                    RoleId = Guid.Parse("CB5B26BD-BAFD-4998-AAC0-2CB019CF54B8"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 9,
                    Id = Guid.Parse("3B527114-8EED-4BEE-A1A1-83699664A9CE"),
                    FirstName = "Payam",
                    LastName = "Kaufling",
                    
                    //RoleId = 6,
                    RoleId = Guid.Parse("CB5B26BD-BAFD-4998-AAC0-2CB019CF54B8"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 10,
                    Id = Guid.Parse("08769C56-14B4-4574-BB55-85C0D1B5AEBC"),
                    FirstName = "Shanta",
                    LastName = "Vollman",
                    
                    //RoleId = 6,
                    RoleId = Guid.Parse("CB5B26BD-BAFD-4998-AAC0-2CB019CF54B8"),
                    
                    //ManagerId = 1
                    ManagerId = Guid.Parse("AE401688-5E31-4356-9903-6BE404A0EC04"),
                },
                new Employee {
                    
                    //Id = 11,
                    Id = Guid.Parse("45FF097D-4B4C-4F47-AD0E-892878BB5B57"),
                    FirstName = "Jennifer",
                    LastName = "Whalen",
                    
                    //RoleId = 7,
                    RoleId = Guid.Parse("6A410106-A382-48A1-9442-2D9ED6BBD905"),
                    
                    //ManagerId = 3
                    ManagerId = Guid.Parse("C91A1B1A-CAFA-4525-8FDA-6D2E8DFDA8DE"),
                },
                new Employee {
                    
                    //Id = 12,
                    Id = Guid.Parse("ED2CAF61-43C9-4B76-8C0C-8A2D93648F87"),
                    FirstName = "Susan",
                    LastName = "Mavris",
                    
                    //RoleId = 8,
                    RoleId = Guid.Parse("27DB6AB3-0174-4312-BBBA-31A0C37FA29F"),
                    
                    //ManagerId = 3
                    ManagerId = Guid.Parse("C91A1B1A-CAFA-4525-8FDA-6D2E8DFDA8DE"),
                },
                new Employee {
                    
                    //Id = 13,
                    Id = Guid.Parse("182F8815-0DAF-469D-8BB4-9476DEB6BBA6"),
                    FirstName = "Hermann",
                    LastName = "Baer",
                    
                    //RoleId = 9,
                    RoleId = Guid.Parse("BA96796D-022C-4C80-BBD7-3C0BBBCCC2CB"),
                    
                    //ManagerId = 3
                    ManagerId = Guid.Parse("C91A1B1A-CAFA-4525-8FDA-6D2E8DFDA8DE"),
                },
                new Employee {
                    
                    //Id = 14,
                    Id = Guid.Parse("7AE8F349-43DD-478F-952F-9DDE68415B1F"),
                    FirstName = "Pat",
                    LastName = "Fay",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("BDB8CB52-263C-4847-AF66-4A6EE96FA77E"),
                    
                    //ManagerId = 4
                    ManagerId = Guid.Parse("9B28AD17-684A-4BEC-A751-773BDAB16283"),
                },
                new Employee {
                    
                    //Id = 15,
                    Id = Guid.Parse("BE6B5E30-7FD2-4A19-A3C6-A25EA164A317"),
                    FirstName = "Bruce",
                    LastName = "Ernst",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("A930A5CF-2D6B-4D13-A5BA-4AECE0E48CF8"),
                    
                    //ManagerId = 5
                    ManagerId = Guid.Parse("3DACACF6-C451-41D9-9D86-79C24FA54A5D"),
                },
                new Employee {
                    
                    //Id = 16,
                    Id = Guid.Parse("79C27692-24AA-4AE9-B21C-A78AAF1F3B1D"),
                    FirstName = "David",
                    LastName = "Austin",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("A930A5CF-2D6B-4D13-A5BA-4AECE0E48CF8"),
                    
                    //ManagerId = 5
                    ManagerId = Guid.Parse("3DACACF6-C451-41D9-9D86-79C24FA54A5D"),
                },
                new Employee {
                    
                    //Id = 17,
                    Id = Guid.Parse("7AC7C118-2E59-4833-8FB1-AC76428B8368"),
                    FirstName = "Valli",
                    LastName = "Pataballa",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("A930A5CF-2D6B-4D13-A5BA-4AECE0E48CF8"),
                    
                    //ManagerId = 5
                    ManagerId = Guid.Parse("3DACACF6-C451-41D9-9D86-79C24FA54A5D"),
                },
                new Employee {
                    
                    //Id = 18,
                    Id = Guid.Parse("BBC5C711-A0E0-45A4-8A6B-AEE708297E46"),
                    FirstName = "Diana",
                    LastName = "Lorentz",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("A930A5CF-2D6B-4D13-A5BA-4AECE0E48CF8"),
                    
                    //ManagerId = 5
                    ManagerId = Guid.Parse("3DACACF6-C451-41D9-9D86-79C24FA54A5D"),
                },
                new Employee {
                    
                    //Id = 19,
                    Id = Guid.Parse("8C31E42F-BDB3-49D0-B912-B1525BA2409B"),
                    FirstName = "Daniel",
                    LastName = "Faviet",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("DD4B442A-0E34-4A33-8FB2-5165BDCC6F2C"),
                    
                    //ManagerId = 6
                    ManagerId = Guid.Parse("01078C07-691B-4FCD-800C-7B03467DB41F"),
                },
                new Employee {
                    
                    //Id = 20,
                    Id = Guid.Parse("410E640D-40FD-4738-B60B-B5C01714D1D6"),
                    FirstName = "John",
                    LastName = "Chen",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("DD4B442A-0E34-4A33-8FB2-5165BDCC6F2C"),
                    
                    //ManagerId = 6
                    ManagerId = Guid.Parse("01078C07-691B-4FCD-800C-7B03467DB41F"),
                },
                new Employee {
                    
                    //Id = 21,
                    Id = Guid.Parse("DA17FCB1-5014-4C74-8AB7-BB42055E290B"),
                    FirstName = "Ismael",
                    LastName = "Sciarra",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("DD4B442A-0E34-4A33-8FB2-5165BDCC6F2C"),
                    
                    //ManagerId = 6
                    ManagerId = Guid.Parse("01078C07-691B-4FCD-800C-7B03467DB41F"),
                },
                new Employee {
                    
                    //Id = 22,
                    Id = Guid.Parse("2965AAAE-07A5-4501-8A76-BD89CEDCC9DE"),
                    FirstName = "Jose Manuel",
                    LastName = "Urman",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("DD4B442A-0E34-4A33-8FB2-5165BDCC6F2C"),
                    
                    //ManagerId = 6
                    ManagerId = Guid.Parse("01078C07-691B-4FCD-800C-7B03467DB41F"),
                },
                new Employee {
                    
                    //Id = 23,
                    Id = Guid.Parse("5C0857A0-6DC3-400C-8E93-C4E96CE9F7FA"),
                    FirstName = "Luis",
                    LastName = "Popp",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("DD4B442A-0E34-4A33-8FB2-5165BDCC6F2C"),
                    
                    //ManagerId = 6
                    ManagerId = Guid.Parse("01078C07-691B-4FCD-800C-7B03467DB41F"),
                },
                new Employee {
                    
                    //Id = 24,
                    Id = Guid.Parse("616DC526-8D1D-41E4-BE37-C80AD0A37BB6"),
                    FirstName = "Julia",
                    LastName = "Nayer",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("59FFEF4E-0B57-485E-A01E-56F227882A32"),
                    
                    //ManagerId = 7
                    ManagerId = Guid.Parse("BB20C8BA-86AC-4BC1-A0B6-7C22BD281834"),
                },
                new Employee {
                    
                    //Id = 25,
                    Id = Guid.Parse("B5D79DD3-ECCE-458F-8B5F-C8D377F21E0D"),
                    FirstName = "Irene",
                    LastName = "Mikkilineni",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("59FFEF4E-0B57-485E-A01E-56F227882A32"),
                    
                    //ManagerId = 7
                    ManagerId = Guid.Parse("BB20C8BA-86AC-4BC1-A0B6-7C22BD281834"),
                },
                new Employee {
                    
                    //Id = 26,
                    Id = Guid.Parse("02591430-6655-472F-8B4D-CCAD9725990E"),
                    FirstName = "James",
                    LastName = "Landry",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("59FFEF4E-0B57-485E-A01E-56F227882A32"),
                    
                    //ManagerId = 7
                    ManagerId = Guid.Parse("BB20C8BA-86AC-4BC1-A0B6-7C22BD281834"),
                },
                new Employee {
                    
                    //Id = 27,
                    Id = Guid.Parse("BE21C122-CE50-487E-93E7-CFAAEB2992AB"),
                    FirstName = "Steven",
                    LastName = "Markle",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("59FFEF4E-0B57-485E-A01E-56F227882A32"),
                    
                    //ManagerId = 7
                    ManagerId = Guid.Parse("BB20C8BA-86AC-4BC1-A0B6-7C22BD281834"),
                },
                new Employee {
                    
                    //Id = 28,
                    Id = Guid.Parse("82C71285-6896-4F33-82C6-CFCEBE26C0C7"),
                    FirstName = "Laura",
                    LastName = "Bissot",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("814DFFC8-AA86-45AC-BAFB-5B1443309B5F"),
                    
                    //ManagerId = 8
                    ManagerId = Guid.Parse("087A1C96-DE0F-4330-B21C-82C9512F91D5"),
                },
                new Employee {
                    
                    //Id = 29,
                    Id = Guid.Parse("37E7409C-E3FF-4A37-8B03-D44E4EF32250"),
                    FirstName = "Mozhe",
                    LastName = "Atkinson",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("814DFFC8-AA86-45AC-BAFB-5B1443309B5F"),
                    
                    //ManagerId = 8
                    ManagerId = Guid.Parse("087A1C96-DE0F-4330-B21C-82C9512F91D5"),
                },
                new Employee {
                    
                    //Id = 30,
                    Id = Guid.Parse("2EE10769-799B-444D-A595-D55089186CA9"),
                    FirstName = "James",
                    LastName = "Marlow",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("814DFFC8-AA86-45AC-BAFB-5B1443309B5F"),
                    
                    //ManagerId = 8
                    ManagerId = Guid.Parse("087A1C96-DE0F-4330-B21C-82C9512F91D5"),
                },
                new Employee {
                    
                    //Id = 31,
                    Id = Guid.Parse("C0C1351A-76C2-438B-A318-DB9A57D739FE"),
                    FirstName = "TJ",
                    LastName = "Olson",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("814DFFC8-AA86-45AC-BAFB-5B1443309B5F"),
                    
                    //ManagerId = 8
                    ManagerId = Guid.Parse("087A1C96-DE0F-4330-B21C-82C9512F91D5"),
                },
                new Employee {
                    
                    //Id = 32,
                    Id = Guid.Parse("BF4694D8-FAE4-4499-B465-DF27B81668A8"),
                    FirstName = "Jason",
                    LastName = "Mallin",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 9
                    ManagerId = Guid.Parse("3B527114-8EED-4BEE-A1A1-83699664A9CE"),
                },
                new Employee {
                    
                    //Id = 33,
                    Id = Guid.Parse("0662B018-3760-4B86-88C2-E7568EF72958"),
                    FirstName = "Michael",
                    LastName = "Rogers",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 9
                    ManagerId = Guid.Parse("3B527114-8EED-4BEE-A1A1-83699664A9CE"),
                },
                new Employee {
                    
                    //Id = 34,
                    Id = Guid.Parse("01622712-C0BD-4C42-A91E-EA149E4DE77B"),
                    FirstName = "Ki",
                    LastName = "Gee",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 9
                    ManagerId = Guid.Parse("3B527114-8EED-4BEE-A1A1-83699664A9CE"),
                },
                new Employee {
                    
                    //Id = 35,
                    Id = Guid.Parse("0B51241E-0F5D-41A9-9A28-EC4D0FD03B39"),
                    FirstName = "Hazel",
                    LastName = "Philtanker",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 9
                    ManagerId = Guid.Parse("3B527114-8EED-4BEE-A1A1-83699664A9CE"),
                },
                new Employee {
                    
                    //Id = 36,
                    Id = Guid.Parse("C3D60888-DA8B-481E-9BF5-EEF37F154EFD"),
                    FirstName = "Renske",
                    LastName = "Ladwig",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 10
                    ManagerId = Guid.Parse("08769C56-14B4-4574-BB55-85C0D1B5AEBC"),
                },
                new Employee {
                    
                    //Id = 37,
                    Id = Guid.Parse("3262DB26-8595-4297-9291-F3DF62757AD4"),
                    FirstName = "Stephen",
                    LastName = "Stiles",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 10
                    ManagerId = Guid.Parse("08769C56-14B4-4574-BB55-85C0D1B5AEBC"),
                },
                new Employee {
                    
                    //Id = 38,
                    Id = Guid.Parse("3F4FE214-BE81-41F7-8B7B-F9D78D2F1F26"),
                    FirstName = "John",
                    LastName = "Seo",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 10
                    ManagerId = Guid.Parse("08769C56-14B4-4574-BB55-85C0D1B5AEBC"),
                },
                new Employee {
                    
                    //Id = 39,
                    Id = Guid.Parse("B26AF6B7-1763-49A0-90AE-FFEE423B9284"),
                    FirstName = "Joshua",
                    LastName = "Patel",
                    
                    //RoleId = 1,
                    RoleId = Guid.Parse("C5B68F11-04D6-4A4D-82ED-64ED19E25C57"),
                    
                    //ManagerId = 10
                    ManagerId = Guid.Parse("08769C56-14B4-4574-BB55-85C0D1B5AEBC"),
                }
            };
        }
    }
}
