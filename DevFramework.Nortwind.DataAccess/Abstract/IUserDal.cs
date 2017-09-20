using DevFramework.Core.DataAccess;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        
    }
}