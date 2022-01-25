using PokeModel;

namespace PokeDL
{
/// <summary>
/// Data layer project is responsible for interacting with out database and doing CRUD operations
/// C - Creat, R - Read, U - Update, D- Delete
/// It must not have logical ooperation that will also manipulate the data it is grabbing
/// Just think of Data layer as the delivery man of your uber eats. You definitely dont want your delivery man to touch 
/// the food he is delivering and just give it to you so you can do whatever you want with it.
/// </summary>
public class IRepository
{
    /// <summary>
    /// Add a pokemon to the database
    /// </summary>
    /// <param name="p_poke"> This is the pokemon object we are adding to the database </param>
    /// <returns>Returns the pokemon that was added </returns>
    Pokemon AddPokemon(Pokemon p_poke);
}
}