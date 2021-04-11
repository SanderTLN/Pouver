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
        public Games()
        {
            lbl = new Label();
            lbl.Text = "Games, seriously? go for a walk";
            lbl.FontSize = 30;
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.Center;
            Content = lbl;
        }
    }
}