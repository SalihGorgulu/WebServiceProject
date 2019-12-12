using Satici.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satici.Entities.Concrete
{
    public class Kategori:IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
}
