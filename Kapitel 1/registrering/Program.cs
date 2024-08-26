// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn ");
Console.WriteLine("Ange förnamn");
string förnamn = Console.ReadLine();
Console.WriteLine("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);
Console.WriteLine($"Hej! {förnamn} {efternamn}");

// Är det Melker som loggar in?
if (förnamn == "Melker")
{
    Console.WriteLine("Vad trevligt att du är tillbaka");
}

//