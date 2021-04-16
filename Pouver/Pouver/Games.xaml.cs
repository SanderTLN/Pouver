using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pouver
{
    public partial class Games : ContentPage
    {
        Label lbl;
        Button Clicker;
        public Games()
        {
            BackgroundColor = Color.Wheat;

            lbl = new Label();
            lbl.Text = "Games";
            lbl.FontSize = 30;
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.Start;

            Clicker = new Button();
            Clicker.Text = "Clicker";
            Clicker.BackgroundColor = Color.LightBlue;
            Clicker.BorderWidth = 1;
            Clicker.BorderColor = Color.Gray;
            Clicker.HeightRequest = 70;
            Clicker.FontSize = 20;
            Clicker.VerticalOptions = LayoutOptions.Start;
            Clicker.Clicked += Clicker_Clicked;

            Content = new StackLayout { Children = { lbl, Clicker } };
        }

        private async void Clicker_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Clicker());
        }
    }
}