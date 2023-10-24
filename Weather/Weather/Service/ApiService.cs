using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using System.Runtime.CompilerServices;

namespace Weather.Service
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _HttpClient;
        public ApiService()
        {
            _HttpClient = new HttpClient();
        }
        public async Task<DadosClima> GetApiAsync<T>(string cidade)
        {

            try
            {
                string url = $"{Acessos.ApiBaseUrl}{cidade}{Acessos.CodigoPais}&appid={Acessos.AppId}&units=metric";
                HttpResponseMessage response = await _HttpClient.GetAsync($"{Acessos.ApiBaseUrl}{cidade}{Acessos.CodigoPais}&appid={Acessos.AppId}&units=metric");

                if (!response.IsSuccessStatusCode)
                    await App.Current.MainPage.DisplayAlert("Error", "Alguma coisa de errado não deu certo!!!", "Ok");

                var conteudoResponse = await response.Content.ReadAsStringAsync();

                var responseClima = JsonConvert.DeserializeObject<DadosClima>(conteudoResponse);

                return responseClima;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

       
    }
}
