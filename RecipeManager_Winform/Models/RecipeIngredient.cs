using System;
using System.Collections.Generic;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class RecipeIngredient
    {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int? QuantityId { get; set; }
        public int? MeasurementId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Measurement Measurement { get; set; }
        public virtual Quantity Quantity { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
