using eRestaurant.Entities.Pocos; // for MenuItem
using System.Collections.Generic; // for List<T>

// DTO stands for "Data Transfer Object".
// DTOs tend to be classes that have properties only, and those
// properties can be primitive types or programmer-defined types (e.g.: classes)
// POCOs (Plain Old CLR Objects) are classes with properties that are
// primitive (built-in) types only. CLR stands for the Common Language Runtime,
// which is the common language used in .NET environment. For example, both
// C# and VB.NET share an underlying common programming language environment
// (the CLR) that defines all the data types that are built into the operating
// system.
namespace eRestaurant.Entities.DTOs
{
    public class CategoryWithItems
    {
        public string Description { get; set; }
        public List<MenuItem> MenuItems { get; set; } // TODO: Change from IEnumerable
    }
}
