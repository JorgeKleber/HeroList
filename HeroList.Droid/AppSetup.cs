using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HeroList.Core;
using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroList.Droid
{
	public class AppSetup : MvxAndroidSetup<App>
	{
		protected override ILoggerFactory CreateLogFactory() => null;

		protected override ILoggerProvider CreateLogProvider() => null;
	}
}