using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Model
{
    public class CoffeeContext :DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options):base (options) { }
        public Coffee coffee { get; set; }
    }
}
