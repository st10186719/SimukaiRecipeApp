using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimukaiRecipeApp
{
    internal class UserPrompt : Recipe
    {

        int count;//A loop Count variable to keep track of each iteration of a loop. 


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

            //Capture all the ingredient details.
            for (int i = 0; i < numberOfIngredients; i++)
            {

                Console.WriteLine($"\nIngredient {count}");
                Console.Write("Enter the name: ");
                ingredientName[i] = Console.ReadLine();

                Console.Write("Enter the quantity: ");
                ingredientQuantity[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the unit of measurement: ");
                measurement[i] = Console.ReadLine();
                count++;
            }
        }
    }
}
