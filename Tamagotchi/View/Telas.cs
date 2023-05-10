using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Model;

namespace Tamagotchi.View
{
	public class Telas
	{
		public string BoasVindas()
		{
			Console.WriteLine("╔════╗╔═══╗╔═╗╔═╗╔═══╗╔═══╗╔═══╗╔═══╗╔╗─╔╗╔══╗\r\n║╔╗╔╗║║╔═╗║║║╚╝║║║╔═╗║║╔═╗║║╔═╗║║╔═╗║║║─║║╚╣─╝\r\n╚╝║║╚╝║║─║║║╔╗╔╗║║║─║║║║─╚╝║║─║║║║─╚╝║╚═╝║─║║─\r\n──║║──║╚═╝║║║║║║║║╚═╝║║║╔═╗║║─║║║║─╔╗║╔═╗║─║║─\r\n──║║──║╔═╗║║║║║║║║╔═╗║║╚╩═║║╚═╝║║╚═╝║║║─║║╔╣─╗\r\n──╚╝──╚╝─╚╝╚╝╚╝╚╝╚╝─╚╝╚═══╝╚═══╝╚═══╝╚╝─╚╝╚══╝\n");

			Console.WriteLine("Qual é o seu nome?");
			string nomeJogador = Console.ReadLine();

			return nomeJogador;

		}

		public string TelaInicial(string nomeJogador)
		{
			Console.WriteLine("-------------------------- Tela ---------------------------------------");
			Console.WriteLine($"{nomeJogador} Você deseja:");
			Console.WriteLine("1 - Adotar um Mascote Virtual");
			Console.WriteLine("2 - Ver seus Mascotes");
			Console.WriteLine("3 - Sair \n");

			string opcaoTela = Console.ReadLine();

			return opcaoTela;
		}

		public string TelaInicialAdocao(string nomeJogador)
		{
			Console.WriteLine("-------------------------- ADOTAR MASCOTE --------------------------");
			Console.WriteLine($"{nomeJogador} Qual mascote você deseja adotar:");
			Console.WriteLine("PIKACHU");
			Console.WriteLine("GENGAR");
			Console.WriteLine(" MEW");

			string mascote = Console.ReadLine();

			return mascote;
		}

		public string TelaOpcaoAdocao(Pokemon mascote, string nomeJogador)
		{
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine($"{nomeJogador} Você deseja:");
			Console.WriteLine($"1 - Saber mais sobre {mascote.name}");
			Console.WriteLine($"2 - Adotar {mascote.name}");
			Console.WriteLine("3 - Voltar");

			string opcaoAdocao = Console.ReadLine();
			return opcaoAdocao;
		}

		public void TelaInfoPokemon(Pokemon mascote)
		{
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine(mascote);

		}

		public void TelaFinalAdocao(string nomeJogador)
		{
			Console.WriteLine($"Parabéns {nomeJogador}, Mascote adotado!! O ovo está chocando:");
			Console.WriteLine("                                                                          \r\n                                                                          \r\n                                                                          \r\n                                ████████                                  \r\n                              ██        ██                                \r\n                            ██▒▒▒▒        ██                              \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          \r\n                        ██                ▒▒▒▒██                          \r\n                      ██▒▒      ▒▒▒▒▒▒          ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        \r\n                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        \r\n                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          \r\n                        ██▒▒▒▒            ▒▒▒▒██                          \r\n                          ██▒▒              ██                            \r\n                            ████        ████                              \r\n                                ████████                                  \r\n                                                                          \r\n                                                                          \r\n                                                                          \r\n");

		}
		public int TelaConsultaMascote(List<Mascote> mascotes) 
		{
			Console.WriteLine($"Você Possui: {mascotes.Count} mascotes.");
			
			for(int i = 0; i < mascotes.Count; i++)
			{
				Console.WriteLine($"{i+1} - {mascotes[i].name}");
			}

			Console.WriteLine("Qual mascote deseja interagir?");
			int mascoteIndice = (int.Parse(Console.ReadLine())) - 1;

			return mascoteIndice;
		}

		public string TelaOpcaoInteracao(Mascote mascote, string nomeJogador)
		{
			Console.WriteLine("-------------------------- Tela ---------------------------------------");
			Console.WriteLine($"{nomeJogador} Você deseja:");
			Console.WriteLine($"1 - Saber mais como {mascote.name}");
			Console.WriteLine($"2 - Alimentar o {mascote.name}");
			Console.WriteLine($"3 - Brincar com {mascote.name}");
			Console.WriteLine($"4 - Colocar {mascote.name} para dormir");
			Console.WriteLine("5 - Voltar \n");

			string opcaoTela = Console.ReadLine();

			return opcaoTela;

		}

		public void TelaInfoMascote(Mascote mascote)
		{
			Console.WriteLine($"---------------------Informações {mascote.name} ------------------------");
			if (mascote.Fome()) 
			{ 
				Console.WriteLine($"{mascote.name} está alimentado!"); 
			}
			else 
			{ Console.WriteLine($"{mascote.name} está com fome!"); 

			}
			 
			if(mascote.Descanso()) 
			{
				Console.WriteLine($"{mascote.name} está descansado!");
			}
			else 
			{
				Console.WriteLine($"{mascote.name} está com sono");
			}

			if (mascote.Emocao())
			{
				Console.WriteLine($"{mascote.name} está Feliz!");
			}
			else
			{
				Console.WriteLine($"{mascote.name} está triste!");
			}
		}

		public void TelaAlimetar(Mascote mascote)
		{
			Console.WriteLine("-------------------------------------------------------------------------");
			Console.WriteLine("(O_O) hmmmm ");
			Console.WriteLine($"{mascote.name} alimentado!");
		}

		public void TelaDormir(Mascote mascote)
		{
			Console.WriteLine("--------------------------------------------------------------------------");
			Console.WriteLine("(-_-) <( Zzz)");
			Console.WriteLine($"{mascote.name} está dormindo!");
		}

		public void TelaBrincar(Mascote mascote)
		{
			Console.WriteLine("--------------------------------------------------------------------------");
			Console.WriteLine("(O v O) uhu ");
			Console.WriteLine($"{mascote.name} está brincando!");
		}

		public void TelaGameOver(Mascote mascote)
		{
			Console.WriteLine("---------------------------------------------------------------------------");
			Console.WriteLine($"{mascote.name} MORREU!");
			Console.WriteLine("\r\n _______  _______  __   __  _______   _______  __   __  _______  ______   \r\n|       ||   _   ||  |_|  ||       | |       ||  | |  ||       ||    _ |  \r\n|    ___||  |_|  ||       ||    ___| |   _   ||  |_|  ||    ___||   | ||  \r\n|   | __ |       ||       ||   |___  |  | |  ||       ||   |___ |   |_||_ \r\n|   ||  ||       ||       ||    ___| |  |_|  ||       ||    ___||    __  |\r\n|   |_| ||   _   || ||_|| ||   |___  |       | |     | |   |___ |   |  | |\r\n|_______||__| |__||_|   |_||_______| |_______|  |___|  |_______||___|  |_|\r\n");
		}
	}
}
