// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörens flödesschema");

// Visa mig en ASCI art
Console.WriteLine($"""
                       -   ,--_--.
               -           \      `.
                      -     "-_ _   \
     -                         / F   )
                   -     -    / / `--'
              -              / /
                   -        / /
            -            __/ /
                        /,-pJ
           -        _--"-L ||
                  ,"      "//
     -           /  ,-"".//\
                /  /     // J____
               J  /     // L/----\
   .           F J     //__//^---'
     `     ___J  F    '----| |
  `       J---|  F         F F
`   `. `   `--J  L        J  F
    .   .`     L J       J  F
       .  .    J  \    ,"  F
         .  `.` \  "--"  ,"
    hs      ` ``."-____-"
""");

Console.WriteLine("Does it move? (Y/N) ");
string answer = Console.ReadLine();

// Check if answer is yes or no
if (answer == "Y")
{ // Y
    Console.WriteLine("Should it? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("No problem");
    }
    else
    {
        Console.WriteLine("Please use duct tape");
    }
}
else
{ // N
    Console.WriteLine("Should it? (Y/N)");
    answer = Console.ReadLine();
    if (answer == "Y")
    {
        Console.WriteLine("Please use WD-40!");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}
