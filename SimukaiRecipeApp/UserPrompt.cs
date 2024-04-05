using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimukaiRecipeApp
{
    internal class UserPrompt
    {

        Recipe recipeObj = new Recipe();
        int count;//A loop Count variable to keep track of each iteration of a loop.

        double[] arr_resetQuantity;

        //Create a method that will call all the methods
        public void allTasks()
        {
            CaptureRecipeDetails();

            CaptureRecipeSteps();

            DisplayFullRecipe();

            ScaleQuantity();

            resetQuantities();

            ClearData();
        }

        //Create a method that will capture all the recipe details.
        public  void CaptureRecipeDetails()
        {
            int numberOfIngredients;
            count = 1;

            Console.Write("Enter name of Recipe:");
            recipeObj.recipeName = Console.ReadLine();

            //Prompt the user as to how many ingredients are to be entered.
            Console.WriteLine("How many ingredients you want to enter:");
            numberOfIngredients = Convert.ToInt32(Console.ReadLine());

            //Initialize the arrays and set a size to each of them
            recipeObj.arr_IngredientName = new string[numberOfIngredients];
            recipeObj.arr_Quantity = new double[numberOfIngredients];
            recipeObj.arr_Measurements = new string[numberOfIngredients];

            //Capture all the ingredient details.
            for (int i = 0; i < numberOfIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine($"\nINGREDIENT [{count}]");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Enter the name: ");
                recipeObj.arr_IngredientName[i] = Console.ReadLine();

                Console.Write("Enter the quantity: ");
                recipeObj.arr_Quantity[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the unit of measurement: ");
                recipeObj.arr_Measurements[i] = Console.ReadLine();
                count++;
            }
            

        }

        //Create a method that will capture all the recipe steps.
        public void CaptureRecipeSteps()
        {
            int numSteps;
            count = 1;

            Console.Write("\nEnter the number of steps: ");
            numSteps = Convert.ToInt32(Console.ReadLine());

            recipeObj.arr_Description = new string[numSteps];

            //Capture all the descriptions for each step.
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter description of step : {count}");
                recipeObj.arr_Description[i] = Console.ReadLine();
                count++;
            }
            Console.WriteLine("_____\n");

            
        }

        //Create a method that will display all the details for the recipe.
        public void DisplayFullRecipe()
        {
            count = 1;

            Console.ForegroundColor = ConsoleColor.Green;//Change display text color to green.

            Console.WriteLine(
                "INGREDIENT INFO\n" +
                "---------------");

            //Using a for loop, Read through the arrays for the display of all the details.
            for (int i = 0; i < recipeObj.arr_IngredientName.Length; i++)
            {
                Console.WriteLine(
                $"{i + 1}: " +
                $"[{recipeObj.arr_Quantity[i]} {recipeObj.arr_Measurements[i]} of {recipeObj.arr_IngredientName[i]}]");
            }

            Console.WriteLine(
                $"\nDESCRIPTION OF STEPS\n" +
                $"--------------------");
            //Create a for loop to capture all the descriptions for each step.
            for (int i = 0; i < recipeObj.arr_Description.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {recipeObj.arr_Description[i]}");
            }
            Console.WriteLine("<End>\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }

        //Create a method that will allow the user to scale the quantities.
        public void ScaleQuantity()
        {
            //Declare variable that will hold the input responsible for manipulating or scaling the quantities by a certain factor.
            double scale;

            //This array will hold the original values for the quantity array.
            arr_resetQuantity = recipeObj.arr_Quantity;

            Console.WriteLine("Enter the factor in which your ingredient quantities are scaled \n" +
                    "E.g. scaled by a factor of 0.5 (half), 2 (double)\ror 3 (triple): ");
            scale = Convert.ToDouble(Console.ReadLine());//User input

            Console.ForegroundColor = ConsoleColor.Green;
            //Read through the quantity array, for further manipulation.
            for (int i = 0; i < recipeObj.arr_Quantity.Length; i++)
            {
                recipeObj.arr_Quantity[i] *= scale;
            }
            Console.WriteLine($"SUCCESS! QUANTITIES WERE SCALED BY A FACTOR OF {scale}\n");

            Console.ForegroundColor = ConsoleColor.White;

        }

        //Create a method that is responsible for reseting all the quantity values to the original
        public void resetQuantities()
        {
            int response;

            Console.WriteLine(
                "\nDo you want to reset your quantity values to the origional?\n" +
                "(1) Reset Quantity values\n" +
                "(2) Cancel");
            response = Convert.ToInt32(Console.ReadLine());

            switch (response)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Are you sure you want to reset quantities? click\n" +
                    "(1) Reset Quantity values\n" +
                    "(2) Cancel");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (response == 1) { 
                        //Replace the values back to their original state.
                        recipeObj.arr_Quantity = arr_resetQuantity;
                        Console.WriteLine("The quantity values have been restored to their original values\n");
                    }

                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            for (int i = 0; i < recipeObj.arr_Quantity.Length; i++)
            {
                Console.WriteLine($"Reset Quantity for {recipeObj.arr_IngredientName[i] + " = " + recipeObj.arr_Quantity[i]} \n");

            }

        }

        //create a method that will allow the user to clear all the 
        public void ClearData()
        {
            char response;
            
            Console.WriteLine("Do you want to enter a new recipe? \nEnter (Y) to proceed or any other key to decline.");
            response = Convert.ToChar(Console.ReadLine());

            if (response.Equals('Y') || response.Equals('y'))
            {
                for (int i = 0; i < recipeObj.arr_IngredientName.Length; i++)
                {
                    //Clear all the arrays, using the Array.Clear(Array arr, int index, array length) method.
                    Array.Clear(recipeObj.arr_IngredientName, 0, recipeObj.arr_IngredientName.Length);
                    Array.Clear(recipeObj.arr_Quantity, 0, recipeObj.arr_Quantity.Length);
                    Array.Clear(recipeObj.arr_Measurements, 0, recipeObj.arr_Measurements.Length);
                    Array.Clear(recipeObj.arr_Description, 0, recipeObj.arr_Description.Length);
                }
                Console.WriteLine("All the recipe details have been successfully cleared!\n");

                allTasks();//Enter new recipe details
            }
        }
    }
}
