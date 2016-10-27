using Microsoft.AspNet.Identity.EntityFramework;

namespace Northwind.Application.Security
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
