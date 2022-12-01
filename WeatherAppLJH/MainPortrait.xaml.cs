using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace WeatherAppLJH
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPortrait : ContentPage
    {
        SearchPagePortrait SearchPage = new SearchPagePortrait();
        AdvancedPagePortrait AdvancedPage = new AdvancedPagePortrait();
        SettingsPagePortrait SettingsPage = new SettingsPagePortrait();
        WeatherAppAPI api = new WeatherAppAPI();

        public MainPortrait()
        {
            InitializeComponent();
            GetWeeklyWeather();
            GetCurrentWeather();
        }

        public async void GetCurrentWeather()
        {
            WeatherInfo weather = await api.GetWeatherInformation("Perth");
            Temperature.Text = weather.main.temp + Preferences.Get("TempDegrees", "").ToString();
            Forecast.Text = weather.weather[0].description.ToString();
            Day.Text = DateTime.Now.DayOfWeek.ToString();
            FeelsLikeTemperature.Text = weather.main.feels_like.ToString() + Preferences.Get("TempDegrees", "");
            MinimumTemperature.Text = weather.main.temp_min.ToString();
            MaximumTemperature.Text = weather.main.temp_max + Preferences.Get("TempDegrees", "").ToString(); ;
            WeatherTypeImage.Source = "https://openweathermap.org/img/wn/" + weather.weather[0].icon + "@2x.png";        

        }
        public async void GetWeeklyWeather()
        {
  
            WeatherInfo weather = await api.GetWeatherInformation("Perth");
            List<WeeklyForecastDayModel> weeklyForecastDayModels = new List<WeeklyForecastDayModel>()
            {
                new WeeklyForecastDayModel()
                {

                    Title = "Monday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                },
                 new WeeklyForecastDayModel()
                {
                    Title = "Tuesday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                },
                  new WeeklyForecastDayModel()
                {
                    Title = "Wednesday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                },
                   new WeeklyForecastDayModel()
                {
                    Title = "Thursday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                },
                    new WeeklyForecastDayModel()
                {
                    Title = "Friday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                },
                     new WeeklyForecastDayModel()
                {
                    Title = "Saturday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                },
                      new WeeklyForecastDayModel()
                {
                    Title = "Sunday",
                    Image = "https://openweathermap.org/img/wn/" + weather.weather[0].icon +"@2x.png"

                }

            };
            WeeklyListView.ItemsSource = weeklyForecastDayModels;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            Settings_Clicked(sender, e);
        }
        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            SearchButton_Clicked(sender, e);
        }

        private async void SearchButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(SearchPage);
        }

        private async void AdvancedButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(AdvancedPage);            
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(SettingsPage);
        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            GetCurrentWeather();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetWeeklyWeather();
            GetCurrentWeather();
        }
    }
}