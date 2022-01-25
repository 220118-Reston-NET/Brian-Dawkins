using PokeModel;

namespace PokeBL
{

    public class PokemonBL : IPokemonBL
    {

        //Dependecy Injection
        //this is the main reason why we created interface first before the class
        //This will save you time on re-writting code that breaks if you updated a completely seperate class
        public Pokemon AddPokemon(Pokemon p_poke)
        {
            Random rand = new Random();

            //It will either substract or add a range from -5 to 5
            // p_poke.Attack += rand.Next(-5,5);
            // p_poke.Defense += rand.Next(-5,5);
            // p_poke.Health += rand.Next(-5,5);

            
        }
    }
}