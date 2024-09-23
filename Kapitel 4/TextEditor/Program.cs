// Program för att skriva/läsa textfil
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Program för att hantera text");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;


// Variabel för svar

string val = "";

// Loop 

while (true)
{
    // Visar en meny och läser in användarens val
    Console.Write("""
      1. Skriv till fil
      2. Läs från fil
      3. Avsluta programmet
      Välj ett av alterantiven ovan:

      """);
    val = Console.ReadLine();

    // if sats

    if (val == "1")
    {
        Console.WriteLine("Skriv in en text:");
        string text = Console.ReadLine();
        File.WriteAllText("filnamn.txt", text);
    }
    else if (val == "2")
    {
        if (File.Exists("filnamn.txt"))
        {
            string text = File.ReadAllText("filnamn.txt");
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Filen finns inte!");
        }
        
    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar programmet...");
        break;
    }
    else
    {
        Console.WriteLine("Ditt svar är ogiltigt, försök igen");
    }
}