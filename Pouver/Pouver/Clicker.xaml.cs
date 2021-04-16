using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pouver
{
    public partial class Clicker : ContentPage
    {
        private int money;
        Image cookie;
        Label lbl;
        public Clicker(int coins)
        {
            BackgroundColor = Color.Wheat;

            money = coins;
            cookie = new Image();
            cookie.Source = "cookie.png";
            cookie.WidthRequest = 300;
            cookie.HeightRequest = 300;
            cookie.HorizontalOptions = LayoutOptions.Center;
            cookie.VerticalOptions = LayoutOptions.Center;
            cookie.GestureRecognizers.Add(new TapGestureRecognizer(OnTap));

            lbl = new Label();
            lbl.Text = money.ToString();
            lbl.FontSize = 20;
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.End;
        }
        private void OnTap(View arg1, object arg2)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 2);
            money = money + value;
            lbl.Text = money.ToString();
        }
    }
}