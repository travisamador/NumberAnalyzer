Console.WriteLine("Welcome to the number analyzer. Please enter your name.");
string user = Console.ReadLine();
while (true)
{
    Console.WriteLine();
    Console.WriteLine(user + ", please enter an integer between 1 to 100");
    int input = int.Parse(Console.ReadLine());
    if (input <= 1 || input >= 100)
    {
        Console.WriteLine(user + ", the number entered must be an integer between 1 and 100. Please enter a different number.");
        continue;
    }
    if (input % 2 != 0)
    {
        if (input < 60)
        {
            Console.WriteLine(input + " Odd and less than 60");
        }
        else
        {
            Console.WriteLine(input + " Odd and greater than 60");
        }
    }
    else
    {
        if (input >= 2 && input <= 24)
        {
            Console.WriteLine("Even and less than 25");
        }
        if (input >= 26 && input <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive");
        }
        if (input > 60)
        {
            Console.WriteLine(input + " Even and greater than 60");
        }
    }
    Console.WriteLine(user + ", would you like to stop running this application? Enter yes or y to exit, enter anything else to continue.");
    string exit = Console.ReadLine();
    if (exit.ToLower().Trim() == "yes" || exit.ToLower().Trim() == "y")
    {
        break;
    }
}
