﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tamagotchi.Model;

namespace Tamagotchi.Services
{
    public class GetPokemonApi
    {
         public async Task<Pokemon> GetPokemonAsync(string name)
        {
            using(HttpClient client = new HttpClient())
            {
                var endpoint = new Uri($"https://pokeapi.co/api/v2/pokemon/{name}");

                var response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode) 
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    
                    

                    return JsonSerializer.Deserialize<Pokemon>(responseString);
                }   

                else return null;
            }
        }


    }
}
