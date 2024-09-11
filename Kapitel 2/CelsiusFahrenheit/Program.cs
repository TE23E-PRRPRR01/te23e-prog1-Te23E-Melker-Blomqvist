// Program för att konvertera temperatur i celsius till fahrenheit
using System.IO.Compression;

Console.Clear();
Console.WriteLine("Program för att konvertera temperatur i celsius till fahrenheit");

// Läser in temp i celsius
Console.WriteLine("Ange temperatur i celsius");
int tempCelsius = int.Parse(Console.ReadLine());

// Konvertera till Fahrenheit
int tempFahrenheit = tempCelsius * 9 / 5 + 32;

// Skrivet ut resultat
Console.WriteLine($"{tempCelsius} Celsius är {tempFahrenheit} Farenheit");
