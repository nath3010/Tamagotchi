using System;
using System.Collections.Generic;
using System.Linq;
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

		public string TelaOpcaoAdocao(Mascote mascote, string nomeJogador)
		{
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine($"{nomeJogador} Você deseja:");
			Console.WriteLine($"1 - Saber mais sobre {mascote.name}");
			Console.WriteLine($"2 - Adotar {mascote.name}");
			Console.WriteLine("3 - Voltar");

			string opcaoAdocao = Console.ReadLine();
			return opcaoAdocao;
		}

		public void TelaInfoPokemon(Mascote mascote)
		{
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine(mascote);

		}

		public void TelaFinalAdocao(string nomeJogador)
		{
			Console.WriteLine($"Parabéns {nomeJogador}, Mascote adotado!! O ovo está chocando:");
			Console.WriteLine("                                                                          \r\n                                                                          \r\n                                                                          \r\n                                ████████                                  \r\n                              ██        ██                                \r\n                            ██▒▒▒▒        ██                              \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          \r\n                        ██                ▒▒▒▒██                          \r\n                      ██▒▒      ▒▒▒▒▒▒          ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        \r\n                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        \r\n                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          \r\n                        ██▒▒▒▒            ▒▒▒▒██                          \r\n                          ██▒▒              ██                            \r\n                            ████        ████                              \r\n                                ████████                                  \r\n                                                                          \r\n                                                                          \r\n                                                                          \r\n");

		}


	}
}
