using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class ShipAddress
    {
        public ShipAddress()
        {
            
        }
        public string CareOf { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Care of {CareOf} {Address} {City} {Region} {Country}";
        }
    }
}
