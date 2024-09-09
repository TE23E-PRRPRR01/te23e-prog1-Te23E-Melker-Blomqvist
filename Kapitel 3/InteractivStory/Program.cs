// Program InteractiveStory
Console.Clear();
Console.WriteLine("Welcome to my dungeon game");

Console.WriteLine("You've arrived at the entrance to a cave, enter? (Yes/No)");
string answer = Console.ReadLine();

// Check if answer is yes or no
if (answer == "Yes")
{ // Yes
    Console.WriteLine("You are in the mouth of the cave and see two passages, turn right or left? (Right/Left)");
    answer = Console.ReadLine();
    if (answer == "Right")
    {
        Console.WriteLine("You end up in a chamber with a monster inside, turn back or fight? (Turn back/Fight)");
    }
    else
    {
        Console.WriteLine("You end up in a chamber filled with sharp rocks, you also spot a door at the other side. Go  and check the door or return back (Check the door/turn back)");
    }
}
else
{ // N
    Console.WriteLine("You decide to turn back, but you get lost in the forest (Try to get out/Set up camp)");
    answer = Console.ReadLine();
    if (answer == "Try to get out")
    {
        Console.WriteLine("You find yourself back on a different path, surrounded by fog. (Follow path north/Follow path south.)");
    }
    else
    {
        Console.WriteLine("You sleep for the night but wake up surrounded by goblins. (Stay still/Fight/Run)");
    }
}

