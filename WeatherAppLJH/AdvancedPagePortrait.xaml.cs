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
        public AdvancedPagePortrait()
        {
            InitializeComponent();
            List<AdvancedWeatherInfo> advancedWeatherInfo = new List<AdvancedWeatherInfo>()
            {
                new AdvancedWeatherInfo()
                {
                    WeatherInfo = "Very Windy",
                    WeatherSymbolImage = "air_fill0_wght400_grad0_opsz48.xml"

                },
                 new AdvancedWeatherInfo()
                {
                    WeatherInfo = "6:04PM",
                    WeatherSymbolImage = "clear_night_fill0_wght400_grad0_opsz48.xml"

                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = "6:26AM",
                    WeatherSymbolImage = "sunny_482px.xml"

                },new AdvancedWeatherInfo()
                {
                    WeatherInfo = "11mm",
                    WeatherSymbolImage = "cloudy_snowing_fill0_wght400_grad0_opsz48.xml"

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