using Tamagotchi.Model;
using Tamagotchi.Services;
using Tamagotchi.View;

namespace Tamagotchi.Controller
{
	public class AppController
	{
		private Telas Tela { get; set; }
		private List<Mascote> mascotesAdotados { get; set; }

        public AppController()
        {
			Tela = new Telas();
			mascotesAdotados = new List<Mascote>();
        }

		public void Jogar()
		{
			string nomeUsuario = Tela.BoasVindas();
			string opcaoMenu;
			bool continuar = true;

			while (continuar) 
			{ 
				opcaoMenu = Tela.TelaInicial(nomeUsuario);

				switch (opcaoMenu)
				{
					case "1":
						MenuAdocao(nomeUsuario);
						break;
					case "2":
						break;
					case "3":
						continuar = false;
						break;
					default:
						Console.WriteLine("Opção inválida!\n");
						break;

				}
				

			}
		}
		private void MenuAdocao(string nomeUsuario)
		{
			string opcaoMascote = Tela.TelaInicialAdocao(nomeUsuario);
			opcaoMascote = opcaoMascote.ToLower();

			if (opcaoMascote != "pikachu" && opcaoMascote != "gengar" && opcaoMascote != "mew")
			{
				Console.WriteLine("O mascote não existe!");
			}
			else
			{
				GetPokemonApi api = new();
				var mascote = api.GetPokemonAsync(opcaoMascote).Result;

				string opcaoMenuAdocao;
				bool continuar = true;

				while (continuar)
				{
					opcaoMenuAdocao = Tela.TelaOpcaoAdocao(mascote, nomeUsuario);


					switch (opcaoMenuAdocao)
					{
						case "1":
							Tela.TelaInfoPokemon(mascote);
							break;
						case "2":
							Tela.TelaFinalAdocao(nomeUsuario);
							mascotesAdotados.Add(mascote);
							continuar = false;
							break;
						case "3":
							continuar = false;
							break;
						default:
							Console.WriteLine("Opção Invalida!\n");
							break;
					}
				}
			}
		}

	}
}
