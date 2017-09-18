using DevFramework.Nortwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.CrossCuttingConcerns.Validation.FluentValidaion;
using DevFramework.Nortwind.Business.ValidationRules.FluentValidation;
using DevFramework.Nortwind.Entities.Concrete;
using DevFramework.Nortwind.DataAccess.Abstract;

namespace DevFramework.Nortwind.Business.Concrate.Managers
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
        [FluentValidation(typeof(ProductValidatior))]
        public Product Add(Product product)
        {
            
            return _productDal.Add(product);
        }
        [FluentValidation(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
