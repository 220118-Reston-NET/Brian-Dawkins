using PokeModel;

namespace PokeBL
{
/// <summary>
/// Business Layer is responsible for further validation or processing of data obtained from either the database or the user
/// What kind of processing? That all depends on the type of functionality you will be doing 
/// </summary>

public interface IPokemonBL
{
/// <summary>
/// Will add a pokemon data to the database
/// Initial addition of a pokemon will give it some sort of a randomize stats
/// </summary>
/// <param name="p_poke"></param>
/// <returns></returns>
    Pokemon AddPokemon(PokemonBL p_poke);
        void AddPokemon(Pokemon newPoke);
        // void AddPokemon(Pokemon newPoke);
    }
}