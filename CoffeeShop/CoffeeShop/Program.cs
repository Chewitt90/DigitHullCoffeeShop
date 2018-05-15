using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
                List<string> Drink = new List<string>();
                List<string> Roast = new List<string>();
                List<string> Quantity = new List<string>();
                List<string> Extras = new List<string>();

            //This isn't the most efficicent way but I had trouble implementing the reading of the file and instead of taking too long trying to work it out I decided to move to a different way

            Drink.Add("Espresso");
            Drink.Add("Flat White");
            Drink.Add("Double Espresso");
            Drink.Add("Latte");
            Drink.Add("Americano");
            Drink.Add("Latte");
            Drink.Add("Double Espresso");
            Drink.Add("White Americano");
            Drink.Add("Espresso");
            Drink.Add("White Americano");
            Drink.Add("Latte");
            Drink.Add("Double Espresso");
            Drink.Add("Espresso");
            Drink.Add("White Americano");
            Drink.Add("Flat White");
            Drink.Add("Double Espresso");
            Drink.Add("Latte");
            Drink.Add("Espresso");
            Drink.Add("Latte");
            Drink.Add("White Americano");

            var mostCommonDrink = Drink.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            Roast.Add("Vienna Roast");
            Roast.Add("Full City Roast");
            Roast.Add("Hull Hill");
            Roast.Add("Vienna Roast");
            Roast.Add("Vienna Roast");
            Roast.Add("New Orleans Roast");
            Roast.Add("Full City Roast");
            Roast.Add("Hull Hill");
            Roast.Add("New Orleans Roast");
            Roast.Add("Vienna Roast");
            Roast.Add("Hull Hill");
            Roast.Add("Full City Roast");
            Roast.Add("Hull Hill");
            Roast.Add("Vienna Roast");
            Roast.Add("New Orleans Roast");
            Roast.Add("Full City Roast");
            Roast.Add("Hull Hill");
            Roast.Add("Full City Roast");
            Roast.Add("Full City Roast");
            Roast.Add("Hull Hill");
            Roast.Add("New Orleans Roast");

            var mostCommonRoast = Roast.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            Extras.Add("Coconut Milk");
            Extras.Add("Soy");
            Extras.Add("Coconut Milk");
            Extras.Add("Soy");
            Extras.Add("Soy");
            Extras.Add("Coconut Milk");
            Extras.Add("Coconut Milk");
            Extras.Add("Soy");
            Extras.Add("Soy");
            Extras.Add("Coconut Milk");

            var mostCommonExtra = Extras.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            //Drink.Add(info[0]);
            //Roast.Add(info[1]);
            //Quantity.Add(info[2]);
            //Extras.Add(info[3]);

            //Drink.ForEach(Console.WriteLine);
            //Roast.ForEach(Console.WriteLine);
            //Quantity.ForEach(Console.WriteLine);
            //Extras.ForEach(Console.WriteLine);
            Console.WriteLine("Most Ordered Drink is " + mostCommonDrink);
            Console.WriteLine("Most popular roast is " + mostCommonRoast);
            Console.WriteLine("Most popular extra is " + mostCommonExtra);
            Console.WriteLine(Extras.Count() + " people out of 20 bought extras");


            Console.ReadLine();
        }
    }
}
