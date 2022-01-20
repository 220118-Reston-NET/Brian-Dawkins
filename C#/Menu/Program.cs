using FastFood;
using DataFunction;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Data newData = new Data();

bool repeat = true;

while (repeat)
{
    Console.WriteLine("Welcome to The Burger Joint!");
    Console.WriteLine("What would you like to eat?");
    Console.WriteLine(" [1] = Burger ");
    Console.WriteLine(" [2] = Fries ");
    Console. WriteLine(" [3] = Combo ");

    string userInput = Console.ReadLine();
    Console.Clear();

    if (userInput == "1")
    {
    Console.WriteLine("Great choice! You just ordered The Special");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();

    newData._addSpecial();

    Console.WriteLine("Will that complete your order?");
        Console.WriteLine("[1] Yes ");
        Console.WriteLine("[2] No");
        
        string userInput2 = Console.ReadLine();
        Console.ReadLine();
        
   
    if (userInput2 == "1")
    {
        Console.Clear();
        newData.showOrder();
        Console.WriteLine("Thank you! Your order will be ready shortly!");
        repeat = false;

       
    }
    else 
    {
        Console.WriteLine();
    }
}
    else if (userInput == "2")
    {
        Console.WriteLine("Great choice! You just ordered fries");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        newData._addFries();

        Console.WriteLine("Will that complete your order?");
        Console.WriteLine("[1] Yes ");
        Console.WriteLine("[2] No");
        
        string userInput2 = Console.ReadLine();
        Console.ReadLine();

    if (userInput2 == "1")
    {
        Console.Clear();
        newData.showOrder();
        Console.WriteLine("Thank you! Your order will be ready shortly!");
        repeat = false;
    }
    else 
    {
        Console.WriteLine();
    }
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Great choice! You just ordered a combo");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        newData._addCombo();

        Console.WriteLine("Will that complete your order?");
        Console.WriteLine("[1] Yes ");
        Console.WriteLine("[2] No");
        
        string userInput2 = Console.ReadLine();
        Console.ReadLine();

    if (userInput2 == "1")
    {
        Console.Clear();
        newData.showOrder();
        Console.WriteLine("Thank you! Your order will be ready shortly!");
        repeat = false;
    }
    else 
    {
        Console.WriteLine();
    }
    }
   
}
