using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Entities
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal CurrentCost { get; set; }
        public bool Active { get; set; }
        public int? Calories { get; set; }
        public string Comment { get; set; }
        public int MenuCategoryID { get; set; }

        public virtual MenuCategory Category { get; set; }

    }
}
