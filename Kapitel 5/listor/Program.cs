// Använda listor för att skapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter. t.ex "äpple, "apelsin, "annanas"
List<string> frukter = ["äpple", "banan" , "päron"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]},");

// ändra
frukter[0] = "apelsin";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]},");

// Gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Skapa en lista på valfri sak (4st)
List<string> maträtter = ["Lasange", "Hamburgare", "Korv", "Pannkakor"];

// Skriv ut  varje sak på samma rad
foreach (var maträtt in maträtter)
{
    Console.WriteLine($"{maträtt }");
}

// Skapa ett register
Console.Clear();

// En tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    fonsole.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}
