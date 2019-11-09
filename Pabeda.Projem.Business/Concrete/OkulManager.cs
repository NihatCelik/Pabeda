using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.DataAccess.Abstract;
using Pabeda.Projem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pabeda.Projem.Business.Concrete
{
    public class OkulManager : IOkulService
    {
        private IOkulDAL _okulDAL;
        public OkulManager(IOkulDAL okulDAL)
        {
            _okulDAL = okulDAL;
        }
        public List<Okul> GetAll()
        {
            return _okulDAL.GetList();
        }

        public Okul GetByOkul(int okulId)
        {
            return _okulDAL.GetList(u => u.OkulId == okulId).FirstOrDefault();
        }

        public void Add(Okul okul)
        {
            _okulDAL.Add(okul);
        }

        public void Update(Okul okul)
        {
            _okulDAL.Update(okul);
        }

        public void Delete(int okulId)
        {
            _okulDAL.Delete(new Okul { OkulId = okulId });
        }
    }
}
