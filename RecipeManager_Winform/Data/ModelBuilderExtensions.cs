using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RecipeManager_Winform.Models;

namespace RecipeManager_Winform.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Global values
            FoodCategory(modelBuilder);
            RecipeSource(modelBuilder);

            Ingredients(modelBuilder);
            Quantity(modelBuilder);
            Measurement(modelBuilder);

            RecipeIngredients(modelBuilder);

            // Recipe values
            Recipe1(modelBuilder);
            RecipeSteps1(modelBuilder);
        }

        public static void FoodCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>().HasData
            (
                new FoodCategory
                {
                    FoodCategoryId = 1,
                    FoodCategoryName = "Huvudrätt"
                },
                new FoodCategory
                {
                    FoodCategoryId = 2,
                    FoodCategoryName = "Efterrätt"
                }
            );
        }
        public static void RecipeSource(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeSource>().HasData
            (
                new RecipeSource
                {
                    RecipeSourceId = 1,
                    RecipeSourceName = "ICA",
                    RecipeSourceUrl = @"https://www.ica.se/recept"
                },
                new RecipeSource
                {
                    RecipeSourceId = 2,
                    RecipeSourceName = "Arla",
                    RecipeSourceUrl = @"https://www.arla.se/recept"
                }
            );
        }

        public static void Ingredients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData
            (
                new Ingredient
                {
                    IngredientId = 1,
                    IngredientName = "ris",
                    CaloriesPer100g = 130
                },
                new Ingredient
                {
                    IngredientId = 2,
                    IngredientName = "gul lök",
                    CaloriesPer100g = (double?)39.7
                },
                new Ingredient
                {
                    IngredientId = 3,
                    IngredientName = "olja",
                    CaloriesPer100g = (double?)884.1
                },
                new Ingredient
                {
                    IngredientId = 4,
                    IngredientName = "vitlöksklyfta",
                    CaloriesPer100g = 160
                },
                new Ingredient
                {
                    IngredientId = 5,
                    IngredientName = "curry",
                    CaloriesPer100g = 325
                },
                new Ingredient
                {
                    IngredientId = 6,
                    IngredientName = "tomatpure",
                    CaloriesPer100g = 82
                },
                new Ingredient
                {
                    IngredientId = 7,
                    IngredientName = "kokosmjölk",
                    CaloriesPer100g = (double?)229.9
                },
                new Ingredient
                {
                    IngredientId = 8,
                    IngredientName = "vatten",
                    CaloriesPer100g = 0
                },
                new Ingredient
                {
                    IngredientId = 9,
                    IngredientName = "grönsaksbuljongtärning",
                    CaloriesPer100g = (double?)437.8
                },
                new Ingredient
                {
                    IngredientId = 10,
                    IngredientName = "torkade röda linser",
                    CaloriesPer100g = 125
                },
                new Ingredient
                {
                    IngredientId = 11,
                    IngredientName = "sambal oelek",
                    CaloriesPer100g = 21
                },
                new Ingredient
                {
                    IngredientId = 12,
                    IngredientName = "körsbärstomater",
                    CaloriesPer100g = 18
                },
                new Ingredient
                {
                    IngredientId = 13,
                    IngredientName = "salt",
                    CaloriesPer100g = 0,
                },
                new Ingredient
                {
                    IngredientId = 14,
                    IngredientName = "peppar",
                    CaloriesPer100g = 251
                },
                new Ingredient
                {
                    IngredientId = 15,
                    IngredientName = "kruka koriander",
                    CaloriesPer100g = 298
                }
            );
        }
        public static void Quantity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quantity>().HasData
            (
                new Quantity
                {
                    QuantityId = 1,
                    Quantity1 = 100
                },
                new Quantity
                {
                    QuantityId = 2,
                    Quantity1 = 10
                },
                new Quantity
                {
                    QuantityId = 3,
                    Quantity1 = 200
                },
                new Quantity
                {
                    QuantityId = 4,
                    Quantity1 = 400
                },
                new Quantity
                {
                    QuantityId = 5,
                    Quantity1 = 500
                },
                new Quantity
                {
                    QuantityId = 6,
                    Quantity1 = 250
                },
                new Quantity
                {
                    QuantityId = 7,
                    Quantity1 = 450
                },
                new Quantity
                {
                    QuantityId = 8,
                    Quantity1 = (double?) 15
                }
            );
        }
        public static void Measurement(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Measurement>().HasData
            (
                new Measurement
                {
                    MeasurementId = 1,
                    MeasurementName = "msk"
                },
                new Measurement
                {
                    MeasurementId = 2,
                    MeasurementName = "tsk"
                },
                new Measurement
                {
                    MeasurementId = 3,
                    MeasurementName = "ml"
                },
                new Measurement
                {
                    MeasurementId = 4,
                    MeasurementName = "dl"
                },
                new Measurement
                {
                    MeasurementId = 5,
                    MeasurementName = "g"
                }
            );
        }

        public static void RecipeIngredients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>().HasData
            (
                new RecipeIngredient
                {
                    RecipeIngredientId = 1,
                    RecipeId = 1,
                    IngredientId = 1,
                    QuantityId = 1
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 2,
                    RecipeId = 1,
                    IngredientId = 2,
                    QuantityId = 2
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 3,
                    RecipeId = 1,
                    IngredientId = 3,
                    QuantityId = 2,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 4,
                    RecipeId = 1,
                    IngredientId = 4,
                    QuantityId = 2
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 5,
                    RecipeId = 1,
                    IngredientId = 5,
                    QuantityId = 2,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 6,
                    RecipeId = 1,
                    IngredientId = 6,
                    QuantityId = 3,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 7,
                    RecipeId = 1,
                    IngredientId = 7,
                    QuantityId = 4,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 8,
                    RecipeId = 1,
                    IngredientId = 8,
                    QuantityId = 5,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 9,
                    RecipeId = 1,
                    IngredientId = 9,
                    QuantityId = 2
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 10,
                    RecipeId = 1,
                    IngredientId = 10,
                    QuantityId = 3,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 11,
                    RecipeId = 1,
                    IngredientId = 11,
                    QuantityId = 2,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 12,
                    RecipeId = 1,
                    IngredientId = 1,
                    QuantityId = 6,
                    MeasurementId = 5
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 13,
                    RecipeId = 1,
                    IngredientId = 13
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 14,
                    RecipeId = 1,
                    IngredientId = 14
                },
                new RecipeIngredient
                {
                    RecipeIngredientId = 15,
                    RecipeId = 1,
                    IngredientId = 15,
                    QuantityId = 2
                }
            );
        }

        public static void Recipe1(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
            new Recipe
            {
                RecipeId = 1,
                FoodCategoryId = 1,
                RecipeSourceId = 1,
                RecipeName = "Linsgryta med kokosmjölk",
                RecipeDescription = "Krämig och matig linsgryta värmer skönt en kall höstkväll. Grytan är smaksatt med vitlök, curry och sambal oelek och gjord med kokosmjölk för extra krämighet. Servera med ris, halverade körsbärstomater och toppa med färsk koriander.",
                Duration = 45,
                Rating = 302
            });
        }
        public static void RecipeSteps1(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeStep>().HasData
            (
                new RecipeStep
                {
                    StepId = 1,
                    RecipeId = 1,
                    StepNumber = 1,
                    StepDescription = "Koka riset enligt anvisningen på förpackningen."
                },
                new RecipeStep
                {
                    StepId = 2,
                    RecipeId = 1,
                    StepNumber = 2,
                    StepDescription = "Skala och hacka löken. Fräs den i oljan i en gryta.Pressa i vitlök och tillsätt curry och tomatpuré och fräs ytterligare någon minut."
                },
                new RecipeStep
                {
                    StepId = 3,
                    RecipeId = 1,
                    StepNumber = 3,
                    StepDescription = "Rör i kokosmjölk, vatten, smulad buljongtärning, linser och sambal oelek.Låt koka ca 10 minuter eller enligt anvisningen på linsförpackningen."
                },
                new RecipeStep
                {
                    StepId = 4,
                    RecipeId = 1,
                    StepNumber = 4,
                    StepDescription = "Dela tomaterna och vänd ner dem i grytan mot slutet av koktiden eller servera dem till. Smaka av grytan med salt och peppar. "
                },
                new RecipeStep
                {
                    StepId = 5,
                    RecipeId = 1,
                    StepNumber = 5,
                    StepDescription = "Servera grytan med ris och tomater och toppa med koriander."
                }
            );
        }
    }
}
