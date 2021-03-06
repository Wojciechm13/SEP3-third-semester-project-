using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Model
{
    public class Recipe
    {    
        [Key]
        [Required]
        public int recipeId { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string recipeName { get; set; }
        
        [Required]
        public string description { get; set; }

        [Required]
        public string instructions { get; set; }

        [Required]
        public int cookingTime { get; set; }
        
        [Required]
        public IList<Ingredient> ingredients { get; set; }
        
        [Required]
        public string imageName { get; set; }
        
        public Category category { get; set; }
        
        public IList<RecipeCategory> RecipeCategories;
        public IList<IngredientRecipe> IngredientRecipes;
    }
}