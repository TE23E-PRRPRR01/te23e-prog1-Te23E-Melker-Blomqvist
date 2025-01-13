using System.Runtime.ConstrainedExecution;

Console.Clear();
Console.WriteLine("Allt om listor");

// Skapa tom lista
List<string> lista = [];

// Lägg till i lista
lista.Add("Melker");
lista.Add("Melker2  ");

// Ny lista
List<string> listaAction = [];
Console.WriteLine("Ange ett spel: ");
string spel = Console.ReadLine();
listaAction.Add(Console.ReadLine());
Console.WriteLine("Ange ett till spel: ");
Console.ReadLine();

listaAction.Add(Console.ReadLine());
