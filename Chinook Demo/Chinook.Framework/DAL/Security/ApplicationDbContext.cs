using Chinook.Framework.Entities.Security;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Chinook.Framework.DAL.Security
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
