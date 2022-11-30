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

            CurrentTemperatureAdvanced.Text = Perth.main.temp + "°C".ToString();
            CurrentWeatherAdvanced.Text = Perth.weather[0].description.ToString();
            CurrentLocationAdvanced.Text = Perth.name.ToString();
            CurrentDayAdvanced.Text = DateTime.Now.DayOfWeek.ToString();
            MaxMinTemperatureAdvanced.Text = Perth.main.temp_min.ToString() +" / "+ Perth.main.temp_max.ToString() + "°C";
            WeatherImageAdvanced.Source = "https://openweathermap.org/img/wn/" + Perth.weather[0].icon + "@2x.png";

            List <AdvancedWeatherInfo> advancedWeatherInfo = new List<AdvancedWeatherInfo>()
            {   
                new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.weather[0].description.ToString(),
                    WeatherSymbolImage = "https://openweathermap.org/img/wn/" + Perth.weather[0].icon +"@2x.png"

                },
                 new AdvancedWeatherInfo()
                {
                    WeatherInfo = TimeConfig.UnixTimeStampToDateTime(Perth.sys.sunset).ToString(),
                    WeatherSymbolImage = "https://openweathermap.org/img/wn/" + "01d@2x.png"

                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = TimeConfig.UnixTimeStampToDateTime(Perth.sys.sunrise).ToString(),
                    WeatherSymbolImage =  "https://openweathermap.org/img/wn/" + "01n@2x.png"

                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.wind.speed.ToString() + " meter/sec",
                    WeatherSymbolImage = "https://openweathermap.org/img/wn/" + "50d@2x.png"
                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = Perth.main.humidity.ToString() + "%",
                    WeatherSymbolImage = "https://openweathermap.org/img/wn/" + "03n@2x.png"
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