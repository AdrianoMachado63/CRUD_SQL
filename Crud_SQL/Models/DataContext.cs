using Microsoft.EntityFrameworkCore;
using Crud_SQL.Models;

namespace Crud_SQL.Models {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }
        public DbSet<Crud_SQL.Models.Customer> Customer { get; set; } = default!;
        
    }
}
