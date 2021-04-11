using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pouver
{
    public partial class Autorize : ContentPage
    {
        Button btnSI, btnSU;
        public Autorize()
        {
            btnSI = new Button();
            btnSI.Text = "Sign in";
            btnSI.HeightRequest = 80;
            btnSI.Margin = 5;
            btnSI.VerticalOptions = LayoutOptions.EndAndExpand;
            btnSI.Clicked += BtnSI_Clicked;
            Content = btnSI;

            btnSU = new Button();
            btnSU.Text = "Sign up";
            btnSU.HeightRequest = 80;
            btnSU.Margin = 5;
            btnSU.VerticalOptions = LayoutOptions.End;
            btnSU.Clicked += BtnSU_Clicked;
            Content = new StackLayout { Children = { btnSI, btnSU } };
        }

        private void BtnSU_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Error", "This button is not working, use another one", "Ok");
        }

        private async void BtnSI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}