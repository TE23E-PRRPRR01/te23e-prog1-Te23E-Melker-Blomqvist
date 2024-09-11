// BMI
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("Program för att beräkna body mass index.");

// Fråga efter vikt 

Console.WriteLine("Ange din vikt i kg");

Double Vikt = double.Parse(Console.ReadLine());

// Fråga efter längd

Console.WriteLine("Ange din längd i meter");

double Längd = double.Parse(Console.ReadLine());





// Räkna ut BMI

double BMI =  Vikt / (Längd * Längd);

Console.WriteLine($"Dn BMI är {BMI}");