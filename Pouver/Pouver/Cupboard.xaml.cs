using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pouver
{
    public partial class Cupboard : ContentPage
    {
        Label lbl;
        public Cupboard()
        {
            lbl = new Label();
            lbl.Text = "Do you go naked?";
            lbl.FontSize = 30;
            lbl.HorizontalOptions = LayoutOptions.Center;
            lbl.VerticalOptions = LayoutOptions.Center;
            Content = lbl;
        }
    }
}