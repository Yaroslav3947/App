using App.Enteties;
using Microsoft.EntityFrameworkCore;

namespace App.Contex {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }
        public DbSet<ProductEntity> Products{ get; set; }
    }
}
