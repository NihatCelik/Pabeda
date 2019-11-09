using Pabeda.Core.DataAccess.EntityFramework;
using Pabeda.Projem.DataAccess.Abstract;
using Pabeda.Projem.Entities.Concrete;

namespace Pabeda.Projem.DataAccess.Concrete.EntityFramework
{
    public class EFOkulDAL : EFEntityRepositoryBase<Okul, ProjemContext>, IOkulDAL
    {
    }
}
