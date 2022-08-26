using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using HeroList.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace HeroList.Droid.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : MvxActivity<MainViewModel>
    {
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);
		}
	}
}