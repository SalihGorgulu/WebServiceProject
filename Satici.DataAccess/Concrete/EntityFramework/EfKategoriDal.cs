using Satici.DataAccess.Abstract;
using Satici.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satici.DataAccess.Concrete.EntityFramework
{
    public class EfKategoriDal:EfEntityRepositoryBase<Kategori,SaticiContext>,IKategoriDal
    {
    }
}
