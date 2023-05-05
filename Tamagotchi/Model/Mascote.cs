using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Model
{
	public class Mascote : Pokemon
	{
        public int Alimentacao { get; set; }
		public int Humor { get; set; }
		public int Sono { get; set; }
		public DateTime DataNascimento { get; set; }

        public Mascote(Pokemon pokemon)
        {
            this.name = pokemon.name;
            this.height = pokemon.height;
            this.weight = pokemon.weight;
            this.abilities = pokemon.abilities;
        }

    }
}
