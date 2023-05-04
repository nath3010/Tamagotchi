using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tamagotchi.Program;

namespace Tamagotchi.Model
{
    public class Pokemon
    {
        public List<Abilitys> abilities { get; set; }
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        public override string ToString()
        {
            string pokemonAbilities = "";

            if (abilities != null)
            {
                foreach (var habilidade in abilities)
                {
                    pokemonAbilities += habilidade.ability.name + "\n";
                }
            }
            return $"Nome: {name}\n" +
                $"Altura: {height}\n" +
                $"Peso: {weight}\n" +
                $"Habilidades:\n {pokemonAbilities}";

        }

    }
}
