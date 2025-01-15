// 6.6
// MAIN

Console.Clear();

Console.WriteLine(Addera(1, 2));

string namn = "Malte";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

Console.WriteLine(Mult(5, 5));

Console.WriteLine(Div(10, 5));

// METODER

static int Addera(int tal1, int tal2) // signatur
{
    int summa = tal1 + tal2;
    return summa;
}

static string VändText(string text)
{
    string OmvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        OmvändText += text[i];
    }
    return OmvändText;
}

static double Mult(double tal1, double tal2)
{

    double summa = tal1 * tal2;

    return summa;
}

static double Div(double tal1, double tal2)
{
    double summa = tal1 / tal2;

    return summa;
}

// 6.7
string Längst(string text1, string text2)
{
    if (text2.Length > text1.lenght)
    {
        return text2;
    }
    else
    {
        return text1;
    }
}

Console.WriteLine($"längst av hej och hejsan är {längst("hej", "hejsan")}");

// 6.8
