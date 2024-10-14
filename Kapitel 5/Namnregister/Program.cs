// Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");

// Programloopen
List<string> namnlista = [];
while (true)
{



    // Visa en meny
    Console.WriteLine("""
1. Registrera alla namn
2. Skriva ut alla namn
3. Avsluta 
Ange ditt val: 
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnlista.Add(namn);

    }
    else if (val == "2")
    {
        // skriv ut namnen
        foreach (var namnet in namnlista)
        {
            Console.Write($"{namnet}, ");
        }
        Console.WriteLine();
    }

    if (val == "3")
    {
        break;
    }

}