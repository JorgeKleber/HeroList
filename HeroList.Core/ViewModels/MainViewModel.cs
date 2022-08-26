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
		private string _PageTitle;

		public string PageTitle
		{
			get => _PageTitle;
			set
			{
				_PageTitle = value;
				RaisePropertyChanged(() => PageTitle);
			}
		}


		public override Task Initialize()
		{
			return base.Initialize();

			PageTitle = "Olá eu sou Kleber!!!";

			Debug.WriteLine("---Inicializando MainViewModel!!!---");
		}
	}
}
