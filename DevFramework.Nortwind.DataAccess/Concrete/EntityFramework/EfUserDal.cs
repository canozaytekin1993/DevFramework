using System.Collections.Generic;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.ComplexTypes;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        public List<UserRole> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Users
            }
        }
    }
}