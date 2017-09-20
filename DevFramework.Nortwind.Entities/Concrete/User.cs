using DevFramework.Core.Entities;

namespace DevFramework.Nortwind.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}