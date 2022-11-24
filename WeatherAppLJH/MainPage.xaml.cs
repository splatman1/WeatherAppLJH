using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherAppLJH
{
    public partial class MainPage : ContentPage
    {

        //previous screen size
        /*private double width = 0;
        private double height = 0;*/

        public MainPage()
        {
            InitializeComponent();
            /*UpdateLayout();*/
        }


        /*protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //This must stay

            if(this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;

                //screen size has changed
                UpdateLayout();
            }

        }
        /// <summary>
        /// Decide on Portrait or Landscape layout
        /// </summary>
        private void UpdateLayout()
        {
            if(Content == null) return;
            string inputString = Content.FindByName<Entry>("input")?.Text ?? "";

            if (width > height)
            {
                //landscape
                Content = new MainLandscape(inputString); 
            }
            else
            {
                //portrait
                Content = new MainPortrait(inputString);
            }

        }*/

    }
}
