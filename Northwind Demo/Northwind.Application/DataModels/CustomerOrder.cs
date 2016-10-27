using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class CustomerOrder
    {
        public CustomerOrder()
        {
            
        }
        public DateTime? OrderedOn { get; set; }
        public DateTime? RequiredBy { get; set; }
        public ShipDetails Shipping { get; set; }
        public IEnumerable<CustomerOrderDetail> OrderDetails { get; set; }
        public SalesRepresentative SalesRep { get; set; }
    }
}
