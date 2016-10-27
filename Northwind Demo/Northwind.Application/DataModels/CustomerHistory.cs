using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class CustomerHistory : Customer
    {
        public CustomerHistory()
        {

        }
        public IEnumerable<CustomerOrder> Orders { get; set; }
    }
}
