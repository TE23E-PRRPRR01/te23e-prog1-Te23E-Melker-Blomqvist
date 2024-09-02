// Program InteractiveStory
Console.Clear();
Console.WriteLine("Welcome to my dungeon game");

Console.WriteLine("You've arrived at a dungeon, enter? (Y/N)");
string answer = Console.ReadLine();

// Check if answer is yes or no
if (answer == "Y")
{ // Y
    Console.WriteLine("You are inside the opening of the cave, turn right or left? (R/L)");
    answer = Console.ReadLine();
    if (answer == "R")
    {
        Console.WriteLine("You meet with a goblin, do you run or fight? (Run/Fight)");
    }
    else
    {
        Console.WriteLine("You find a locked door and a knife on the floor, look for a key or turn back? (look for a key/turn back)");
    }
}
else
{ // N
    Console.WriteLine("You decide to turn back, but you get lost in the forest (Try to get out/Set up camp");
    answer = Console.ReadLine();
    if (answer == "Try to get out")
    {
        Console.WriteLine("You find yourself back on a different path, surrounded by fog. (Follow path/Follow path the other way.)");
    }
    else
    {
        Console.WriteLine("You sleep for the night but wake up surrounded by goblins. (Hide/Fight them)");
    }
}

