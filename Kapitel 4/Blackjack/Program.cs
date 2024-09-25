// Spelet BlackJack
Console.Clear();
Console.WriteLine("Spelet BlackJack");

// Kortens värde är
//2-10 = 2-10
//Knekt, dam, kung = 10
// Ess = 1 eller 11
// @todo slumpa måste efterlika riktig kortlek

// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

// Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;

// Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDator += kort;

// Flera gånger (loop)
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"du har {summaSpelare} poäng");
    Console.WriteLine($"Datorn har {summaDator} poäng");

    // Stanna eller dra ett kort
    Console.WriteLine("Vill du ha ett nytt kort? (Y/N)");
    string svar = Console.ReadLine().ToUpper();
    if (svar == "N")
    {
        // @todo datorn får ta extra kort
        while (summaDator < 17)
        {
        kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
        summaDator += kort;
        
        }   

        // Vem har vunnit?
        // Den som har närmast 21 har vunnit 
        if (summaSpelare > summaDator && summaSpelare < 21)
        {
            Console.WriteLine("Du har vunnit!");
        }
        else
        {
            Console.WriteLine("Du har förlorat!");
        }
        break;
    }

    // Ta ett extra kort
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaSpelare += kort;
    // Skriv ut kortet
    Console.WriteLine($"Du fick {kort} poäng");

    // Datorn får också ett nytt kort
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaDator += kort;
    Console.WriteLine($"Datorn fick {kort} poäng");

    // Vem har vunnit?
    // Har datorn fått 21
     if(summaDator == 21)
    {
        Console.WriteLine("Du har förlorat!");
        break;
    }
    // Har spelaren fått 21 har spelaren vunnit
    if(summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit!");
        break;
    }

    // Är spelaren tjock?
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat!");
        break;
    }
    // Är datorn tjock?
    if (summaDator > 21)
    {
        Console.WriteLine("Du har vunnit!");
        break;
    }
}