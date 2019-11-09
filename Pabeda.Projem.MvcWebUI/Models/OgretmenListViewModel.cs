using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pabeda.Projem.Entities.Concrete;

namespace Pabeda.Projem.MvcWebUI.Models
{
    public class OgretmenListViewModel
    {
        public IEnumerable<Ogretmen> Ogretmens { get; internal set; }
    }
}
