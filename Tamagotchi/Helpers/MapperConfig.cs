using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Model;

namespace Tamagotchi.Helpers
{
	public class MapperConfig
	{
		public static Mapper InitializeAutomapper()
		{
			//Provide all the Mapping Configuration
			var config = new MapperConfiguration(cfg =>cfg.CreateMap<Pokemon, Mascote>());

			//Create an Instance of Mapper and return that Instance
			var mapper = new Mapper(config);

			return mapper;
		}
	}
}
