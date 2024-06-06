using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPISample.DataLayer;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AirplanesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public AirplanesController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Airplane>>> GetProducts()
        {
            return await _context.Airplanes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Airplane>> GetProduct(int id)
        {
            var product = await _context.Airplanes.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
    }
}

