using Pabeda.Projem.Entities.Concrete;
using System.Collections.Generic;

namespace Pabeda.Projem.Business.Abstract
{
    public interface IOkulService
    {
        List<Okul> GetAll();
        Okul GetByOkul(int okulId);
        void Add(Okul okul);
        void Update(Okul okul);
        void Delete(int okulId);

    }
}
