using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pouver
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var kitchen = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.PeachPuff,
                    Children =
                    {
                        new Label
                        {
                            Text = "Kitchen",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var bathroom = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Blue,
                    Children =
                    {
                        new Label
                        {
                            Text = "Bathroom",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var laboratory = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Pink,
                    Children =
                    {
                        new Label
                        {
                            Text = "Laboratory",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var playroom = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Green,
                    Children =
                    {
                        new Label
                        {
                            Text = "Playing room",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var bedroom = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Yellow,
                    Children =
                    {
                        new Label
                        {
                            Text = "Bedroom",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Green,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
        }
    }
}
