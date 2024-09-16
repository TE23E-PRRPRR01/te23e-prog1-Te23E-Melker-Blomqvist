// Spelet - Gissa ett slumptal 1-100
using System.Formats.Asn1;
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Spelet - Gissa ett slumptal");

// Variabel för att hålla koll på antal gissningar

int antal = 0;

// Fråga spelaren om min och max värde

Console.WriteLine("Ange ett minvärde:");
int minvärde = int.Parse(Console.ReadLine());

Console.WriteLine("Ange ett maxvärde:");
int maxvärde = int.Parse(Console.ReadLine());

// Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(minvärde, maxvärde);

// Upprepning - loop
while (true)
{
    

    // Ställ fråga till spelaren
    Console.WriteLine($"Gissa ett tal ({minvärde}-{maxvärde})");
    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antal med 1
    antal++;

    // Kontroll om gissning är rätt
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat! Det tog dig {antal} gånger");
        break;
    }
    if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }

    // Vill spelaren gissa igen
    Console.WriteLine("Vill du gissa igen? (Yes/No)");
    string answer = Console.ReadLine();
    if (answer == "No")
    {
        break;
    }
        
}

// Slut på spelet
Console.WriteLine("Tack för att du spelade mitt spel!");