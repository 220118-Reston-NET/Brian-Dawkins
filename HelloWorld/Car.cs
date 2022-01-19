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


}
}