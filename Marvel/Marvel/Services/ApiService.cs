using Marvel.Models;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Services
{
    public class ApiService : IApiServices
    {
        public const string Url = "https://gateway.marvel.com:443/v1/public/series?ts=1&orderBy=modified&limit=50&apikey=a4503e73c6ea1d5648930e0a7767941b&hash=5b7d6d02eaece3fa9eb9f1f6435363cc";
        public async Task<Series> GetInformationAsync()
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<Series>(result);

        }

        public async Task<Series> CallApi()
        {
            var nsAPI = RestService.For<IApiServicesRefit>("https://gateway.marvel.com:443");
            var getSeries = await nsAPI.GetMarvelSeries();
            return  getSeries;
        }
    }
}
