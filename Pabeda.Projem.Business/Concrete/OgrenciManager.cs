using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.DataAccess.Abstract;
using Pabeda.Projem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pabeda.Projem.Business.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDAL _ogrenciDAL;
        public OgrenciManager(IOgrenciDAL ogrenciDAL)
        {
            _ogrenciDAL = ogrenciDAL;
        }

        public List<Ogrenci> GetAll()
        {
            return _ogrenciDAL.GetList();
        }

        public Ogrenci GetByOgrenci(int ogrenciId)
        {
            return _ogrenciDAL.GetList(u => u.OgrenciId == ogrenciId).FirstOrDefault();
        }

        public void Add(Ogrenci ogrenci)
        {
            _ogrenciDAL.Add(ogrenci);
        }

        public void Update(Ogrenci ogrenci)
        {
            _ogrenciDAL.Update(ogrenci);
        }

        public void Delete(int ogrenciID)
        {
            _ogrenciDAL.Delete(new Ogrenci { OgrenciId = ogrenciID });
        }
    }
}
