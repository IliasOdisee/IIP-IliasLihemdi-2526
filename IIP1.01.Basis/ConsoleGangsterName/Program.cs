using System;

namespace GangsterName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("|   GANGSTA NAME BUILDER   |");
            Console.WriteLine("****************************\n");
			
            Console.Write("Give the first name of any Disney character: ");
            string disneyName = Console.ReadLine();

            Console.Write("Give any workbench tool: ");
            string tool = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"\nYour gangsta name: {disneyName} 'the {tool}' {lastName}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}