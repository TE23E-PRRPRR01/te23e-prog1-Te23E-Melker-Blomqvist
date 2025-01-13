Console.Clear();
Console.WriteLine("filmregister");

// lista för att lagra
List<string> listaFilmer = [];

// Fråga om antal
Console.WriteLine("Ange ett antal filmer per sida (3-5): ");
int antal = int.Parse(Console.ReadLine());

while (true)
{
    // Visa meny
    Console.Write("""
1. Lägg till filmer
2. Lista filmer
3. Sök
4. Avsluta
ange ditt val: 
""");
    string val = Console.ReadLine();
    Console.WriteLine();

    if (val == "1")
    {
        for (var i = 0; i < antal; i++)
        {
        Console.WriteLine($"Ange {antal} filmer");
        string film = Console.ReadLine();
        listaFilmer.Add(film);   
        }
    }
    else if (val == "2")
    {
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }
    else if (val == "3")
    {
        Console.WriteLine("Sök med första bokstaven i filmens namn: ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            if (filmnamn.StartsWith(bokstav))
            Console.WriteLine(filmnamn);
        }
    }
    else if (val == "4")
    {
        Console.WriteLine("Ha en bra dag!");
        break;
    }
}

