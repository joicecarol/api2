using Viagens.Model;
using Microsoft.EntityFrameworkCore;

namespace Viagens.Data
{


  public class DataContext : DbContext
  {

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }



    public DbSet<Viagen> Viagens { get; set; }
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Viagen>().HasData(
                new Viagen { Id = 1, Name = "The Witcher 3", Genre = "RPG", viagenURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png", Price = 59.99M},
                new Viagen { Id = 2, Name = "The Witcher 2", Genre = "RPG", viagenURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png",Price = 19.99M},
                new Viagen { Id = 3, Name = "The Witcher 1", Genre = "RPG", viagenURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png",Price = 9.99M},
                new Viagen { Id = 4, Name = "The Witcher 3", Genre = "RPG", viagenURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png",Price = 59.99M}
             
            );
        }



    }



}