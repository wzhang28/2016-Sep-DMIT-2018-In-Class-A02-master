using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class ShipDetails
    {
        public ShipDetails()
        {
            
        }
        public DateTime? ShippedOn { get; set; }
        public string Shipper { get; set; }
        public ShipAddress ShipTo { get; set; }
    }
}
