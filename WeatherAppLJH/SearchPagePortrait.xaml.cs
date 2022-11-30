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
    public partial class SearchPagePortrait : ContentPage

    {
        WeatherAppAPI api = new WeatherAppAPI();
        public SearchPagePortrait()
        {
            InitializeComponent();
            SetupSearchPage();
        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
            
        }

        private async void SetupSearchPage()
        {
            WeatherInfo london = await api.GetWeatherInformation("London");
            WeatherInfo Belfast = await api.GetWeatherInformation("Belfast");
            WeatherInfo Perth = await api.GetWeatherInformation("Perth");
            WeatherInfo Sapporo = await api.GetWeatherInformation("Sapporo");
            WeatherInfo Melbourne = await api.GetWeatherInformation("Melbourne");

            List<DefaultLocationsSearch> defaultDaysSearch = new List<DefaultLocationsSearch>()
            {
                new DefaultLocationsSearch()
                {
                    Location = "London, England",
                    LocationWeather = "https://openweathermap.org/img/w/" + london.weather[0].icon + ".png"

                },
                 new DefaultLocationsSearch()
                {
                    Location = "Belfast, Northern Ireland",
                    LocationWeather = "https://openweathermap.org/img/w/" + Belfast.weather[0].icon + ".png"

                },new DefaultLocationsSearch()
                {
                    Location = "Perth, Western Australia",
                    LocationWeather = "https://openweathermap.org/img/w/" + Perth.weather[0].icon + ".png"

                },new DefaultLocationsSearch()
                {
                    Location = "Sapporo, Japan",
                    LocationWeather = "https://openweathermap.org/img/w/" + Sapporo.weather[0].icon + ".png"

                },new DefaultLocationsSearch()
                {
                    Location = "Melbourne, Victoria",
                    LocationWeather = "https://openweathermap.org/img/w/" + Melbourne.weather[0].icon + ".png"

                }
            };
            DefaultPlaceNames.ItemsSource = defaultDaysSearch;
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            string locationEntered = SearchLocation.Text;            
            WeatherInfo SearchedLocation = await api.GetWeatherInformation(locationEntered);
            LocationEntered.Text = locationEntered;
            if (SearchedLocation != null)
                {
                    CitySearchedImage.Source = "https://openweathermap.org/img/w/" + SearchedLocation.weather[0].icon + ".png";
                    CitySearchedTemperature.Text = (SearchedLocation.main.temp + "°C").ToString();
                }
            if (SearchedLocation == null)
            {
                LocationEntered.Text = "Enter a valid location";
            }
            
            }




        }
    }
