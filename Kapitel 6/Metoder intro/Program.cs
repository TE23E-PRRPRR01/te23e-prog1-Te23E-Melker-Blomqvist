Console.Clear();
Console.WriteLine("Hej metoder");

// Använd metoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

// anropa meny
VisaMeny();

// anropa registreranamn
RegistreraNamn();

/* ****************************************************
********************   METODER   **********************
******************************************************* */


// summary
// metod som skriver hälsning
// summary
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}

// summary
// metod som skriver hälsning
// summary
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}

VisaMeny();
VisaMeny();
VisaMeny();
VisaMeny();
VisaMeny();
VisaMeny();


static void Melkau()
{
    Console.WriteLine("melkau ja");
}
Melkau();
Melkau();
Melkau();
Melkau();
Melkau();
