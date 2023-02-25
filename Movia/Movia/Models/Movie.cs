using System;
namespace Movia.Models
{
	public class Movie
	{
		public Movie()
		{
		}

		public string Id { get; set; }
		public string Description { get; set; }
		public DateTime RefferalDate { get; set; }
		public string ImgSource { get; set; }
	}
}

