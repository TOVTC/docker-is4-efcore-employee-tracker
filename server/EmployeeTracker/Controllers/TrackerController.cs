using EmployeeTracker;
using EmployeeTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class TrackerController : ControllerBase
    {
        private readonly EmployeeTrackerDbContext _context;
        public TrackerController(EmployeeTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/tracker/departments
        [HttpGet("departments")]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            if (_context.Departments == null)
            {
                return NotFound();
            }

            return await _context.Departments
                .Include(d => d.Roles)
                .ToListAsync();
        }

        // GET: api/tracker/employees
        [HttpGet("roles")]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            if (_context.Roles == null)
            {
                return NotFound();
            }
            return await _context.Roles
                .ToListAsync ();
        }

        // GET: api/tracker/employees
        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            if (_context.Employees == null)
            {
                return NotFound();
            }
            return await _context.Employees
                .ToListAsync();
        }
    }
}
