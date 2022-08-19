using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlay = true;

            while(isPlay)
               isPlay = MainMenu();
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose Options: ");
            Console.WriteLine("1. Option one");
            Console.WriteLine("2. Option two");
            Console.WriteLine("3. Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumber();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumber()
        {
            Console.Clear();
            Console.Write("Type your number: ");
            int userEnter = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter < userEnter)
            {
                Console.Write("{0}-", counter);
                counter++;
            }
            Console.ReadLine();

        }

        private static void GuessingGame()
        {
            Console.Clear();
            Random myRandom = new Random();
            int compRandom = myRandom.Next(1, 11);
            bool incorect = true;

            do
            {
                Console.Write("Guess the number here: ");
                string userEnter = Console.ReadLine();

                if (userEnter == compRandom.ToString())
                {
                    incorect = false;
                    Console.Write("You correct because you choose {0} and comp choose {1}", userEnter, compRandom);
                } 
                else
                    Console.WriteLine("Sorry, you incorrect, please try again");
            }
            while (incorect);
            Console.ReadLine();

        }
    }
}
