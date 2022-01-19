//Namespace is a great way to organize your code
namespace CarFunction
{

//This is how you create a class by using the class keyword
//Public is just there to make the class visible for everyone else
public class Car
{

//Field 
//It is used to store information or define the current state of the object when you first make it
// "_" is good practice to use in coding to make it easier
private string _color = "Blue"; 
private string _owner;
private int _fuel;
private int _gallonPerMile;

//Property
//They are in PascalCase ThisIsHowPascalCaseWillMakeASentence
public string Color
{
    //get keyword in a property is how you can make one of your private fields reasonable 
    get {return "the color is " + _color;}
    
    //set keyword in a property is how you can make one your private fields writeable 
    set { _color = value;}
}

public string Owner
{
    get { return _owner; }
    set { _owner = value; }
}

public int Fuel { get; set; }

//Constructor
//It is a special method that will run first whenever you create an object out of that class
public Car()
{
    _color = "Blue";
    _gallonPerMile = 10;
    _owner = "No Owner";
    Fuel = 100;
}

//A method will run multiple lines of code to do some sort of operation/behavior/function
//void this method will return/give back nothing 
//We can change void into another datatype if you want the method to give information back
public void Start()
{
    Console.WriteLine("The car is starting right now");
    Console.WriteLine($"Current fuel: {Fuel}");
}

//You can add parameters to a method to pass in data to be used inside method
//Make sure the parameter has a datatype and then a name
public void Start(int p_fuel)
{
    Fuel = p_fuel;
    Console.WriteLine("The car is starting right now");
    Console.WriteLine($"Current fuel: {Fuel}");
}

//Will give the total distance of a car
//Methods can return data back if you didnt put void
public double TotalDistance()
{

    return (double)Fuel/_gallonPerMile;
}

}
}