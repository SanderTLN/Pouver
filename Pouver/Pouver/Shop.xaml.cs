using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pouver
{
    public partial class Shop : ContentPage
    {
        Label lbl;
        public Shop()
        {
            lbl = new Label();
            lbl.Text = "The shop is closed!";
            lbl.FontSize = 30;
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.Center;
            Content = lbl;
        }
    }
}