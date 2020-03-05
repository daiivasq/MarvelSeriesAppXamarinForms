using Marvel.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Services
{
     public interface IApiServicesRefit
    {
        [Get("/v1/public/series?ts=1&orderBy=modified&limit=50&apikey=a4503e73c6ea1d5648930e0a7767941b&hash=5b7d6d02eaece3fa9eb9f1f6435363cc")]
        Task<Series> GetMarvelSeries();
    }
}
