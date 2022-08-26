using HeroList.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroList.Core.Services
{
	public interface IHeroService
	{
		List<Hero> GetHeroList();
	}
}
