using Movia.Models;
using Movia.Services.IServices;
using Movia.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly:Dependency(typeof(MovieService))]
namespace Movia.Services.IServices
{
    public class MovieService : IMovieService
    {
        static HttpClient _client;
        public MovieService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(StaticResources.url)
            };
        }

        public async Task<Genre> GetGender()
        {
            try
            {
                var json = await _client.GetStringAsync("genre/movie/list?api_key=1a2ee8c53c2cd3e700ae25f6f47b0b4b");
                var genre = JsonConvert.DeserializeObject<Genre>(json);

                return genre;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
