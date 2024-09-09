// Skapa ett program som implementerar valfria åldersgränser.
Console.Clear();
Console.WriteLine("Vad kan du göra? - Åldersgränser");


Console.WriteLine("Ange din ålder.");
int ålder = int.Parse(Console.ReadLine());





if (ålder >= 21)
        {
            Console.WriteLine("Du får styra flygplan och hoppa fallskärm.");
        }
        else if (ålder >= 18)
        {
            Console.WriteLine("Du får hoppa fallskärm.");
        }
        else
        {
            Console.WriteLine("Du får flyga bodyflight i en lufttunnel.");
        }