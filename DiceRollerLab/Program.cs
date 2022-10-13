bool runProgram = true;
int numberOfSides = 0;
int firstDie = 0;
int secondDie = 0;

static int RandomRoll(int numberOfSides)
{
    Random random = new Random();
    int dice = random.Next(1, numberOfSides + 1);
    return dice;
}

static string ComboNames(int firstDie, int secondDie)
{
    if (firstDie == 1 && secondDie == 1)
    {
        return ("Snake Eyes!");
    }
    else if (firstDie == 1 && secondDie == 2)
    {
        return ("Ace Deuce!");
    }
    else if (firstDie == 2 && secondDie == 1)
    {
        return ("Ace Deuce!");
    }
    else if (firstDie == 6 && secondDie == 6)
    {
        return ("Box Cars!");
    }
    else return ("");
}

static string RollTotal(int total)
{
    if (total == 4 || total == 8)
    {
        return ("You won!");
    }
    else if (total == 2 || total == 3 || total == 12)
    {
        return ("Craps!");
    }
    else
    {
        return ("");
    }
}

Console.Write("How many sides should each die have: ");
numberOfSides = int.Parse(Console.ReadLine());

Console.WriteLine("Press any key to roll the dice.");
Console.ReadKey();

while (runProgram)
{
    firstDie = RandomRoll(numberOfSides);
    secondDie = RandomRoll(numberOfSides);
    int total = firstDie + secondDie;
    Console.WriteLine($"You got a {firstDie} and {secondDie}. Your total is {total}.");
    if (numberOfSides == 6)
    {
        Console.WriteLine(ComboNames(firstDie, secondDie));
        Console.WriteLine(RollTotal(total));
    }
    while (true)
    {
        Console.Write("Would you like to roll again? (y/n): ");
        string rollAgain = Console.ReadLine().Trim().ToLower();
        if (rollAgain == "y")
        {
            break;
        }
        else if (rollAgain == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("You did not input a 'y' or 'n'.");
        }
    }
}
Console.WriteLine("Goodbye.");