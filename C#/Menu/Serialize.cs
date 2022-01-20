
using System.Text.Json;
using DataFunction;



namespace SerializationFunction
{
    public class Serialization
    {
        private static string _filepath = "./Database/collection.json";

        

         public static void SerialMain()
         {
           
            //Created a list of items
            List<Data> amountOfItems = new List<Data>(); 

            Data itemData = new Data();
            {
                Console.WriteLine(itemData.showOrder);
            }

            amountOfItems.Add(itemData);
            amountOfItems.Add(itemData);
            
            //Adding the _amountofitems from Data file
            string jsonString = JsonSerializer.Serialize(amountOfItems, new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);

            //File class will creat a JSON file (if there isnt one already) or overwrite
            File.WriteAllText(_filepath, jsonString);

            //File.ReadAllText() static method will read our JSON file and store it in out jsonString2
            string jsonString2 = File.ReadAllText(_filepath);

            //JsonSerializer converts the JSON object into a C3 object
            List<Data> amountOfItems1 = JsonSerializer.Deserialize<List<Data>>(jsonString2);

            Console.WriteLine(amountOfItems1[0]._items);
    
         }
    }
}