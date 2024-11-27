using System.Reflection;

Console.Clear();
// Skapa en lista med 5 namn
List<string> namn = ["Melker", "Melkerr", "Melkerrr", "Melkerrrr", "Melkerrrrr"];
Console.WriteLine($"Mina kompisar är: {string.Join(", ", namn)}");

// Med 5 städer
List<string> städer = ["Stockholm", "Stockholm", "Stockholm", "Stockholm", "Stockholm"];

// Fem orter {städer} ligger i Sverige
Console.WriteLine($"De fem orterna: {string.Join(", ", städer)} ligger i Sverige");

// Skapa en lista med fem årtal
List<string> årtal = ["2004", "2005", "2007", "2008", "2010"];
Console.WriteLine($"Fem viktiga årtal är: {string.Join(", ", årtal)}");

// Plocka ut första och sista namnet ur listan
Console.WriteLine("Första namnet:" + namn [0]);
Console.WriteLine("Sista namnet:" + namn [4]);

// FAvoritdrycker
List<string> drycker = ["nocco", "nocco", "nocco", "nocco", "nocco"];
Console.WriteLine("Första drycken: " + drycker[0]);
Console.WriteLine("Andra drycken: " + drycker[1]);
Console.WriteLine("Tredje drycken: " + drycker[2]);
Console.WriteLine("Fjärde drycken: " + drycker[3]);
Console.WriteLine("Femte drycken: " + drycker[4]);

// Ålder
List<string> ålder = ["0", "1", "2", "3", "4"];
Console.WriteLine("Första åldern: " + ålder[0]);
Console.WriteLine("Andra åldern: " + ålder[1]);
Console.WriteLine("Tredje åldern: " + ålder[2]);
Console.WriteLine("Fjärde åldern: " + ålder[3]);
Console.WriteLine("Femte åldern: " + ålder[4]);

// Namn baserat på variabel
Console.WriteLine("Ange ett namn: ");
string nynamn = Console.ReadLine();
namn.Add($"{nynamn}");
Console.WriteLine($"Alla namn: {string.Join(", ", namn)}");


