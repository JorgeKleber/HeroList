﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HeroList.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroList.Droid
{
	[Application]
	public class MainApplication : MvxAndroidApplication<AppSetup, App>
	{
		public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) 
			: base(javaReference, transfer)
		{

		}
	}
}