using System;
using System.Collections.Generic;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class Measurement
    {
        public Measurement()
        {
            RecipeIngredients = new HashSet<RecipeIngredient>();
        }

        public int MeasurementId { get; set; }
        public string MeasurementName { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
