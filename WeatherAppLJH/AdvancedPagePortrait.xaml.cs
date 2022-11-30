using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherAppLJH
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedPagePortrait : ContentPage
    {
        WeatherAppAPI api = new WeatherAppAPI();
        public AdvancedPagePortrait()
        {
            InitializeComponent();
            SetupAdvancedPage();
        }

        private async void SetupAdvancedPage()
        {
            WeatherInfo Perth = await api.GetWeatherInformation("Perth");

            List<AdvancedWeatherInfo> advancedWeatherInfo = new List<AdvancedWeatherInfo>()
            {   
                new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.weather[0].description.ToString(),
                    WeatherSymbolImage = "https://openweathermap.org/img/w/" + Perth.weather[0].icon +".png"

                },
                 new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.sys.sunset.ToString(),
                    WeatherSymbolImage = "clear_night_fill0_wght400_grad0_opsz48.xml"

                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.sys.sunrise.ToString(),
                    WeatherSymbolImage = "sunny_482px.xml"

                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.wind.speed.ToString() + " meter/sec",
                    WeatherSymbolImage = "air_fill0_wght400_grad0_opsz48.xml"

                }
            };
            AdvancedWeatherListView.ItemsSource = advancedWeatherInfo;
        }
        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}