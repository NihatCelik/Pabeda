using Pabeda.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pabeda.Projem.Entities.Concrete
{
    public class Okul : IEntity
    {
        public int OkulId { get; set; }

        public string OkulAdi { get; set; }

        public string Adres { get; set; }

        public string Sehir { get; set; }

        public string Ilce { get; set; }

        public ICollection<Ogretmen> Ogretmens { get; set; }
    }
}
