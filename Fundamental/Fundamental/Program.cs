using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World");
            int x = 12 - 5;
            Console.WriteLine(x);

            Variables
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            Console.Write("Type your firstname: ");
            string fname;
            fname = Console.ReadLine();

            Console.Write("Type your lastname: ");
            string lname;
            lname = Console.ReadLine();

            Console.WriteLine($"Hallo, {fname} {lname}");

            //If statement
            Console.WriteLine("Joe doe give a big gift..");
            Console.Write("Choose the door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if(userValue == "1")
                 message = "You won a new xiomy phone";
            else if(userValue == "2")
                message = "You won a new books";
            else if(userValue == "3")
                message = "You won a new pencil";
            else
            {
                message = "zonk.. ";
                //message = message + " You lose.";
                message += "You lose.";
            }

            Console.WriteLine(message);

            Console.WriteLine("Joe doe give a big gift..");
            Console.Write("Choose the door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "banana";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();

            //Operator, Expression and Statement
            int a, b, x, y;

            a = 3;
            b = 8;
            x = 9;
            y = 92;

            x = a * b;
            y = x * a;
            a = x * b;
            b = y * a;

            Console.WriteLine("a: {0}, b: {1}, x: {2}, y: {3}", a, b, x, y);

            if (a < b) Console.WriteLine("Hallo.. less than");
            if(x > a) Console.WriteLine("Hallo.. greater than");
            if (y != b) Console.WriteLine("Hallo.. not equal");

            if((a * b) > (x * y) || (y * b) > (x * b)) Console.WriteLine("Hallo.. or expression");

            string message = (a == y) ? "yes" : "no";

            Console.WriteLine(message);

            //For iteration
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine("I am number {0}", i);

                 if(i == 7)
                {
                    Console.WriteLine("Found seven.");
                    break;
                }
                //Console.WriteLine(i);
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            //Array
            int[] numbers = new int[5];

            numbers[0] = 8;
            numbers[1] = 20;
            numbers[2] = 80;
            numbers[3] = 99;
            numbers[4] = 0;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers.Length);
           

            int[] numbers = new int[] { 8, 20, 80, 99, 0 };
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            string zig = "If you want to grow " + ", you have to stay in the suffering";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            //charArray.Reverse();

            //Console.WriteLine(charArray);
            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

            //Method
            //HalloWorld();
            //Console.ReadLine();

            Console.WriteLine("Start a game reverse word ");
            Console.Write("Enter you first word: ");
            string userFirstEntered = Console.ReadLine();
            Console.Write("Enter you second word: ");
            string userSecondEntered = Console.ReadLine();
            
            //string reversedUserFirstEntered = ReverseWord(userFirstEntered);
            //string reversedUserSecondEntered = ReverseWord(userSecondEntered);

            DisplayResult(
                ReverseWord(userFirstEntered),
                ReverseWord(userSecondEntered)
                );

            DisplayResult(String.Format(
                "{0} {1}",
                 ReverseWord(userFirstEntered),
                 ReverseWord(userSecondEntered)
                ));
            */

            // While Fundamental 2
        }

        private static void HalloWorld()
        {
            Console.WriteLine("Hallo World");
        }

        //private static void ReverseWord(string message)
        //{
        //    char[] charMessageArray = message.ToCharArray();
        //    Array.Reverse(charMessageArray);

        //    foreach (char charMessage in charMessageArray)
        //    {
        //        Console.Write(charMessage);
        //    }
        //    Console.ReadLine();
            
        //}

        private static string ReverseWord(string message)
        {
            char[] charMessageArray = message.ToCharArray();
            Array.Reverse(charMessageArray);

            return String.Concat(charMessageArray); 
        }

        private static void DisplayResult(
            string reversedFirstUserEntered,
            string reversedSecondUserEntered)
        {
            Console.Write(String.Format(
              "{0} {1}", 
              reversedFirstUserEntered,
              reversedSecondUserEntered
              ));
            Console.ReadLine();
        }

        //Method dengan nama yang sama asalkan signature (type paramater dan jumlah parameter) nya berbeda
        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
