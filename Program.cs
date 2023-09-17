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

    }
}
