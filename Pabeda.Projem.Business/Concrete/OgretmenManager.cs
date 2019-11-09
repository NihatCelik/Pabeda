using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.DataAccess.Abstract;
using Pabeda.Projem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pabeda.Projem.Business.Concrete
{
    public class OgretmenManager : IOgretmenService
    {
        private IOgretmenDAL _ogretmenDAL;
        public OgretmenManager(IOgretmenDAL ogretmenDAL)
        {
            _ogretmenDAL = ogretmenDAL;
        }

        public Ogretmen GetByOgretmen(int ogretmenId)
        {
            return _ogretmenDAL.GetList(u => u.OgretmenId == ogretmenId).FirstOrDefault();
        }

        public List<Ogretmen> GetAll()
        {
            return _ogretmenDAL.GetList();
        }

        public void Add(Ogretmen ogretmen)
        {
            _ogretmenDAL.Add(ogretmen);
        }

        public void Update(Ogretmen ogretmen)
        {
            _ogretmenDAL.Update(ogretmen);
        }

        public void Delete(int ogretmenId)
        {
            _ogretmenDAL.Delete(new Ogretmen { OgretmenId = ogretmenId });
        }
    }
}
