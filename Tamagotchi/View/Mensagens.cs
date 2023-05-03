using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Tamagotchi.View
{
    public class Mensagens
	{

        public void BoasVindas()
        {
            Console.WriteLine("╔════╗╔═══╗╔═╗╔═╗╔═══╗╔═══╗╔═══╗╔═══╗╔╗─╔╗╔══╗\r\n║╔╗╔╗║║╔═╗║║║╚╝║║║╔═╗║║╔═╗║║╔═╗║║╔═╗║║║─║║╚╣─╝\r\n╚╝║║╚╝║║─║║║╔╗╔╗║║║─║║║║─╚╝║║─║║║║─╚╝║╚═╝║─║║─\r\n──║║──║╚═╝║║║║║║║║╚═╝║║║╔═╗║║─║║║║─╔╗║╔═╗║─║║─\r\n──║║──║╔═╗║║║║║║║║╔═╗║║╚╩═║║╚═╝║║╚═╝║║║─║║╔╣─╗\r\n──╚╝──╚╝─╚╝╚╝╚╝╚╝╚╝─╚╝╚═══╝╚═══╝╚═══╝╚╝─╚╝╚══╝\n");

            Console.WriteLine("Qual é o seu nome?");

        }
		public void Menu(string nomeJogador)
		{
			Console.WriteLine("-------------------------- MENU ---------------------------------------");
			Console.WriteLine($"{nomeJogador} Você deseja:");
			Console.WriteLine("1 - Adotar um Mascote Virtual");
			Console.WriteLine("2 - Ver seus Mascotes");
			Console.WriteLine("3 - Sair \n");

		}


		public void MenuAdocao(string nomeJogador)
        {
            while (true)
            {
                Console.WriteLine("-------------------------- ADOTAR MASCOTE --------------------------");
                Console.WriteLine($"{nomeJogador} Qual mascote você deseja adotar:");
                Console.WriteLine("PIKACHU");
                Console.WriteLine("GENGAR");
                Console.WriteLine(" MEW");

                string mascote = Console.ReadLine();
                mascote = mascote.ToLower();

                if (mascote != "pikachu" && mascote != "gengar" && mascote != "mew")
                {
                    Console.WriteLine("O mascote não existe!");

                }

                else
                {
                    bool continuar = true;
                    while (continuar)
                    {
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine($"{nomeJogador} Você deseja:");
                        Console.WriteLine($"1 - Saber mais sobre {mascote}");
                        Console.WriteLine($"2 - Adotar {mascote}");
                        Console.WriteLine("3 - Voltar");

                        string opcaoAdocao = Console.ReadLine();

                        switch (opcaoAdocao)
                        {
                            case "1":
                                Console.WriteLine("--------------------------------------------------------------------");
                                
                                GetPokemonApi api = new();
                                var pokemon = api.GetPokemonAsync(mascote).Result;
                                Console.WriteLine(pokemon);
                                
                                break;

                            case "2":
                                Console.WriteLine($"Parabéns {nomeJogador}, Mascote adotado!! O ovo está chocando:");
                                Console.WriteLine("                                                                          \r\n                                                                          \r\n                                                                          \r\n                                ████████                                  \r\n                              ██        ██                                \r\n                            ██▒▒▒▒        ██                              \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          \r\n                        ██                ▒▒▒▒██                          \r\n                      ██▒▒      ▒▒▒▒▒▒          ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        \r\n                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        \r\n                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          \r\n                        ██▒▒▒▒            ▒▒▒▒██                          \r\n                          ██▒▒              ██                            \r\n                            ████        ████                              \r\n                                ████████                                  \r\n                                                                          \r\n                                                                          \r\n                                                                          \r\n");
								
                                
                                continuar = false;
                                break;

                            case "3":
								continuar = false;
                                Menu(nomeJogador);
                                break;
                        }
                    }

                    break;
                }
            }


        }


    }
}
