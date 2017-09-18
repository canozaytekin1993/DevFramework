using DevFramework.Core.Entities;

namespace DevFramework.Nortwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }       
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
