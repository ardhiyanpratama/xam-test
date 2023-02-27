using System;
using Movia.Services.IServices;
using Movia.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movia
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			DependencyService.Register<IMovieService, MovieService>();
			MainPage = new HomePage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
