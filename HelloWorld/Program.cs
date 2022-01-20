// See https://aka.ms/new-console-template for more information
using CarFunction;
using CollectionFunction;
using ConversionFunction;
using FastFood;
using DataFunction;

//This will print whatever string you put in the parentheses in the terminal 
Console.WriteLine("Hello, World!");

//NameofClass NameofVariable = new NameofClass();
//Initializing an object out of a class
// Car car1 = new Car();
// Console.WriteLine(car1.Color);
// car1.Color = "Red";
// Console.WriteLine(car1.Color);
// car1.Fuel = 10;
// Console.WriteLine(car1.Fuel);
// car1.Start();
// car1.Start(100);

// //Anpohter way of initializing a object out of a class but preconfiguring our states already
// Car car2 = new Car()
// {
//     Color = "Yellow",
//     Fuel = 1000,
//     Owner = "Stephen"
// };

// Console.WriteLine(car2.Color);
// Console.WriteLine(car2.TotalDistance());
// bool repeat = true;

// while (repeat)
// {

// //Console.Clear();
// Console.WriteLine("Welcome to programming!");
// Console.WriteLine("Please tell me your name");
// string name = Console.ReadLine();
// Console.WriteLine($"Hello {name}, what do you want to do today?");
// Console.WriteLine("[1] = Add two numbers");
// Console.WriteLine("[2] = Exit");

// string userInput = Console.ReadLine();

// if (userInput == "1")
// {
//     Console.WriteLine("Please give me two numbers");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"The sum is: {num2+num1}");
//     Console.WriteLine("Please press Enter to continue");
//     Console.ReadLine();
// }
// else if(userInput == "2")
// {
//     repeat = false;
// }
// }

//Initialized Collection class
// Collection collect = new Collection();
// collect.CollectionMain();

// Conversion.ConversionMain();
// Conversion._num = 10;
// Conversion conv1 = new Conversion();
// Conversion conv2 = new Conversion();

// Console.WriteLine(conv1.GiveMeNumber());
// Console.WriteLine(conv2.GiveMeNumber());

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

    if (userInput == "1")
    {
    Console.WriteLine("Great choice! You just ordered The Special");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();

    Console.WriteLine("Will that complete your order?");
        Console.WriteLine("[1] Yes ");
        Console.WriteLine("[2] No");
        
        string userInput2 = Console.ReadLine();
        Console.ReadLine();

    if (userInput2 == "1")
    {
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

        Console.WriteLine("Will that complete your order?");
        Console.WriteLine("[1] Yes ");
        Console.WriteLine("[2] No");
        
        string userInput2 = Console.ReadLine();
        Console.ReadLine();

    if (userInput2 == "1")
    {
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

        Console.WriteLine("Will that complete your order?");
        Console.WriteLine("[1] Yes ");
        Console.WriteLine("[2] No");
        
        string userInput2 = Console.ReadLine();
        Console.ReadLine();

    if (userInput2 == "1")
    {
        Console.WriteLine("Thank you! Your order will be ready shortly!");
        repeat = false;
    }
    else 
    {
        Console.WriteLine();
    }
    }
   
}
