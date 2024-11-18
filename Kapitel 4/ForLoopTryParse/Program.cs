using System.ComponentModel;

Console.Clear();

// Skapa en loop som körs 10 gånger.
// Varje gång loopen körs ska den skriva ut ditt namn
Console.WriteLine("vad heter du?");
string namn = Console.ReadLine();   

for (int i = 0; i < 10; i++)
{
    while (namn == "Melker")
    {
        Console.WriteLine($"{namn}");
        break;
    }
}


// Ändra loopen så att den också skriver ut en stigande siffra framför namnet. 
while (true)
{
    Console.WriteLine($"1. {namn}");
    Console.WriteLine($"2. {namn}");
    Console.WriteLine($"3. {namn}");
    break;
}


// Läs in ett tal från användaren som anger hur många gånger loopen ska köras.
// Använd en while-loop och TryParse för att säkerställa att användarens inmatning 
// är en siffra mellan 1 och 10 innan programmet går vidare.
Console.WriteLine("Säg en siffra mellan 1-10");
string antal = Console.ReadLine();
int.TryParse(antal, out int siffra);

for (int i = 0; i < siffra; i++)
{
    Console.WriteLine($"{namn}");
}


// Efter att loopen har körts klart, be användaren mata in ytterligare ett tal.
// Skriv ut resultaten av följande beräkningar på talet:
// Multiplicera det med 2.
// Dividera det med 2.
// Addera 2.
// Subtrahera 2.

Console.WriteLine("Skriv in ett tal");
string tal = Console.ReadLine();
int.TryParse(tal, out nummer)

Console.WriteLine($"Multiplicerat med 2: {tal*2}");