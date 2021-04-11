using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pouver
{
    public partial class Fridge : ContentPage
    {
        Label lbl;
        public Fridge()
        {
            lbl = new Label();
            lbl.Text = "Why you didn't buy a food?";
            lbl.FontSize = 30;
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.Center;
            Content = lbl;
        }
    }
}