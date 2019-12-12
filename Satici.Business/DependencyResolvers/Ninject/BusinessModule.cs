using Ninject.Modules;
using Satici.Business.Abstract;
using Satici.Business.Concrete;
using Satici.DataAccess.Abstract;
using Satici.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satici.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IKategoriService>().To<KategoriManager>().InSingletonScope();
            Bind<IKategoriDal>().To<EfKategoriDal>().InSingletonScope();
        }
    }
}
//Araayüz kodu IProductService _productService = new ProductManager(new EfProductDal);-->IOC Geç
//Form'da parametreli constructor gönderemeyiz.
//InstanceFactory Ekledik