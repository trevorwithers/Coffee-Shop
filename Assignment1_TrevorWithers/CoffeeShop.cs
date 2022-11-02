using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Trevor Withers
//This class handles coffee shop data as an object

namespace Assignment1_TrevorWithers
{
    class CoffeeShop
    {
        string shopName;
        int numOfCoffee;
        int numOfTea;

        public static double coffeePrice;
        public static double teaPrice;

        //Initializes variables to 0 and assigns the shop name
        public CoffeeShop(string initialName)
        {
            shopName = initialName;
            numOfCoffee = 0;
            numOfTea = 0;
        }

        //Calculates and returns the total sales of the business
        public double GetTotalSales()
        {
            return numOfCoffee * coffeePrice + numOfTea * teaPrice; 
        }

        //Sets number of drinks from passed user input
        public void SetDrinkAmounts(int passedNumOfCoffee, int passedNumOfTea)
        {
            numOfCoffee = passedNumOfCoffee;
            numOfTea = passedNumOfTea;
        }

        //Returns the shop name
        public string GetShopName()
        {
            return shopName;
        }

        //Returns the number of coffees sold
        public int GetNumOfCoffee()
        {
            return numOfCoffee;
        }

        //Returns the number of teas sold
        public int GetNumOfTea()
        {
            return numOfTea;
        }
    }

}
