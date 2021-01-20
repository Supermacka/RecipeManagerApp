using System;
using System.Collections.Generic;
using RecipeManager_Winform.Models;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class Recipe
    {
        public Recipe()
        {
            RecipeIngredients = new HashSet<RecipeIngredient>();
            RecipeSteps = new HashSet<RecipeStep>();
        }

        public int RecipeId { get; set; }
        public int FoodCategoryId { get; set; }
        public int RecipeSourceId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public int? Duration { get; set; }
        public int? Rating { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }
        public virtual RecipeSource RecipeSource { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual ICollection<RecipeStep> RecipeSteps { get; set; }
    }
}
