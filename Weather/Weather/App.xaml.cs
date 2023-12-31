using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Syncfusion.Licensing;
using Weather.Service;
using Weather.ViewModels;
using Weather.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

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

            
            await NavigationService.NavigateAsync
              ($"/{nameof(WeatherMasterDetailPage)}/NavigationPage/{nameof(LoginPage)}");
            
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<WeatherPage, WeatherPageViewModel>();            
            containerRegistry.RegisterForNavigation<SobrePage, SobrePageViewModel>();
            containerRegistry.RegisterForNavigation<WeatherMasterDetailPage, WeatherMasterDetailPageViewModel>();
        }
    }
}
