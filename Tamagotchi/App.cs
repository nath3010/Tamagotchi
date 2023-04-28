using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Tamagotchi
{
    public class App
    {

        public App()
        {
            MainMenu();
            
        }
        private void MainMenu()
        {
            Console.WriteLine("╔════╗╔═══╗╔═╗╔═╗╔═══╗╔═══╗╔═══╗╔═══╗╔╗─╔╗╔══╗\r\n║╔╗╔╗║║╔═╗║║║╚╝║║║╔═╗║║╔═╗║║╔═╗║║╔═╗║║║─║║╚╣─╝\r\n╚╝║║╚╝║║─║║║╔╗╔╗║║║─║║║║─╚╝║║─║║║║─╚╝║╚═╝║─║║─\r\n──║║──║╚═╝║║║║║║║║╚═╝║║║╔═╗║║─║║║║─╔╗║╔═╗║─║║─\r\n──║║──║╔═╗║║║║║║║║╔═╗║║╚╩═║║╚═╝║║╚═╝║║║─║║╔╣─╗\r\n──╚╝──╚╝─╚╝╚╝╚╝╚╝╚╝─╚╝╚═══╝╚═══╝╚═══╝╚╝─╚╝╚══╝\n");

            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Menu(nome);

        }

        private void AdotarMascote(String nome)
        {
            while (true)
            {
                Console.WriteLine("-------------------------- ADOTAR MASCOTE --------------------------");
                Console.WriteLine($"{nome} Qual mascote você deseja adotar:");
                Console.WriteLine("PIKACHU");
                Console.WriteLine("GENGAR");
                Console.WriteLine(" MEW");

                String mascote = Console.ReadLine();
                mascote = mascote.ToLower();

                if (mascote != "pikachu" && mascote != "gengar" && mascote != "mew")
                {
                    Console.WriteLine("O mascote não existe!");

                }

                else
                {
                    bool a = true;
                    while (a)
                    {
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine($"{nome} Você deseja:");
                        Console.WriteLine($"1 - Saber mais sobre {mascote}");
                        Console.WriteLine($"2 - Adotar {mascote}");
                        Console.WriteLine("3 - Voltar");

                        string opcaoAdocao = Console.ReadLine();

                        switch (opcaoAdocao)
                        {
                            case "1":
                                Console.WriteLine("--------------------------------------------------------------------");
                                GetPokemonApi api = new();
                                var pokemon = api.GetPokemon(mascote).Result;
                                Console.WriteLine(pokemon);
                                break;
                            case "2":
                                Console.WriteLine($"Parabéns {nome}, Mascote adotado!! O ovo está chocando:");
                                Console.WriteLine("                                                                          \r\n                                                                          \r\n                                                                          \r\n                                ████████                                  \r\n                              ██        ██                                \r\n                            ██▒▒▒▒        ██                              \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                          ██▒▒▒▒▒▒      ▒▒▒▒██                            \r\n                        ██  ▒▒▒▒        ▒▒▒▒▒▒██                          \r\n                        ██                ▒▒▒▒██                          \r\n                      ██▒▒      ▒▒▒▒▒▒          ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒        ██                        \r\n                      ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        \r\n                      ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        \r\n                        ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          \r\n                        ██▒▒▒▒            ▒▒▒▒██                          \r\n                          ██▒▒              ██                            \r\n                            ████        ████                              \r\n                                ████████                                  \r\n                                                                          \r\n                                                                          \r\n                                                                          \r\n");
                                a = false;
                                break;

                            case "3":
                                a = false;
                                Menu(nome);
                                break;
                        }
                    }

                    break;
                }
            }


        }

        private void Menu(string nome)
        {

            Console.WriteLine("-------------------------- MENU ---------------------------------------");
            Console.WriteLine($"{nome} Você deseja:");
            Console.WriteLine("1 - Adotar um Mascote Virtual");
            Console.WriteLine("2 - Ver seus Mascotes");
            Console.WriteLine("3 - Sair \n");

            string opcaoMenu = Console.ReadLine();

            switch (opcaoMenu)
            {
                case "1":
                    AdotarMascote(nome);
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                case "3":
                    Console.WriteLine($"Tchau {nome}, até a proxíma!");
                    break;
            }
        }



    }
}
