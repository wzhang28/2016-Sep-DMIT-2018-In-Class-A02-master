<Query Kind="Expression">
  <Connection>
    <ID>9f9247bb-9e23-41f1-acce-a0dcbb0c2106</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>NorthwindExtended</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Select customer history with order details from Northwind Traders
from data in Customers
select new // CustomerHistory
{
    CompanyName = data.CompanyName,
    ContactName = data.ContactName,
    ContactTitle = data.ContactTitle,
    Address = data.Address,
    City = data.City,
    Region = data.Region,
    Country = data.Country,
    Orders = from order in data.Orders
             select new // CustomerOrder
    {
        OrderedOn = order.OrderDate,
        RequiredBy = order.RequiredDate,
        Shipping = new // ShipDetails
        {
            ShippedOn = order.ShippedDate,
            Shipper = order.ShipViaShipper.CompanyName,
            ShipTo = new // ShipAddress
            {
                CareOf = order.ShipName,
                Address = order.ShipAddress,
                City = order.ShipCity,
                Region = order.ShipRegion,
                Country = order.ShipCountry
            }
        },
        OrderDetails = from detail in order.OrderDetails
                       select new // CustomerOrderDetail
        {
            Item = detail.Product.ProductName,
            Unit = detail.Product.QuantityPerUnit,
            OrderQuantity = detail.Quantity,
            UnitPrice = detail.UnitPrice,
            Discount = detail.Discount
        },
        SalesRep = new // SalesRepresentative
        {
            Name = order.Employee.FirstName + " " + order.Employee.LastName,
            Photo = order.Employee.Photo
        }
    }
}