// Ett program för kryptering av ceasar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering av ceasar-chiffer");

// Alfabetet
string Alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange ett meddelande
Console.WriteLine("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

// Ange en nyckel
Console.WriteLine("Ange en nyckel (1-9)");
int nyckel = int.Parse(Console.ReadLine());

// Loop
foreach (char bokstav in meddelande)
{
    // Hitta bokstavens position (index)
    int index = Alfabetet.IndexOf(bokstav);
    //Console.WriteLine($"'A' så är index={index}");

    if (index != -1)
    {
        // Caesar kryptering, addera en nyckel
        int nyIndex = index + nyckel;
        //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

        // Börja om alfabet om nyckeln går ur listan.
        {
            nyIndex = nyIndex - Alfabetet.Length;
        }

        // Plocka ut bokstaven för nyIndex  
        char krypteradBokstav = Alfabetet[nyIndex];
        //Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
        Console.Write(krypteradBokstav);

    }
    else
    {
        Console.Write(bokstav);
    }
}

