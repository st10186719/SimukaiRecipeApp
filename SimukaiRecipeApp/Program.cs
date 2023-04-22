using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimukaiRecipeApp
{
    internal class Program
    { 
        //Create an object for the UserPrompt external class to have access to the methods.
        static UserPrompt User = new UserPrompt();
        public static void Main(string[] args)
        {
            Console.WriteLine(">>Console Recipe Application<<\n" +
                                "_______________________________\n");
            //Call the captureRecipedetails method
            User.CaptureRecipeDetails();
            User.CaptureRecipeSteps();
            User.DisplayFullRecipe();


            Console.ReadKey();
        }

    }
}
