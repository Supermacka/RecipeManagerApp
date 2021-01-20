using System;
using System.Collections.Generic;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class Quantity
    {
        public Quantity()
        {
            RecipeIngredients = new HashSet<RecipeIngredient>();
        }

        public int QuantityId { get; set; }
        public double? Quantity1 { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
