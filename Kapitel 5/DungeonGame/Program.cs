// Dungeon spel med massa rum, saker, fiender, skatter ....
Console.Clear();
Console.WriteLine("Ett dungeon spel");

// Programvariable (state variables)
string rum = "hallen"
list<string> inventarie = [];

// spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.WriteLine("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser några gamla tavlor");
        }
        else if (val == "2")
        {
            rum = "rum 1"
            Console.WriteLine("Du går vidare till nästa rum...");
        }
    }
    else if (rum == "rum 1")
    {
               Console.WriteLine("du är i rum 1");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.WriteLine("Vad vill du göra? ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet");
            Console.WriteLine("vill du plocka upp nycket? (j/n)");
            if (val == "j")
            {
                inventarie.Add("nyckel");
                Console.WriteLine("du plockade upp en nyckel");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet");
            }
        }
        else if (val == "2")
        {
            rum = "rum hallen"
            Console.WriteLine("Du går tillbaka till hallen...");
        }
    }
    else if (rum == "rum 2")
    {
        Console.WriteLine("du är i rum 2");
        int händelse = Random.Shared.Next(1, 5);
        if (händelse == 1)
        {
            Console.WriteLine("du ser ett svärd på marken. Vill du plocka upp det? J/N");
            string val = Console.ReadLine();
            
            if (!inventarie.Contains("svärd") && val == "J")
            {
                inventarie.Add("svärd");
                Console.WriteLine("Du har nu ett svärd");
            }
        }
        else if (händelse == 2)
        {
            Console.WriteLine("Ett spöke dyker upp");
        }
        else if (händelse == 3)
        {
            Console.WriteLine("Du trampar på en mina och förlorar ett liv");
        }
        else if (händelse == 4)
        {
            Console.WriteLine("Du");
        }
    }
}
