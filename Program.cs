using System;
using System.Collections.Concurrent;
using System.Xml;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string reg = RegGetter();
            string duration = DurationGetter();

        }

        static void Menu() /* writes the menu */
        {


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            

            Console.WriteLine("##################################################################");
            Console.WriteLine("");
            Console.WriteLine("W E L C O M E  T O  B O B ' S  C A R  P A R K");
            Console.WriteLine("");
            Console.WriteLine("##################################################################");

        }

        static string RegGetter() /* gets the reg with some light validation (depends on Menu()) */
        {
            string? correct = "";
            string? reg = "";
            while (correct != "y" || correct != "yes")
            {

                Menu();


                Console.WriteLine("");
                Console.WriteLine("Please enter car registration");
                Console.WriteLine("");
                reg = Console.ReadLine();
                Console.WriteLine("Registration entered: " + reg);
                Console.WriteLine("");
                
                Console.WriteLine("Is this correct?  (y/n)");
                correct = Console.ReadLine();

                if (correct == "y")
                {
                    break;
                }

                if (correct == "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Try again.");
                }

            }

            return reg;
        }

        static string DurationGetter() /* gets the duration with some light validation (depends on Menu()) */
        {

            string? correct = "";
            string? reg = "";
            while (correct != "y" || correct != "yes")
            {


                Menu();

                Console.WriteLine("Please select duration:          (Press number 1 - 7)");
                Console.WriteLine("");
                Console.WriteLine("1       Up to 30 minutes       £1");
                Console.WriteLine("1       30-60 minutes          £1");
                Console.WriteLine("1       Up to 2 hours          £1");
                Console.WriteLine("1       Up to 3 hours          £1");
                Console.WriteLine("1       Up to 4 hours          £1");
                Console.WriteLine("1       Up to 6 hours          £1");
                Console.WriteLine("1       Up to 12 hours         £1");
                Console.WriteLine("");

                reg = Console.ReadLine();
                Console.WriteLine("Duration selected: " + reg);
                Console.WriteLine("");

                Console.WriteLine("Is this correct?  (y/n)");
                correct = Console.ReadLine();

                if (correct == "y")
                {
                    break;
                }

                if (correct == "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Try again.");
                }

            }

            return reg;
        }

        static int Pay(string duration)
        {
            double due = 0;
            double payed = 0;

            if (duration == "1")
            {
                due = 1;
            }
            if (duration == "2")
            {
                due = 2;
            }
            if (duration == "3")
            {
                due = 3;
            }
            if (duration == "4")
            {
                due = 4;
            }
            if (duration == "5")
            {
                due = 5;
            }
            if (duration == "6")
            {
                due = 6;
            }
            if (duration == "7")
            {
                due = 10;
            }

            while (payed < due)
            {


                Menu();

                Console.WriteLine("Please select duration:          (Press number 1 - 7)");
                Console.WriteLine("");
                Console.WriteLine("1       Up to 30 minutes       £1");
                Console.WriteLine("1       30-60 minutes          £1");
                Console.WriteLine("1       Up to 2 hours          £1");
                Console.WriteLine("1       Up to 3 hours          £1");
                Console.WriteLine("1       Up to 4 hours          £1");
                Console.WriteLine("1       Up to 6 hours          £1");
                Console.WriteLine("1       Up to 12 hours         £1");
                Console.WriteLine("");
                Console.WriteLine("Amount tendered: "+payed);
                Console.WriteLine("");

                Console.Write("Please enter the coins to the value of" + due);

                

            }

            return reg;
        }

    }
}
