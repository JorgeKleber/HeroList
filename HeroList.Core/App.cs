using HeroList.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroList.Core
{
	/// <summary>
	/// Classe responsável por referenciar as interfaces do serviço ao IoC container.
	/// Classe responsável por definir qual viewmodel o app deve exibir inicialmente.
	/// </summary>,
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			base.Initialize();

			//Mvx.IoCProvider.RegisterType<IService, ServiceImplementation>();
			RegisterAppStart<MainViewModel>();
		}
	}
}
