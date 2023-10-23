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
            var dadosClima = await ClimaTempo.GetApiAsync(cidade);

            txtCidade.Text = dadosClima.NomeCidade;
            txtTemp.Text = $"{dadosClima.Clima.Temperatura}° C";
            txtMin.Text = $"{dadosClima.Clima.TemperaturaMaxima}° C";
            txtMax.Text = $"{dadosClima.Clima.TemperaturaMinina}° C";
            txtHumidade.Text = $"{dadosClima.Clima.Humidade} %";
            //txtNascerDoSol.Text= dadosClima.Clima.SysInfo.NascerDoSol.ToString();
            //txtPorDoSol.Text= dadosClima.Clima.SysInfo.PorDoSol.ToString();
            //txtVento.Text= dadosClima.Clima.VentoInfo.Velocidade.ToString();
            

        }

    }
}
