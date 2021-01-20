using System;
using System.Collections.Generic;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class RecipeSource
    {
        public RecipeSource()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int RecipeSourceId { get; set; }
        public string RecipeSourceName { get; set; }
        public string RecipeSourceUrl { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
