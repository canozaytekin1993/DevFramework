using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.ComplexTypes;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }       
        }
    }
}
