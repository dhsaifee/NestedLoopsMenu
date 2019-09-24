using System;

namespace NestedLoopsMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            // A menu with the following three options: 1 (count to ten), 2 (print a box of stars) and 3 (exit)
            // Menu input errors are handled

            CreateMenu();
            Console.ReadKey();

        }

        static void CreateMenu()
        {

            string menuChoice = GetMenuChoice();

            if(menuChoice == "3")
            {
                Console.WriteLine("Goodbye");
            }

            while (menuChoice != "3")
            {
                if (menuChoice == "1")
                {
                    Console.WriteLine("Count to ten");
                    CountToTen();
                }
                else
                {
                    Console.WriteLine("box of stars");
                    BoxOfStars();
                }

                menuChoice = GetMenuChoice();

                if (menuChoice == "3")
                {
                    Console.WriteLine("Goodbye");
                }
            }
        }
        static string GetMenuChoice()
        {
            Console.Write("\n\nPlease enter 1 to count to ten, 2 to show a box of stars and 3 to exit: ");
            string choice = Console.ReadLine();

            while(!(choice == "1" || choice == "2" || choice == "3"))
            {
                Console.Write("Please enter a valid choice: ");
                choice = Console.ReadLine();
            }

            return choice;
        }

        static void CountToTen()
        {
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void BoxOfStars()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
