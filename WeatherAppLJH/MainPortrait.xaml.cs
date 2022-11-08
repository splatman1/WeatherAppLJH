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
    public partial class MainPortrait : ContentView
    {
        public MainPortrait(string importantData)
        {
            InitializeComponent();
            List<WeeklyForecastDayModel> weeklyForecastDayModels = new List<WeeklyForecastDayModel>()
            {
                new WeeklyForecastDayModel()
                {
                    Title = "Monday",
                    Image = "sunny_482px.xml"

                },
                 new WeeklyForecastDayModel()
                {
                    Title = "Tuesday",
                    Image = "sunny_482px.xml"

                },
                  new WeeklyForecastDayModel()
                {
                    Title = "Wednesday",
                    Image = "sunny_482px.xml"

                },
                   new WeeklyForecastDayModel()
                {
                    Title = "Thursday",
                    Image = "sunny_482px.xml"

                },
                    new WeeklyForecastDayModel()
                {
                    Title = "Friday",
                    Image = "sunny_482px.xml"

                },
                     new WeeklyForecastDayModel()
                {
                    Title = "Saturday",
                    Image = "sunny_482px.xml"

                },
                      new WeeklyForecastDayModel()
                {
                    Title = "Sunday",
                    Image = "sunny_482px.xml"

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
    }
}