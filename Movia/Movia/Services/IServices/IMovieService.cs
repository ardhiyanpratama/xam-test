using Movia.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movia.Services.IServices
{
    public interface IMovieService
    {
        Task<Genre> GetGender();
    }
}
