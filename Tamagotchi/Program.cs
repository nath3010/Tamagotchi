using System.Text.Json;
using Tamagotchi.Services;

namespace Tamagotchi
{
    internal class Program
    {
       
        static async Task Main(string[] args)
        {
            GetPokemonApi api = new();
            var pokemon = api.GetPokemon("pikachu").Result;
            Console.WriteLine(pokemon);

        }
        



    }
}

