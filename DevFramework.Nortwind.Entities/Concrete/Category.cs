using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Nortwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public virtual int CategoryId { get; set; }

        public virtual string CategoryName { get; set; }
    }
}
