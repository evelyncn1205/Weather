using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Service
{
    public interface IApiService
    {
        Task<DadosClima> GetApiAsync<T>(string cidade);
    }
}
