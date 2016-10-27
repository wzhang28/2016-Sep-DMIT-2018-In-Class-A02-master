using System;
using System.Collections.Generic;
using System.Linq;
using eRestaurant.DAL; // for RestaurantContext
using eRestaurant.Entities.DTOs; // for CategoryWithItems
using eRestaurant.Entities.Pocos; // for MenuItem

namespace eRestaurant.BLL
{
    public class MenuController
    {
        public List<CategoryWithItems> GetRestaurantMenu()
        {
            // We want to access the DAL - using the RestaurantContext - to work with the database
            // BUT, we also want to be careful to make sure any lingering open connections
            // to the database are close if anything were to go wrong.
            // The using statement helps us with
            using (var context = new RestaurantContext())
            {
                // Any errors inside this statement block won't be a problem
                // in terms of leaving database connection open
                var data = from aCategory in context.MenuCategories
                           orderby aCategory.Description
                           select new CategoryWithItems()
                           {
                               Description = aCategory.Description,
                               MenuItems = (from item in aCategory.MenuItems
                                           orderby item.Description
                                           select new MenuItem()
                                           {
                                               Description = item.Description,
                                               Price = item.CurrentPrice,
                                               Calories = item.Calories,
                                               Comment = item.Comment
                                           }).ToList()
                           };
                return data.ToList();
            }
        }
    }
}
