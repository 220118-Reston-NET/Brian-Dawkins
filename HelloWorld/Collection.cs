namespace CollectionFunction
{

    public class Collection
    {
        //Array
        //Used to store a datatype and have a fixed size
        //Syntax: (datatype)[] (name of variable) = new (datatype)[(size of the array)];
        private int[] _nums = new int[5];

        //Generic Collection
        //They store a specific datatype and have variable size
        //Syntax: <(datatype )>

        //List Collection
        //zero-based index
        //Used to store a datatype and has variable size
        private List<string> strings = new List<string>();

        //Non=generic Collection
        //They store any datatype and have variable size

        public void CollectionMain()
        {
            Console.WriteLine("===Collection Demo===");

            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

        //A way to go through a list
        //For each will iterate through all of the elements of a collection/array
        //Syntax: ( (datatype) (Name of variable) in (Name of array/collection))
            Console.WriteLine("===Foreach Loop===");
            foreach ( int num in _nums)
            {
                Console.WriteLine(num);
        }

        // For loop is for a more complex way to iterate through a collection
        //Syntax: ((block 1 used to initialize some temp variable)); (block 2 - used for some condition to satisfy); (block 3 - how )
        Console.WriteLine("===For Loop===");
        for (int i = 0; i < _nums.Length; i+=2)
        {
            Console.WriteLine("Current value of i: "+ i);
            Console.WriteLine(_nums[i]);
        }

        Console.WriteLine("===Generic Collection===");
        Console.WriteLine("=List Demo=");
        strings.Add("First element");
        strings.Add("Second element");
        strings.Add("Third element");

        foreach(string item in strings)
        {
            Console.WriteLine(item);
        }

        }
    }
}