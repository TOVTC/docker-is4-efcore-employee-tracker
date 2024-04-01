using EmployeeTracker;
using EmployeeTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        private readonly EmployeeTrackerDbContext _context;
        public AboutController(EmployeeTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/about
        [HttpGet]
        public async Task<ActionResult<AboutUs>> GetAbout()
        {
            if (_context.About == null)
            {
                return NotFound();
            }

            return await _context.About
                .FirstOrDefaultAsync();
        }
    }
}
