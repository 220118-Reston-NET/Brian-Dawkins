namespace DataFunction
{


public class Data
{
 // Represents the item "The Special"
 public static int _theSpecial = 1;

 //Represents the item "Fries"
 public static int _fries = 2;

 //Represents the item "Combo"
 public static int _combo = 3;

 //Represents total items ordered
 public int _items {get; set; }

 //Array storing items
 public int[] _amountOfItems = new int[2];

 //Initializing variables
 public void start()
 {
     _items = 0;

     //0 = Specials ordered
     //1 = Fries ordered
     //2 = Combos ordered

     _amountOfItems[0] = 0;
     _amountOfItems[1] = 0;
     _amountOfItems[2] = 0;
 }

 //How to clear item list
 public void clear()
 {
     _amountOfItems[0] = 0;
     _amountOfItems[1] = 0;
     _amountOfItems[2] = 0;
 }

 //Adds a single Special to the order 
 public void _addSpecial()
 {
     _amountOfItems[0] = _amountOfItems[0] + 1;
 }

 //Adds a single order of fries to the order
 public void _addFries()
 {
     _amountOfItems[1] = _amountOfItems[1] + 1;
 }

 //Adds a single combo to the order 
 public void _addCombo()
 {
     _amountOfItems[2] = _amountOfItems[2] + 1;
 }

 //Removes one special
 public void removeSpecial()
 {
     _amountOfItems[0] = _amountOfItems[0] - 1;
     Console.WriteLine("You have removed one Special from your order");
     Console.WriteLine("You have " + _amountOfItems[0] + " Specials in your order");
 }

//Removes one order of fries
public void removeFries()
 {
     _amountOfItems[1] = _amountOfItems[1] - 1;
     Console.WriteLine("You have removed one order of fries from your order");
     Console.WriteLine("You have " + _amountOfItems[1] + " fries in your order");
 }

//Removes one combo
 public void removeCombo()
 {
     _amountOfItems[2] = _amountOfItems[2] - 1;
     Console.WriteLine("You have removed one combo from your order");
     Console.WriteLine("You have " + _amountOfItems[2] + " Specials in your order");
 }

//Displays the order

public void showOrder()
{
    Console.WriteLine("You have " + _amountOfItems[0] + " Specials");
    Console.WriteLine("You have " + _amountOfItems[1] + " fries");
    Console.WriteLine("You have " + _amountOfItems[2] + " combos");
    Console.WriteLine();
}
}
}