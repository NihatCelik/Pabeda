using Pabeda.Projem.Entities.Concrete;
using System.Collections.Generic;

namespace Pabeda.Projem.Business.Abstract
{
    public interface IOgrenciService
    {
        List<Ogrenci> GetAll();
        Ogrenci GetByOgrenci(int ogrenciId);
        void Add(Ogrenci ogrenci);
        void Update(Ogrenci ogrenci);
        void Delete(int ogrenciID);
    }
}
