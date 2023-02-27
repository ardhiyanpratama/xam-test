using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Movia.Models;
using Movia.Services.IServices;
using Xamarin.Forms;

namespace Movia.Views
{
	public partial class HomePage : ContentPage
	{
		public ObservableCollection<Movie> Movies { get; } = new ObservableCollection<Movie>();
        IMovieService _movieService;

        public HomePage()
		{
			InitializeComponent();
            _movieService = DependencyService.Get<IMovieService>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = _movieService.GetGender();
        }

    }
}

