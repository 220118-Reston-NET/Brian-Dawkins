namespace ConversionFunction
{

    public class Conversion
    {

        //Static fields aer shared between all objects from this class
        //In this way if you need a universal information that needs to be stored and shared to every object from this
        //Use a static field
        public static int _num;
        
        //static methods will make using that method without creating an object
        public static void ConversionMain()
        {

        }

        public int GiveMeNumber()
        {
            return _num;
        }
    }
}