using DevFramework.Nortwind.Business.Abstract;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.Business.Concrate.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }

    }
}