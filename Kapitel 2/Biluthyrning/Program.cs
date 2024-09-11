// Program för att hitta kostnaden på en bilhyrning
Console.Clear();
Console.WriteLine("Program för att hitta kostnaden på en bilhyrning");

// Ange längd i mil
Console.WriteLine("Ange hur många mil du har åkt");
double mil = double.Parse(Console.ReadLine());

// Ange hur många dagar
Console.WriteLine("Hur många dagar du har haft bilen");
double dagar = double.Parse(Console.ReadLine());

// Konvertera till kostnaden
double kostnad = 500 + (mil * 5) + (dagar * 100);

// Resultat
Console.WriteLine($"Kostnaden blir {kostnad}");