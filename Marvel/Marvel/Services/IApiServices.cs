using Marvel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Services
{
    public interface IApiServices
    {
        Task<Series> GetInformationAsync();
    }
}
