using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.Framework.DAL; // for the ChinookContext class
using Chinook.Framework.Entities; // for the Chinook database Entities
using Chinook.Framework.Entities.ViewModels; // for my DTOs/POCOs, etc.

namespace Chinook.Framework.BLL
{
    public class CustomerManager
    {
        public CustomerProfile GetProfile(int customerId)
        {
            // Access the database
            using (var context = new ChinookContext())
            {
                var profile = from person in context.Customers
                              where person.CustomerId == customerId
                              select new CustomerProfile()
                              {
                                  FirstName = person.FirstName,
                                  LastName = person.LastName,
                                  CompanyName = person.Company,
                                  StreetAddress = person.Address,
                                  City = person.City,
                                  State = person.State,
                                  Country = person.Country,
                                  PostalCode = person.PostalCode
                              };
                return profile.Single();
            }
        }
    }
}
