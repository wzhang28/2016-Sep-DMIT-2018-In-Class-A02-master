using Microsoft.AspNet.Identity.EntityFramework;

namespace Chinook.Framework.Entities.Security
{
    // You can add User data for the user by adding more properties to your User class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        // These custom properties will be used to associate a login user
        // with either an Employee or a Customer in the database
        // Notice that the data type matches the data types in the "related"
        // tables, but that it's also nullable.
        // Also note that there is NO foreign key constraint on our database.
        public int? EmployeeID { get; set; }
        public int? CustomerID { get; set; }
    }
}
