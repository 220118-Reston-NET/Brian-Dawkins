
using FastFood;

bool repeat = true;

while (repeat)
{
    Console.WriteLine("Welcome to The Burger Joint!");
    Console.WriteLine("What would you like to eat?");
    Console.WriteLine(" [1] = Burger ");
    Console.WriteLine(" [2] = Fries ");
    Console. WriteLine(" [3] = Combo ");

    string userInput = Console.ReadLine();

    if (userInput == "1")
    {
    Console.WriteLine("Great choice! You just ordered The Special");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}
    else if (userInput == "2")
    {
        Console.WriteLine("Great choice! You just ordered fries");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Great choice! You just ordered a combo");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
    
}
