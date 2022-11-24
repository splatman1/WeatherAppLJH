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
    public partial class MainPortrait : ContentPage
    {
        SearchPagePortrait SearchPage = new SearchPagePortrait();
        AdvancedPagePortrait AdvancedPage = new AdvancedPagePortrait();
        SettingsPagePortrait SettingsPage = new SettingsPagePortrait();
        public MainPortrait()
        {
            InitializeComponent();
            List<WeeklyForecastDayModel> weeklyForecastDayModels = new List<WeeklyForecastDayModel>()
            {
                new WeeklyForecastDayModel()
                {
                    Title = "Monday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                },
                 new WeeklyForecastDayModel()
                {
                    Title = "Tuesday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                },
                  new WeeklyForecastDayModel()
                {
                    Title = "Wednesday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                },
                   new WeeklyForecastDayModel()
                {
                    Title = "Thursday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                },
                    new WeeklyForecastDayModel()
                {
                    Title = "Friday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                },
                     new WeeklyForecastDayModel()
                {
                    Title = "Saturday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                },
                      new WeeklyForecastDayModel()
                {
                    Title = "Sunday",
                    Image = "cyclone_fill0_wght400_grad0_opsz48.xml"

                }
            };
            WeeklyListView.ItemsSource = weeklyForecastDayModels;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

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
    }
}