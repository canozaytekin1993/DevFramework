using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);
    }
}