using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class RentACarContext:DbContext
    {
        //projem hangi veri tabanı ile ilişkili 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql server kullanıcaz. o zaman sql server a nasıl bağlanacagımı belirtmem lazım.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentACar;Trusted_Connection=true");
        }


        //Benim hangi class ım hangi tabloya karşılık gelmeli.Aşağıda yazdıklarım veri tabanına yansıyacak olan tablolarım.
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        
    }
}
