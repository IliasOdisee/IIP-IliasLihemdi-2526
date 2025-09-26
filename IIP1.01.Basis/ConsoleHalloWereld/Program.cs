using System;

namespace HalloWereld
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hallo Wereld!");
		 Console.Write("Hoe heet je: ");
		 string Naam = Console.ReadLine();
		 Console.ForegroundColor = ConsoleColor.Yellow;
		 Console.WriteLine($"Aangename kennismaking, {Naam}");
		 Console.ResetColor();
		 
		 Console.WriteLine("Druk een toets om verder te gaan...");
		 
		 Console.ReadKey();
      }
   }
}