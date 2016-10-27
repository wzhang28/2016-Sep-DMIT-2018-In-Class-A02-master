using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Application.DataModels
{
    public class SalesRepresentative
    {
        public SalesRepresentative()
        {
            
        }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public byte[] CleanPhoto
        {
            get
            {
                return Photo.Skip(78).ToArray();
            }
        }
    }
}
