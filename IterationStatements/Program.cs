using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using IterationStatements;

namespace IterationStatements

{
        //LukeWarm Section: Create methods below
    public class Program
    {    //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintBy3()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        
        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void EqualTo(int num1, int num2)
        {

            if (num1 == num2) 

            {
                Console.WriteLine("These numbers are equal.");
            }
            else
            {  
                Console.WriteLine("These numbers are not equal."); 
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("That number is so even.");
            }
            else
            {
                Console.WriteLine("That number is a bit odd.");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num1)
        {
            if (num1 < 0) 
            {
                Console.WriteLine("That number is negative, bro.");
            }
            else
            {
                Console.WriteLine("That number is pretty positive.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void CanVote()
        {
            Console.WriteLine("What is your age, citizen?");
           int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are good to vote, citizen.");
            }
            else
            {
                Console.WriteLine("Oh, well, you can not vote yet, citizen. Sorry.");
            }
}
            //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            Console.WriteLine("Is your number in our range? Type it and we'll find out.");
            int num = int.Parse(Console.ReadLine());
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("That's in range, friend.");
            }
            else
            {
                Console.WriteLine("Oops, it's out of range.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MathTable()
        {
            int x, y;

            Console.WriteLine("");
            Console.WriteLine("Display Multiplication Table\n");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            Console.WriteLine("Input a number 1 - 12 : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (x = 1; x <= 12; x++)
            {
                Console.WriteLine("{0} X {1} = {2}", y, x, y * x);
            }

        }



        //Call the methods to test them in the Main method below 
        static void Main(string[] args)
        {
            //PrintRange();
            //PrintBy3();
            //EqualTo(1, 2);
            //EvenOrOdd();
            //PositiveOrNegative();
            //CanVote();
            //InRange();
            MathTable();        }
    }
}
           


 


//Heatin Up Section:

