// Liten morsekod app
Console.Clear();
Console.WriteLine("En liten morsekod app");

// Två listor
List<string> alfabetet = ["A", "B", "C", "D", "E", "F", "G", "H", "I",
                         "J", "K", "L", "M", "N", "O", "P", "Q", "R",
                         "S", "T", "U", "V", "W", "X", "Y", "Z", "Å",
                         "Ä", "Ö", " ", "1", "2", "3", "4", "5", "6",
                         "7,", "8", "9"];

List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                          "....", "..", ".---", "-.-", ".-..", "--", "-.",
                          "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                          "...-", ".--", "-..-", "-.--", "--..", ".--.-",
                          ".-.-", "---.", "/", "━━ ━━", "━", "━ ━", "━ ━ ━",
                          "━ ━ ━ ━", "━━", "━━ ━", "━━ ━ ━", "━ ━━", "━ ━ ━━", ];

// Läs in en text
Console.WriteLine("Ange ett meddelande: ");
string meddelande = Console.ReadLine();

// Gå igenom meddelandet bokstav för bokstav. 
foreach (char bokstav in meddelande)
{

    // Uppslag i alfabetet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    // Hittar morsetecken?
    if (index >= 0)
    {
        // Console.WriteLine($"{bokstav} finns på index {index}");

        // Skriv ut översättningen av det du matade in.
        string morsetecken = morsekod[index];
        // Console.Writeline($"{bokstav} är {morsetecken}")
        Console.Write($"{morsetecken} ");

        // Spela upp morse som ljud
        // Loopa igenom morsetecknet
        foreach (char signal in morsetecken)
        {
            if (signal == '.') // '.'
            {
                // Hz, ms
                Console.Beep(1000, 75);
            }
            else 
            {
                Console.Beep(1000, 300);
            }
        }

        // Paus i koden
        Thread.Sleep(150);


    }
    else
    {
        Console.WriteLine("?");
    }
}




