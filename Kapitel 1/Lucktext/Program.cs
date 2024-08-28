// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välkommen till våran lucktext!");
Console.WriteLine("Ange ditt namn här:");
string namn = Console.ReadLine();
Console.WriteLine("Ange ett adjektiv:");
string adjektiv = Console.ReadLine();
Console.WriteLine("Ange en kroppsdel:");
string kroppsdel = Console.ReadLine();
Console.WriteLine("Ange en plats:");
string plats = Console.ReadLine();

Console.WriteLine("En gång fanns det en "  + adjektiv + " " + namn);
Console.WriteLine("Som hade en " + kroppsdel);
Console.WriteLine("som var så stor att han kunda bära hela " + plats);
Console.WriteLine("Tack för att du deltog i min lucktext!");