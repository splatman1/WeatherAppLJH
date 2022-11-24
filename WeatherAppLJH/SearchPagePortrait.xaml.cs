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
        public SearchPagePortrait()
        {
            InitializeComponent();
            List<DefaultLocationsSearch> defaultDaysSearch = new List<DefaultLocationsSearch>()
            {
                new DefaultLocationsSearch()
                {
                    Location = "London, England",
                    LocationWeather = "clear_day_fill0_wght400_grad0_opsz48.xml"

                },
                 new DefaultLocationsSearch()
                {
                    Location = "Belfast, Northern Ireland",
                    LocationWeather = "clear_day_fill0_wght400_grad0_opsz48.xml"

                },new DefaultLocationsSearch()
                {
                    Location = "Perth, Western Australia",
                    LocationWeather = "clear_day_fill0_wght400_grad0_opsz48.xml"

                },new DefaultLocationsSearch()
                {
                    Location = "Sapporo, Japan",
                    LocationWeather = "clear_day_fill0_wght400_grad0_opsz48.xml"

                },new DefaultLocationsSearch()
                {
                    Location = "Melbourne, Victoria",
                    LocationWeather = "clear_day_fill0_wght400_grad0_opsz48.xml"

                }
            };
            DefaultPlaceNames.ItemsSource = defaultDaysSearch;
        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}