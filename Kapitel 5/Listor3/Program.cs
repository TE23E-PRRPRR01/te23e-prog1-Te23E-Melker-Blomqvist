Console.Clear();

// Skriv ut lista med foreach
// Skapa en lista av maträtter med minst tre rätter.
// Använd en foreach-loop för att skriva ut alla maträtter
List<string> maträtter = ["köttfärsås", "lasagne", "kycklinggryta"];
Console.WriteLine("Alla maträtter:");
foreach (var maträtt in maträtter)
{
    Console.WriteLine(maträtt);
}

// Skriv ut alla årtalen i en lista
// Skapa en lista av typen List<int> med fem olika årtal.
// Använd en foreach-loop för att skriva ut alla årtal.
List<int> årtal = [2004, 2005, 2007, 2008, 2010];
foreach (var år in årtal)
{
    Console.WriteLine(år);
}

// Skriv ut på en rad
// Ta föregående övning och skriv ut alla årtal på en rad med kommatecken mellan varje år.
// Tips: Använd Console.Write istället för Console.WriteLine.
foreach (var år in årtal)
{
    Console.Write($"{år}, ");
}

// Användaren fyller på en lista
// Skapa en tom lista av typen List<string>.
// Låt användaren fylla på listan med namn tills hen skriver exit.
// Visa listan efter att användaren har avslutat inmatningen.
List<string> listasaker = [""];
while (true)
{
    Console.WriteLine("""
    Ange en sak som ska läggas till i listan, eller avsluta för att avsluta: 
    """);
    string sak = Console.ReadLine();
    if (sak == "avsluta")
    {
        break;
    }
    else
    {
        listasaker.Add(sak);
        Console.WriteLine(sak);
    }
}

// Användaren fyller på en lista med årtal
// Skapa en tom lista av typen List<int>.
// Låt användaren fylla på listan med årtal tills hen skriver 0.
List<int> årtal2 = [""];
while (true)
{
    Console.WriteLine("""
    Ange ett årtal till listan, eller skriv 0 för att avsluta
    """);
    int årtall = int.Parse(Console.ReadLine());
    
    if (årtall == "0")
    {
        break;
    }
    else
    {
        listasaker.Add(årtall);
        Console.WriteLine(årtall);
    }
}