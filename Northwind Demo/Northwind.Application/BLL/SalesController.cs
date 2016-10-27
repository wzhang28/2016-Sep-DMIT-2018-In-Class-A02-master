using Northwind.Application.DataModels;
using Northwind.Data.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.BLL
{
    [DataObject]
    public class SalesController
    {
        public CustomerHistory GetCustomerHistory(string customerId)
        {
            using (var context = new NorthwindContext())
            {
                var results = from data in context.Customers
                              where data.CustomerID == customerId
                              select new CustomerHistory()
                              {
                                  CompanyName = data.CompanyName,
                                  ContactName = data.ContactName,
                                  ContactTitle = data.ContactTitle,
                                  Address = data.Address,
                                  City = data.City,
                                  Region = data.Region,
                                  Country = data.Country,
                                  Orders = from order in data.Orders
                                           select new CustomerOrder()
                                           {
                                               OrderedOn = order.OrderDate,
                                               RequiredBy = order.RequiredDate,
                                               Shipping = new ShipDetails()
                                               {
                                                   ShippedOn = order.ShippedDate,
                                                   Shipper = order.Shipper.CompanyName,
                                                   ShipTo = new ShipAddress()
                                                   {
                                                       CareOf = order.ShipName,
                                                       Address = order.ShipAddress,
                                                       City = order.ShipCity,
                                                       Region = order.ShipRegion,
                                                       Country = order.ShipCountry
                                                   }
                                               },
                                               OrderDetails = from detail in order.Order_Details
                                                              select new CustomerOrderDetail()
                                                              {
                                                                  Item = detail.Product.ProductName,
                                                                  Unit = detail.Product.QuantityPerUnit,
                                                                  OrderQuantity = detail.Quantity,
                                                                  UnitPrice = detail.UnitPrice,
                                                                  Discount = detail.Discount
                                                              },
                                               SalesRep = new SalesRepresentative()
                                               {
                                                   Name = order.Employee.FirstName + " " + order.Employee.LastName,
                                                   Photo = order.Employee.Photo
                                               }
                                           }
                              };
                return results.SingleOrDefault();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Customer> ListCustomers()
        {
            using (var context = new NorthwindContext())
            {
                var customers = from buyer in context.Customers
                                select new Customer
                                {
                                    CustomerId = buyer.CustomerID,
                                    CompanyName = buyer.CompanyName,
                                    ContactName = buyer.ContactName,
                                    ContactTitle = buyer.ContactTitle,
                                    Address = buyer.Address,
                                    City = buyer.City,
                                    Region = buyer.Region,
                                    Country = buyer.Country
                                };
                return customers.ToList();
            }
        }
    }
}
