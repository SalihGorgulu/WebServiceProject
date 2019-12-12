using Satici.Business.Abstract;
using Satici.DataAccess.Abstract;
using Satici.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satici.Business.Concrete
{
    class KategoriManager:IKategoriService
    {
        IKategoriDal _kategoriDal;

        public KategoriManager(IKategoriDal kategoriDal)//Entityframework de Nhibernate de atayabiliriz.
        {
            _kategoriDal = kategoriDal;
        }

        public List<Kategori> GetAll()
        {
            return _kategoriDal.GetAll();
        }
        public void Add(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
        }
        public void Update(Kategori kategori)
        {
            var exist = _kategoriDal.Get(i=>i.Id==kategori.Id);
            if (exist != null)
            {
                _kategoriDal.Update(kategori);
            }
            else
            {
              
            }

        }
        public void Delete(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
        }

        public bool Exist(Kategori kategori)
        {
            var exist= _kategoriDal.Get(i=>i.Id==kategori.Id);

            if (exist!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
