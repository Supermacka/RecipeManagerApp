using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RecipeManager_Winform.Data;
using RecipeManager_Winform.Models;

#nullable disable

namespace RecipeManager_Winform
{
    public partial class RecipesContext : DbContext
    {
        public RecipesContext()
        {
        }

        public RecipesContext(DbContextOptions<RecipesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<Quantity> Quantities { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual DbSet<RecipeSource> RecipeSources { get; set; }
        public virtual DbSet<RecipeStep> RecipeSteps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Recipes;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding Data - PrePopulating DB with data
            modelBuilder.Seed();

            // Autocreated code by EF-core
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.ToTable("food_category");

                entity.Property(e => e.FoodCategoryId).HasColumnName("food_category_id");

                entity.Property(e => e.FoodCategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("food_category_name");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("ingredients");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.CaloriesPer100g).HasColumnName("calories (per 100g)");

                entity.Property(e => e.IngredientName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient_name");
            });

            modelBuilder.Entity<Measurement>(entity =>
            {
                entity.ToTable("measurements");

                entity.Property(e => e.MeasurementId).HasColumnName("measurement_id");

                entity.Property(e => e.MeasurementName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("measurement_name");
            });

            modelBuilder.Entity<Quantity>(entity =>
            {
                entity.ToTable("quantity");

                entity.Property(e => e.QuantityId).HasColumnName("quantity_id");

                entity.Property(e => e.Quantity1).HasColumnName("quantity");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("recipe");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FoodCategoryId).HasColumnName("food_category_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.RecipeDescription).HasColumnName("recipe_description");

                entity.Property(e => e.RecipeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("recipe_name");

                entity.Property(e => e.RecipeSourceId).HasColumnName("recipe_source_id");

                entity.HasOne(d => d.FoodCategory)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.FoodCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__recipe__food_cat__4222D4EF");

                entity.HasOne(d => d.RecipeSource)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.RecipeSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_recipe_recipe_source");
            });

            modelBuilder.Entity<RecipeIngredient>(entity =>
            {
                entity.ToTable("recipe_ingredients");

                entity.Property(e => e.RecipeIngredientId).HasColumnName("recipe_Ingredient_id");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.MeasurementId).HasColumnName("measurement_id");

                entity.Property(e => e.QuantityId).HasColumnName("quantity_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__recipe_in__ingre__14270015");

                entity.HasOne(d => d.Measurement)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.MeasurementId)
                    .HasConstraintName("FK__recipe_in__measu__160F4887");

                entity.HasOne(d => d.Quantity)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.QuantityId)
                    .HasConstraintName("FK__recipe_in__quant__151B244E");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeIngredients)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__recipe_in__recip__1332DBDC");
            });

            modelBuilder.Entity<RecipeSource>(entity =>
            {
                entity.ToTable("recipe_source");

                entity.Property(e => e.RecipeSourceId).HasColumnName("recipe_source_id");

                entity.Property(e => e.RecipeSourceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("recipe_source_name");

                entity.Property(e => e.RecipeSourceUrl).HasColumnName("recipe_source_URL");
            });

            modelBuilder.Entity<RecipeStep>(entity =>
            {
                entity.HasKey(e => e.StepId)
                    .HasName("PK__Recipe_s__B2E1DE81D1F8BA13");

                entity.ToTable("recipe_steps");

                entity.Property(e => e.StepId).HasColumnName("step_id");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.StepDescription).HasColumnName("step_description");

                entity.Property(e => e.StepNumber).HasColumnName("step_number");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeSteps)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recipe_st__recip__5CD6CB2B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
