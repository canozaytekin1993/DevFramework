using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
