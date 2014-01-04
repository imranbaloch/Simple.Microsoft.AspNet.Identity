using System.Data.Entity;

namespace Simple.Microsoft.AspNet.Identity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public virtual IDbSet<ApplicationUser> Users { get; set; }
    }

}
