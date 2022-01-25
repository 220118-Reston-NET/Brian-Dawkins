using System.Text.Json;
using PokeModel;

namespace PokeDL
{

    public class Repository : IRepository
    {
        private string _filepath = "../PokeDL/Database/";
        private string _jsonString;
        public Pokemon AddPokemon(Pokemon p_poke)
        {
            //So we can change which JSON files we can pick on other methods
            string path = _filepath + "Pokemon.json";

            _jsonString = JsonSerializer.Serialize(p_poke);

            File.WriteAllText(path, _jsonString);

            return p_poke;
        }
    }
}