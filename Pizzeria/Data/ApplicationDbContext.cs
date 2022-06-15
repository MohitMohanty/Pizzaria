using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<PizzaOrderModel> PizzaOrdersModel { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        
        }
    }

}
