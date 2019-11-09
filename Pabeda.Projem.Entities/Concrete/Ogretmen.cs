using Pabeda.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pabeda.Projem.Entities.Concrete
{
    public class Ogretmen : IEntity
    {
        public int OgretmenId { get; set; }

        public string Isim { get; set; }

        public string Soyisim { get; set; }

        public string TCKimlikNo { get; set; }

        public ICollection<OgretmenOgrenci> OgretmenOgrencis { get; set; }
    }
}
