using Satici.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satici.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetAll();

        void Add(Kategori kategori);

        void Delete(Kategori kategori);

        void Update(Kategori kategori);

        bool Exist(Kategori kategori);
    }
}
