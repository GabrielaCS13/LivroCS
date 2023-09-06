using Microsoft.EntityFrameworkCore;
using Livro.Models;

namespace Livro.Data
{
    public class ApplicationDBContext : DbContext
    {
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {

            }
            public DbSet<livro> Livro { get; set; }
        
    }
}
