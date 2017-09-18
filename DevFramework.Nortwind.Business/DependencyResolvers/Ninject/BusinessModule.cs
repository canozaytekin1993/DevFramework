using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Nortwind.Business.Abstract;
using DevFramework.Nortwind.Business.Concrate.Managers;
using DevFramework.Nortwind.DataAccess.Abstract;
using DevFramework.Nortwind.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System.Data.Entity;

namespace DevFramework.Nortwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
        }
    }
}
