using Microsoft.EntityFrameworkCore;

namespace Microservices.Product.API.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        public DbSet<Models.Product> Products {get; set;}
    }
}