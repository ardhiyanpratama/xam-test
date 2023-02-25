using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Movia.Models;

namespace Movia.ViewModels
{
	public partial class HomeViewModels : ObservableObject
	{
		public ObservableCollection<Movie> Movies;

		public HomeViewModels()
		{

		}

		[RelayCommand]
		private void addMovies()
		{
			Movies.Add(new Movie
			{
				Id = "0",
				Description = "Refferal",
				RefferalDate = DateTime.UtcNow,
				ImgSource = "image"
			});
			Movies.Add(new Movie
			{
				Id = "1",
				Description = "Refferal",
				RefferalDate = DateTime.UtcNow,
				ImgSource = "image"
			});
			Movies.Add(new Movie
			{
				Id = "2",
				Description = "Refferal",
				RefferalDate = DateTime.UtcNow,
				ImgSource = "image"
			});
		}

	}
}

