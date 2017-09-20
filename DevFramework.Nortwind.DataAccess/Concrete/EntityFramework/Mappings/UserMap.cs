using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using DevFramework.Nortwind.Entities.Concrete;

namespace DevFramework.Nortwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        /// <summary>
        /// Bunların tamamını aslında Generater kullanarak ordan birçok şeyi yapabilirsiniz.
        /// Bu yüzden kendinize generator yazmak daha iyi olur.
        /// </summary>
        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.Password).HasColumnName("Password");
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.FirstName).HasColumnName("FirstName");
        }
    }
}