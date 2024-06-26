﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimukaiRecipeApp
{
    internal class Recipe
    {
        //Declaration of global arrays
        public string recipeName;//store name of recipe
        public string[] ingredientName;//This variable holds the array of all ingredient names
        public double[] ingredientQuantity;//This variable holds the array of all ingredient quantities
        public string[] measurement;//This variable holds the array of all ingredient measurements
        public string[] description;//This variable holds the array of the descriptions of all the steps for a recipe.

        public string RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; } 
        }
        public string[] arr_IngredientName
        {
            get { return ingredientName; }
            set { ingredientName = value; }
        }
        public double[] arr_Quantity
        {
            get { return ingredientQuantity; }
            set { ingredientQuantity = value; }
        }
        public string[] arr_Measurements
        {
            get { return measurement; }
            set { measurement = value; }
        }
        public string[] arr_Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}
