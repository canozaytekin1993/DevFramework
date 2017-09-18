using System;
using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Nortwind.Business.Abstract;
using DevFramework.Nortwind.Business.ValidationRules.FluentValidation;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Entities.Concrete;
using System.Collections.Generic;
using System.Transactions;
using DevFramework.Core.Aspects.Postsharp.TransactionAspects;
using DevFramework.Core.DataAccess;

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
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Add(Product product)
        {

            return _productDal.Add(product);
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _productDal.Add(product1);
                //  Business Codes
                _productDal.Update(product2);
            }

        }
    }
}
