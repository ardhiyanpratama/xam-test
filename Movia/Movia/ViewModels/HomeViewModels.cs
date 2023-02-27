using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Movia.Models;
using Movia.Services.IServices;
using Xamarin.Forms;

namespace Movia.ViewModels
{
	public partial class HomeViewModels : ObservableObject
	{
		public ObservableCollection<Movie> Movies;
		public ObservableCollection<Genre> Genre;

		//DI Injection
		IMovieService _movieService;

        public HomeViewModels()
		{
			_movieService = DependencyService.Get<IMovieService>();
		}

		[RelayCommand]
		private void getGenres()
		{
			var result = _movieService.GetGender();
		}

	}
}

