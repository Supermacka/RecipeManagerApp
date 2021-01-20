using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeManager_Winform.Data
{
    class LoadRecipes
    {
        public string Source { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public int? Rating { get; set; }
        public double Calories { get; set; }
    }
}
