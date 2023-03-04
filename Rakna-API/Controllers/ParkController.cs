using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rakna_API.Data;

namespace Rakna_API.Controllers
{
    public class ParkController : Controller
    {
     
        private readonly ApplicationDbContext _context;
        public ParkController(ApplicationDbContext context) 
        {

            _context= context;
        }


        public async Task<IActionResult> Index()
        {
            var parks =await _context.Parks.ToListAsync();
            return Ok(parks);
        }
    }
}
