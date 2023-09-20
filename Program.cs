using System;
using System.Collections.Concurrent;
using System.Xml;
using System.Threading;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string reg = RegGetter();
            string durationString = DurationGetter();
            double due = Pay(durationString);

            System.TimeSpan duration = new System.TimeSpan(0, Convert.ToInt32(durationString), 0, 0);

            Console.Clear();

            Print(duration, reg, due);

            Console.ReadKey();

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
                Console.WriteLine("2       30-60 minutes          £1");
                Console.WriteLine("3       Up to 2 hours          £1");
                Console.WriteLine("4       Up to 3 hours          £1");
                Console.WriteLine("5       Up to 4 hours          £1");
                Console.WriteLine("6       Up to 6 hours          £1");
                Console.WriteLine("7       Up to 12 hours         £1");
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

        static double Pay(string duration) /* handles payment and expenses change */
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
                Console.WriteLine("Amount tendered: " + payed);
                Console.WriteLine("");

                Console.WriteLine("Please enter the coins to the value of £" + due);
                string lastCoin = "";

                while (true)
                {


                    lastCoin = Console.ReadLine();
                    try
                    {
                        payed += Convert.ToDouble(lastCoin);
                        break;
                    }
                    catch
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
                        Console.WriteLine("Amount tendered: " + payed);
                        Console.WriteLine("");

                        Console.WriteLine("Make sure you enter a number!");
                        Console.WriteLine("Please enter the coins to the value of £" + due);
                    }
                }

            }

            Console.WriteLine("");
            Console.WriteLine("Amount entered: " + payed);
            if (payed > due)
            {
                Console.WriteLine("Change dispensed: " + (payed - due));
            }
            Console.WriteLine("");
            Console.WriteLine("Please wait...");
            Thread.Sleep(2000);
            return due;
        }

        static void Print(TimeSpan duration, string reg, double due)
        {
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("   B O B ' S   C A R   P A R K   ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("Registration: {0}                ", reg);
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("Entry: {0}           ", DateTime.Now);
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("Fee:         £{0}                 ", due);
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("Expiry: " +((DateTime.Now).Add(duration))+"    ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("Have a nice day!                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);
            Console.WriteLine("                                 ");
            Thread.Sleep(100);

        }
    }
}



/*

   B O B ' S   C A R   P A R K


Registration: ABC


Entry: 20/09/2023 15:37:20


Fee:         £1


Expiry: 20/09/2023 16:07:20


        Have a nice day!

*/