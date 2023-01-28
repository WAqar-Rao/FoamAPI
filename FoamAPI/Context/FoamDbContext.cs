using Microsoft.EntityFrameworkCore;

namespace FoamAPI.Context
{
    public class FoamDbContext : DbContext
    {
        public FoamDbContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Customer> Customers { get; set; }
    }
}
