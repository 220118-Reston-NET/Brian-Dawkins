﻿// See https://aka.ms/new-console-template for more information
using CarFunction;
using CollectionFunction;
using ConversionFunction;
using SerializationFunction;

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

// Initialized Collection class
// Collection collect = new Collection();
// collect.CollectionMain();

// Conversion.ConversionMain();
// Conversion._num = 10;
// Conversion conv1 = new Conversion();
// Conversion conv2 = new Conversion();

// Console.WriteLine(conv1.GiveMeNumber());
// Console.WriteLine(conv2.GiveMeNumber());

Serialization.SerialMain();