using Microsoft.EntityFrameworkCore;
using WebAPISample.Models;

namespace WebAPISample.DataLayer
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Airplane> Airplanes { get; set; }
    }
}
