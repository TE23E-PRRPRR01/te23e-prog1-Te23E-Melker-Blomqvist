// Ett litet spel - gissa ett hemligt heltal
Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal");

// Slumpa ett tal
int slumptalet = Random.Shared.Next(1, 101);  // 1-100
Console.WriteLine($"Slumptalet är {slumptalet}");

Console.WriteLine("Gissa ett tal 1-100: ");
// Läs in texten, text "100"
string gissningText = Console.ReadLine();

// Konvertera texten till ett heltal, blir 100
int gissning = int.Parse(gissningText);

if (gissning == slumptalet)
{
    Console.WriteLine("Bra gissat! Du gissade det rätta talet");
}
else
{
  if (gissning >= slumptalet)
  Console.WriteLine("Du gissade för högt");  

  if (gissning <= slumptalet)
  Console.WriteLine("Du gissade för lågt");
}