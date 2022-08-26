using Microsoft.EntityFrameworkCore;
using MovieIndexWeb.Models;

namespace MovieIndexWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Category> Categories{ get; set; }
    }
}
