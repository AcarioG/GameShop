using System.Data.Entity;

namespace Gshop.Models
{
  
        public class ApplicationDbContext : DbContext
        {
            public DbSet<Customer> Customers { get; set; }
            public DbSet<MembershipType> MembershipTypes { get; set; }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<Console> Consoles { get; set; }
            public DbSet<Game> Games { get; set; }
            public DbSet<BuyGame> BuyGames { get; set; }
            public DbSet<BuyConsole> BuyConsoles { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
            {
            }
            
            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    }