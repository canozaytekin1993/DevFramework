using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.Business.Concrate.Managers;
using DevFramework.Nortwind.Entities.Concrete;
using FluentValidation;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
