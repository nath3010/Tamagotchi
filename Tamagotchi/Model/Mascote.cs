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

        private void Initialize()
        {
            Random valorAleatorio = new Random();
            this.Alimentacao = valorAleatorio.Next(3, 10);
            this.Humor = valorAleatorio.Next(3, 10);
            this.Sono = valorAleatorio.Next(3, 10);
        }
        public Mascote()
        {
            Initialize();

		}

        public Mascote(Pokemon pokemon)
        {
            Initialize();

			this.name = pokemon.name;
            this.height = pokemon.height;
            this.weight = pokemon.weight;
            this.abilities = pokemon.abilities;
        }

        public bool Fome()
        {
            return Alimentacao > 5 ? true : false;

        }

        public bool Descanso() 
        { 
            return Sono > 5 ? true : false; 
        }

        public bool Emocao() 
        { 
            return Humor > 5 ? true : false; 
        }

        public void Alimentar()
        {
            Alimentacao++;
        }

        public void Dormir() 
        { 
            Alimentacao--;
            Sono++;
        }

        public void Brincar()
        { 
            Alimentacao--;
			Sono--;
			Humor++;
        }

        public bool Saude()
        {
			return (Alimentacao > 0 && Humor > 0 && Sono > 0) ? true : false;
        }
    }
}
    