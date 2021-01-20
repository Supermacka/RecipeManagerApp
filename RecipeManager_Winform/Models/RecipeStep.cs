using System;
using System.Collections.Generic;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class RecipeStep
    {
        public int StepId { get; set; }
        public int RecipeId { get; set; }
        public int? StepNumber { get; set; }
        public string StepDescription { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
