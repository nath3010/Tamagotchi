using System.Text.Json;
using Tamagotchi.Controller;
using Tamagotchi.Services;
using Tamagotchi.View;

namespace Tamagotchi
{
    internal class Program
    {
       
        static async Task Main(string[] args)
        {


            var app = new AppController();
            app.Jogar();

		}
        



    }
}

