using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.View;

namespace Tamagotchi.Controller
{
	public class AppController
	{
		public void Jogar()
		{
			bool continuar = true;
			string nomeJogador;
			string opcaoMenu;

			var mensagem = new Mensagens();

			mensagem.BoasVindas();
			nomeJogador = Console.ReadLine();

			while (continuar)
			{
				mensagem.Menu(nomeJogador);
				opcaoMenu = Console.ReadLine();

				switch (opcaoMenu)
				{
					case "1":
						mensagem.MenuAdocao(nomeJogador);
						break;
					case "2":
						break;
					case "3":
						continuar = false;
						break;
					default:
						Console.WriteLine("Opção inválida!");
						break;
				}
			}
		}
	}
}
