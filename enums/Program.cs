using System.Globalization;

namespace enums
{
    enum  Beverage 
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awsome vending machine");
            Console.WriteLine("Which bevevege do you preform? (Coffee, Tea, Water, Soda, Juice");
            String userInput= Console.ReadLine();
            switch (userInput.ToLower()) 
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("invalid input this do not exists");
                    break;
            }
        }

        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("youy order kaffe latte");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("you order tea, jukky");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You choose water, why though!?");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("nice choice, bebsi cola");
                    break;
                case Beverage.Juice:
                 //   Console.Writeline("one orange juice coming your way");
                    break;
            
            }
        }
    }
}  