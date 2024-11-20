// ForLoopBonanza
using System.Reflection;

Console.Clear();

// Skapa en for-loop som skriver ut alla heltal från 1 till 10.
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}

// Låt användaren ange startvärdet och slutvärdet för loopen
Console.WriteLine("Ange startvärde");
string startvärde = Console.ReadLine();
int.TryParse(startvärde, out int startsiffra);

Console.WriteLine("Ange slutvärde");
string slutvärde = Console.ReadLine();
int.TryParse(slutvärde, out int slutsiffra);

for (int i = startsiffra; i < slutsiffra; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();


// Skapa en for-loop som summerar alla heltal och skriver ut summan.
// Tips: Skapa en variabel för att hålla summan och öka den i varje loop.
Console.WriteLine("summan av talen 1-10");
int summa = 0;
for (int i = 1; i < 10; i++)
{
    summa += i;
    Console.WriteLine(i);
}
Console.WriteLine($"summan av talen är {summa}");

// Låt användaren ange startvärdet och slutvärdet
// Skapa en for-loop som summerar alla heltal.
Console.WriteLine("Ange startsiffra");
Console.ReadLine();

Console.WriteLine("Ange slutsiffra");
Console.ReadLine();

for (int i = startsiffra; i < slutsiffra; i++)
{
    summa += i;
    Console.WriteLine(i);
}
Console.WriteLine($"summan av talen är {summa}");


// Skapa två separata for-loopar som skriver ut:
// Alla jämna siffror från 1 till 20.
// Alla udda siffror från 1 till 20.


Console.Write("Jämna tal: ");
for (var i = 2; i < 21; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();

Console.Write("Udda tal:");
for (var i = 1; i < 21; i+=2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();


// Låt användaren ange ett tal.
// Skapa en for-loop som skriver ut multiplikationstabellen för det talet (1 till 10)
Console.WriteLine("ange ett tal: ");
string tal = Console.ReadLine();
int.TryParse(tal, out int talet);

for (var i = 0; i < 11; i++)
{
    int summa3 = talet * i;
    Console.WriteLine($"{talet} x {i} = {summa3}");
}

// Använd en for-loop för att skriva ut ett pyramidmönster med stjärnor (*).
for (int i = 0; i < length; i++)
{
    
}


