﻿// See https://aka.ms/new-console-template for more information
// using PokeModel;
global using Serilog; //global using will implicitly import that namespace to the rest of your C# files inside of this project
using PokeBL;
using PokeDL;
using PokeUI;

//Console.WriteLine("Hello, World!");
// Ability ab = new Ability();
// ab.PP = -1; //Validation is working since can't input a negative value

/// <summary>
/// Creating adnd configuring out logger
/// </summary>
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt") // We configured our logger to save in this file 
    .CreateLogger();


bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();
    
    switch (ans)
    {
        case "SearchPokemon":
        Log.Information("Displaying SearchPokemon Menu to user");
            menu = new SearchPokemonMenu(new PokemonBL(new Repository()));
            break;
        case "AddPokemon":
        Log.Information("Displaying AddPokemon Menu to user");
            menu = new AddPokeMenu(new PokemonBL(new Repository()));
            break;
        case "MainMenu":
            Log.Information("Displaying MainMenu to user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Information("Exiting application");
            Log.CloseAndFlush(); //To close our logger resource
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
            break;
    }
}