using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //attempting to ask the user all of the questions for part 1
            Console.WriteLine("What is your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());
            int evenOrOdd = 0;
            if (userAge % 2 == 0)
            {
                evenOrOdd = 10;
            }
            else
            {
                evenOrOdd = 21;
            }
            Console.WriteLine("What month were you born in, tell me in numeric version");
            int birthMonth = int.Parse(Console.ReadLine());
            int bankMoney = 0;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankMoney = 100000;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankMoney = 250000; 
            }
            else if (birthMonth >= 9 && birthMonth <=12)
            {
                bankMoney = 1000000;
            }           
            Console.WriteLine("What is your favorite ROYGBIV color? Type 'help' if you need");
            string colorCode = Console.ReadLine().ToLower();
            string modeofTransportation = string.Empty;
            if (colorCode == "help")
            {
                Console.WriteLine("ROYGBIV colors are:\n Red\n Orange\n Yellow\n Green\n Blue\n Indigo\n Violet");
                Console.WriteLine("So which color is your favorite?");
                colorCode = Console.ReadLine().ToLower();
            }
            if (colorCode == "red")
            {
                modeofTransportation = "VW Beetle";
            }
            else if (colorCode == "orange")
            {
                modeofTransportation = "Dodge Challenger";
            }
            else if (colorCode == "yellow")
            {
                modeofTransportation = "Ford Mustang";
            }
            else if (colorCode == "green")
            {
                modeofTransportation = "Lincoln Towncar";
            }
            else if (colorCode == "blue")
            {
                modeofTransportation = "Honda Civic Si";
            }
            else if (colorCode== "indigo")
            {
                modeofTransportation = "Harley Davidson";
            }
            else if (colorCode == "violet")
            {
                modeofTransportation = "Kia Optima";
            }
            Console.WriteLine("How many siblings do you have");
            int userSiblings = int.Parse(Console.ReadLine());
            string vacationHome = string.Empty; 
            if (userSiblings == 0)
            {
                vacationHome = "Alaska";
            }
            if (userSiblings == 1)
            {
                vacationHome = "Florida";
            }
            if (userSiblings == 2) 
            {
                vacationHome = "Mexico";
            }
            if (userSiblings >= 3)
            {
                vacationHome = "Canada";
            }
            Console.WriteLine(firstName + " " + lastName + " will retire in " + evenOrOdd + " years with the amount of $" + bankMoney + " in the bank, \na vacation home in " + vacationHome + " and a " + modeofTransportation + ".");

        }
    }
}
