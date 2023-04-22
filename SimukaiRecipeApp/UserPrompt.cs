using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimukaiRecipeApp
{
    internal class UserPrompt : Recipe
    {

        //Create a method that will capture all the recipe details.
        public void CaptureRecipeDetails()
        {
            int numberOfIngredients;

            //Prompt the user as to how many ingredients are to be entered.
            Console.WriteLine("How many ingredients you want to enter:");
            numberOfIngredients = Convert.ToInt32(Console.ReadLine());

            //Initialize the arrays and set a size to each of them
            ingredientName = new string[numberOfIngredients];
            ingredientQuantity = new int[numberOfIngredients];
            measurement = new string[numberOfIngredients];


        }
    }
}
