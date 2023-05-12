using Tamagotchi.Helpers;
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
						MenuInteracao(mascotesAdotados, nomeUsuario);
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
				var pokemeon = api.GetPokemonAsync(opcaoMascote).Result;

				//var mascote = new Mascote(pokemeon);

				//Initializing AutoMapper
				var mapper = MapperConfig.InitializeAutomapper();
				var mascote = mapper.Map<Pokemon, Mascote>(pokemeon);

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

		private void MenuInteracao(List<Mascote> mascotes, string nomeUsuario)
		{
			string opcaoMenuInteracao;
			int opcaoMascoteInteracao;
			Mascote mascote = default;
			bool continuar = true;

			while (continuar)
			{
				opcaoMascoteInteracao = Tela.TelaConsultaMascote(mascotesAdotados);

				if (mascotes.ElementAtOrDefault(opcaoMascoteInteracao) == null)
				{
					Console.WriteLine("--------------------------------------------------------------------");
					Console.WriteLine("Você não possui esse pokemon!");
					Console.WriteLine("Digite a opção correta.");
					Console.WriteLine("--------------------------------------------------------------------");
				}
				else {
					mascote = mascotes[opcaoMascoteInteracao];
					break; 
				}
			}





			

			continuar = true;
				while (continuar)
				{
					opcaoMenuInteracao = Tela.TelaOpcaoInteracao(mascote, nomeUsuario);

					if (!mascote.Saude())
					{
						Tela.TelaGameOver(mascote);
						continuar = false;
					}

					switch (opcaoMenuInteracao)
					{
						case "1":
							Tela.TelaInfoMascote(mascote);
							break;
						case "2":
							mascote.Alimentar();
							Tela.TelaAlimetar(mascote);
							break;
						case "3":
							mascote.Brincar();
							Tela.TelaBrincar(mascote);
							break;
						case "4":
							mascote.Dormir();
							Tela.TelaDormir(mascote);
							break;
						case "5":
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
