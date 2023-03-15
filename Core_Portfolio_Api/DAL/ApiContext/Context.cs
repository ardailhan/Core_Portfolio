using Core_Portfolio_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Portfolio_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CorePortfolioDB2;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }

}
