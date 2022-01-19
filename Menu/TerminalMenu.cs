//Terminal Menu
//Fast Food Model 

namespace FastFood
{
    public class Food
    {

        private string _burger = "The Special";
        private string _side = "Fries";
        private string _combo = "The special with fries and a drink";

        public string Burger
        {
            get {return " You just ordered " + _burger;}
            set { _burger = value; } 
        }

        public string Fries 
        {
            get {return " You just ordered " + _side;}
            set {_side = value;}
        }

        public string Combo 
        {
            get {return "Great choice! You just ordered " + _combo;}
            set {_combo = value;}
        }

}
}