using System.Data.Entity;

namespace KendoUI.Models
{
    public class MicropowerMembersEntities : System.Data.Entity.DbContext
    {

        public DbSet<ContactModel> Contacts { get; set; }

    }
}
