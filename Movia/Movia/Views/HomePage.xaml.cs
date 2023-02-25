using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Movia.Models;
using Xamarin.Forms;

namespace Movia.Views
{
	public partial class HomePage : ContentPage
	{
		public ObservableCollection<Movie> Movies { get; } = new ObservableCollection<Movie>();

		public HomePage()
		{
			InitializeComponent();
		}

	}
}

