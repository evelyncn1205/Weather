using System;
using Weather.Models;
using Weather.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            
        }

        public ApiService ClimaTempo = new ApiService();

        private void OnClickPesquisar(object sender, EventArgs e)
        {
            PegarDadosClima(txtPesquisa.Text);
        }

        private async void PegarDadosClima(string cidade)
        {
            var dadosClima = await ClimaTempo.GetApiAsync<DadosClima>(cidade);

            txtCidade.Text = dadosClima.NomeCidade;
            txtTemp.Text = $"{dadosClima.Clima.Temperatura}° C";
            txtMin.Text = $"{dadosClima.Clima.TemperaturaMaxima}° C";
            txtMax.Text = $"{dadosClima.Clima.TemperaturaMinina}° C";
            txtHumidade.Text = $"{dadosClima.Clima.Humidade} %";
            //txtNascerDoSol.Text = DateTimeOffset.FromUnixTimeSeconds(dadosClima.Clima.SysInfo.NascerDoSol).LocalDateTime.ToString("HH:mm:ss");
            //txtPorDoSol.Text = DateTimeOffset.FromUnixTimeSeconds(dadosClima.Clima.SysInfo.PorDoSol).LocalDateTime.ToString("HH:mm:ss");
            //txtVento.Text = dadosClima.Clima.VentoInfo.Velocidade.ToString() + " mph";


        }

    }
}
