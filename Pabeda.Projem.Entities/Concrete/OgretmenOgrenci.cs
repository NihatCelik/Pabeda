using System;
using System.Collections.Generic;
using System.Text;

namespace Pabeda.Projem.Entities.Concrete
{
    public class OgretmenOgrenci
    {
        public int OgretmenOgrenciId { get; set; }
        public int OgretmenId { get; set; }
        public Ogretmen Ogretmen { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
