using System;

class Leeftijd
{
    static void Main()
    {
		
        Console.Write("Wat is je voornaam? ");
        string voornaam = Console.ReadLine();

        Console.Write("Hoe oud ben je? ");
        int leeftijd = int.Parse(Console.ReadLine());

        Console.Write("Geef je lievelingsletter: ");
        string lievelingsletter = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Hallo {voornaam}! Jij bent {leeftijd} jaar.");
        Console.WriteLine($"Volgend jaar ben je {leeftijd + 1}.");
        Console.WriteLine($"Jouw lievelingsletter is {lievelingsletter}");
    }
}