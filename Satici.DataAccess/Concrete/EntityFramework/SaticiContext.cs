using Satici.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satici.DataAccess.Concrete.EntityFramework
{
    public class SaticiContext:DbContext
    {
        public SaticiContext():base("SaticiContext")
        {
            Database.SetInitializer(new SaticiDataInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().ToTable("Kategori","Satici");
            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<Kategori> Kategori { get; set; }
    }
}
