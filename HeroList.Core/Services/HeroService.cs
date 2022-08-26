using HeroList.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroList.Core.Services
{
	public class HeroService : IHeroService
	{
		public List<Hero> GetHeroList()
		{
			List<Hero> heroes = new List<Hero>()
			{
				new Hero()
				{
					Id = 1,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 2,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 3,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 4,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 5,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 6,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 7,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 8,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 9,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
				new Hero()
				{
					Id = 10,
					HeroName = "Green Lanter",
					PersonalName = "Hal Jordan"
				},
			};

			return heroes;
		}
	}
}
