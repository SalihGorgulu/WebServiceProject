using Satici.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Satici.DataAccess.Concrete.EntityFramework
{
    class SaticiDataInitializer : CreateDatabaseIfNotExists<SaticiContext>
    {
        protected override void Seed(SaticiContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>() 
            { 
             new Kategori(){Adi="Telefon"},
             new Kategori(){Adi="Bilgisayar"},
             new Kategori(){Adi="Beyaz Eşya"}
            };


            context.Kategori.AddRange(kategoriler);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
