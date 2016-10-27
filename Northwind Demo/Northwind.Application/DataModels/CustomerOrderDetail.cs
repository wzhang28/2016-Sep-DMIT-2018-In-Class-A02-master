using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class CustomerOrderDetail
    {
        public CustomerOrderDetail()
        {
            
        }
        public string Item { get; set; }
        public string Unit { get; set; }
        public short OrderQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public double Discount { get; set; }
    }
}
