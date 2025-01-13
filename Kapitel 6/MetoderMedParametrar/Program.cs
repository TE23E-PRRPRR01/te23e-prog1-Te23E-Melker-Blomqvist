/* *****************************************************
* ****************** M A I N ***************************
******************************************************* */
// using System.Net;

// Console.Clear();

// Skriv meddelande vertikalt
// string meddelande = "Måndag! ";
// SkrivVertikalt(meddelande);

// string meddelande1 = "RobinT ";
// SkrivVertikalt(meddelande1);

// string meddelande2 = "Tisdag! ";
// SkrivVertikalt(meddelande2);

// UpprepaText("Hej", 3);
// UpprepaText("Hejsan", 5);


/* *****************************************************
* ****************** M E T O D E R *********************
******************************************************* */


// static void SkrivVertikalt(string meddelande)
// {
// for (int i = 0; i < meddelande.Length; i++) // 0 -> 6
// {
// Console.WriteLine(meddelande[i]);
// }
// }

// RitaKvadrat(3);

// static void RitaKvadrat(int sidlängd)
// {
// for (int i = 0; i < sidlängd; i++)
// {
// for (int j = 0; i < sidlängd; i++)
// {
// Console.WriteLine("*");
// }
// Console.WriteLine();
// }
// }

// static void UpprepaText(string text, int antal)
// {
// for (int i = 0; i < antal; i++)
// {
// Console.WriteLine(text);
// }
// }


// static void Converter(int celsius)
// {
    // int fahrenheit = celsius * 9/5 + 32;
    // Console.WriteLine($"{} grader Celsius motsvarar {} grader Fahrenheit");
// }

static void Gambla(int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1, 7)}");
    }
}