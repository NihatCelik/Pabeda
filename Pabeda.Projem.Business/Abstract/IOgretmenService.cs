using Pabeda.Projem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pabeda.Projem.Business.Abstract
{
    public interface IOgretmenService
    {
        List<Ogretmen> GetAll();
        Ogretmen GetByOgretmen(int ogretmenId);
        void Add(Ogretmen ogretmen);
        void Update(Ogretmen ogretmen);
        void Delete(int ogretmen);

    }
}
