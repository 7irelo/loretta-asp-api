using Microsoft.EntityFrameworkCore;
using LorettaSpringApi.Models;

namespace LorettaSpringApi.Data
{
    public class LorettaDbContext : DbContext
    {
        public LorettaDbContext(DbContextOptions<LorettaDbContext> options) : base(options) { }

        public DbSet<YourModel> YourModels { get; set; }
        // Add other DbSets as needed
    }
}
