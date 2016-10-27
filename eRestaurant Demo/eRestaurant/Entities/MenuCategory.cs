using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Entities
{
    public class MenuCategory
    {
        [Key]
        public int MenuCategoryID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Item> MenuItems { get; set; }
    }
}
