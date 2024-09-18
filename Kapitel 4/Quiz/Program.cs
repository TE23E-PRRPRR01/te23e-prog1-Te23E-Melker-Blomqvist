// Ett program där användaren spelar frågesport
Console.Clear();
Console.WriteLine("Hej och välkommen till min frågesport");
Console.WriteLine("Ange ditt namn:");
string namn = Console.ReadLine();

Console.WriteLine($"""
Hej {namn}, detta spel går ut på att svara rätt på frågor. Du kommer få 3 alternativ 
och du ska välja ett, 
rätt svar ger 1 poäng och fel svar ger 0. 
Skriv in ett meddelande om du är redo att börja
""");
Console.ReadLine();


// Variabel för att hålla koll på poäng

int antal = 0;

// Frågor börjar 

Console.WriteLine("""

Fråga 1: Vilket lag vann första säsongen i allsvenskan 1924?
a) Malmö FF
b) GAIS
c) IFK Norrköping
""");

string gissning = Console.ReadLine();

if (gissning == "b")
{
    antal++;
    Console.WriteLine("Du svarade rätt!, du tjänade en poäng. Nu till fråga 2");
}
else
{
    Console.WriteLine("Fel svar, till nästa fråga");
}

Console.WriteLine("""

Fråga 2: Vem har mest mål i allsvenskans historia?
a) Sven Jonasson
b) Erabi
c) Carl Erik Holmberg
""");

gissning = Console.ReadLine();

if (gissning == "b")
{
    antal++;
    Console.WriteLine("Du svarade rätt!, du tjänade en poäng. Nu till fråga 3");
}
else
{
    Console.WriteLine("Fel svar, till nästa fråga");
}


Console.WriteLine("""

Fråga 3: Allsvenskan firade nydligen sin 100 årsdag, vad var annorlunda 
under matcherna för att fira detta?
a) Alla matcher under omgången spelades samtidigt
b) Lagen använde retro tröjor under match istället för sina vanliga ställ
c) Biljetter var gratis så det var mycket fler fans än vanligt.
""");

gissning = Console.ReadLine();

if (gissning == "b")
{
    antal++;
    Console.WriteLine("Du svarade rätt! Du tjänade en poäng. Nu till fråga 4");
}
else
{
    Console.WriteLine("Fel svar, till nästa fråga");
}


Console.WriteLine("""

Fråga 4: Vem har flest matcher i allsvenskan
a) Sven Andersson
b) Andreas Johansson
c) toure
""");

gissning = Console.ReadLine();

if (gissning == "b")
{
    antal++;
    Console.WriteLine("Du svarade rätt! Du tjänade en poäng. Tack för att du deltog!");
}
else
{
    Console.WriteLine("Du svarade fel, tack för att du deltog");
}

Console.WriteLine($"Tack för att du spelade, du fick {antal} poäng.");