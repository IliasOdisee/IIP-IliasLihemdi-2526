using System;

namespace Oefening1
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Geef me je naam: ");
		 string voornaam = Console.ReadLine();
		 
		 Console.ForegroundColor = ConsoleColor.Red;
		 
		 Console.Write("Hoe groot ben je? ");
		 int lengte = Convert.ToInt32(Console.ReadLine());
		 
		 Console.ResetColor();
		 
		 // optie 1 -> concatenatie
		 Console.WriteLine("Jouw naams is " + voornaam + " en je lengte is " + lengte +"cm.");
		 
		 // optie 2 -> stringinterpolatie
		 Console.WriteLine($"Jouw naam is (voornaam) en je lengte is (lengte) cm.");
		 
		 // optie 3 -> 
		 Console.WriteLine("Jouw naam is {0} en je lengte is {1} cm.", voornaam, lengte);
		 
		 
		 string getal1 = "1";
		 string getal2 = "1";
		 
		 Console.WriteLine(getal1 + " + " + getal2 + " = " + ( getal1 + getal2 ));
		 
		 Console.ReadKey();
      }
   }
}