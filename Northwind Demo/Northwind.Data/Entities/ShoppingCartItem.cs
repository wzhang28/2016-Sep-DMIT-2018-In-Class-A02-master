namespace Northwind.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }

        public int ShoppingCartID { get; set; }

        [Required]
        [StringLength(10)]
        public string ProductID { get; set; }

        public int Quantity { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
