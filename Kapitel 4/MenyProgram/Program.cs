// Litet program med meny
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// Variabel för svaren
string val = "";

// Programloop som snurrar tills användaren säger avsluta
while (true)
{
    // Visar en meny och läser in användarens val
    Console.Write("""
    1. Omvandla en text till versaler
    2. Omvandla en text till gemener
    3. Avsluta
    Välj ett av alterantiven ovan:
    """);
    val = Console.ReadLine();
    
    // Hantera användarens val

    if (val == "1")
    {
        Console.WriteLine("Skriv in en text:");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler blir: {text}");
        break;
    }
    else if (val == "2")
    {
        Console.WriteLine("Skriv in en text:");
        string text = Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener blir: {text}");
        break;
    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar programmet...");
        break;
    }
    else
    {
        Console.WriteLine("Ditt svar är ogiltigt, försök igen");
    }
}