using DevFramework.Core.DataAccess;
using DevFramework.Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {

    }
}
