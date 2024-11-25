Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("samlingar");

// Skapa en tom lista av strängar
List<string> listaBöcker = [];

// Skapa en lista med filmnamn
List<string> listaFilmer = ["2001", "I Robot", "Scarface"];

// Skriv ut alla filmnamn
Console.WriteLine($"Alla filmer: {string.Join(", ", listaFilmer)}");

// Lägg till lista
listaBöcker.Add("pippi");
Console.WriteLine($"Alla Böcker: {string.Join(", ", listaBöcker)}");
listaFilmer.Add("Black Witch");
Console.WriteLine($"Alla filmer: {string.Join(", ", listaFilmer)}");

// Användaren anger en bok
Console.WriteLine("Ange en bok: ");
string nyBok = Console.ReadLine();
listaBöcker.Add(nyBok);
Console.WriteLine($"Alla Böcker: {string.Join(", ", listaBöcker)}");

// Kolla om en bok finns i listan
Console.WriteLine("Ange en bok: ");
string bok = Console.ReadLine();

if (listaBöcker.Contains(bok))
{
    Console.WriteLine("Den finns");
    listaBöcker.Remove(bok);
}
else
{
    Console.WriteLine("Den finns inte");
}