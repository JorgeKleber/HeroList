using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HeroList.Core.ViewModels
{
	public class MainViewModel : MvxViewModel
	{
		public override Task Initialize()
		{
			return base.Initialize();

			Debug.WriteLine("---Inicializando MainViewModel!!!---");
		}
	}
}
