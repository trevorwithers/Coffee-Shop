using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Trevor Withers
//Program to calculate total sales for a coffee shop and display the winning store

namespace Assignment1_TrevorWithers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Set drink price
            CoffeeShop.coffeePrice = 1.91;
            CoffeeShop.teaPrice = 1.53;

            //Create two coffee shop objects
            CoffeeShop lolasCoffeeShop = new CoffeeShop("Lola's Coffee Shop");
            CoffeeShop bertsCoffeeShop = new CoffeeShop("Bert's Coffee Shop");


            //Call functions to ask for the number of drinks sold for each shop
            lolasCoffeeShop.SetDrinkAmounts(SetNumOfDrinks("coffees", lolasCoffeeShop.GetShopName()), 
                                            SetNumOfDrinks("teas", lolasCoffeeShop.GetShopName()));

            bertsCoffeeShop.SetDrinkAmounts(SetNumOfDrinks("coffees", bertsCoffeeShop.GetShopName()), 
                                            SetNumOfDrinks("teas", bertsCoffeeShop.GetShopName()));


            //Prints to the screen the totals for each business
            Console.WriteLine();

            Console.WriteLine("The total sales for " + lolasCoffeeShop.GetShopName() + " was " + lolasCoffeeShop.GetTotalSales() +
                              ".");

            Console.WriteLine("The total number of coffees sold was " + lolasCoffeeShop.GetNumOfCoffee() + 
                              " with the total sales of $" +
                              (lolasCoffeeShop.GetNumOfCoffee() * CoffeeShop.coffeePrice) + 
                              " dollars.");

            Console.WriteLine("And the total number of teas sold was " + 
                              lolasCoffeeShop.GetNumOfTea() + " with the total sales of $" + 
                              (lolasCoffeeShop.GetNumOfTea() * CoffeeShop.teaPrice) + " dollars.");

            Console.WriteLine();

            Console.WriteLine("The total sales for " + bertsCoffeeShop.GetShopName() + " was " + bertsCoffeeShop.GetTotalSales() +
                              ".");

            Console.WriteLine("The total number of coffees sold was " + bertsCoffeeShop.GetNumOfCoffee() + 
                              " with the total sales of $" +
                              (bertsCoffeeShop.GetNumOfCoffee() * CoffeeShop.coffeePrice) + 
                              " dollars.");

            Console.WriteLine("And the total number of teas sold was " + 
                              bertsCoffeeShop.GetNumOfTea() + " with the total sales of $" + 
                              (bertsCoffeeShop.GetNumOfTea() * CoffeeShop.teaPrice) + " dollars.");

            Console.WriteLine();


            
            //Determines which coffee shop won
            if (lolasCoffeeShop.GetTotalSales() > bertsCoffeeShop.GetTotalSales())
	        {
                DisplayBestShop(lolasCoffeeShop.GetShopName());
	        }
            else
            {
                DisplayBestShop(bertsCoffeeShop.GetShopName());
            }
        }

        //This function prints the winning coffee shop
        static void DisplayBestShop(string passedCoffeeShopName)
        {
            Console.WriteLine(passedCoffeeShopName + " is the winner!");
        }

        //Asks users for drink amounts and sends data to be validated before retuning valid data
        static int SetNumOfDrinks(string passedDrinkType, string passedCoffeeShopName)
        {
            int quantity = 0;
            Console.Write("Please enter the number of " + passedDrinkType + " for " + passedCoffeeShopName + " between 0 and 5000: ");
            quantity = Int32.Parse(Console.ReadLine());
            quantity = ValidateInt(quantity, 0, 5000, "Invalid entry. Please re-enter the number of " 
                                    + passedDrinkType + " that were served (0-5000): ");
            return quantity;
        }

        //A generic function to validate an int value with a min a max and a custom error message
        static int ValidateInt(int passedInt, int minVal, int maxVal, string errorMsg)
        {
            while(passedInt < minVal || passedInt > maxVal)
            {
                Console.Write(errorMsg);
                passedInt = Int32.Parse(Console.ReadLine());
            }
            return passedInt;
        }
    }
}
