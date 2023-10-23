using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using Weather.Service;
using Weather.ViewModels;
using Weather.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using WeatherMasterDetailPage = Weather.Views.WeatherMasterDetailPage;

namespace Weather
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("Mjc1ODUzNkAzMjMzMmUzMDJlMzBMeEJ1Vk5qNHBkeUNsdk1NVk1PdkxqaE1wRzUwb1cvWWN1V3NXM0hpVEQwPQ==");
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
            await NavigationService.NavigateAsync
               ($"/{nameof(WeatherMasterDetailPage)}/NavigationPage/{nameof(WeatherPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register< ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();

            containerRegistry.RegisterForNavigation<WeatherPage, WeatherPageViewModel>();
            containerRegistry.RegisterForNavigation<WeatherMasterDetailPage, WeatherMasterDetailPageViewModel>();
        }
    }
}
