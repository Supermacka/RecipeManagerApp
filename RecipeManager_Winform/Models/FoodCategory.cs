using System;
using System.Collections.Generic;
using RecipeManager_Winform;

#nullable disable

namespace RecipeManager_Winform.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int FoodCategoryId { get; set; }
        public string FoodCategoryName { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
