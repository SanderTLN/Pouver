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
        Picker menu;
        Button btnC, btnS, btnF;
        public MainPage()
        {
            menu = new Picker();
            menu.BackgroundColor = Color.Gray;
            menu.TextColor = Color.Gray;
            menu.WidthRequest = 40;
            menu.HeightRequest = 40;
            menu.Margin = 5;
            menu.HorizontalOptions = LayoutOptions.End;
            menu.Items.Add("Kitchen");
            menu.Items.Add("Bathroom");
            menu.Items.Add("Laboratory");
            menu.Items.Add("Playing room");
            menu.Items.Add("Bedroom");
            menu.SelectedIndexChanged += Menu_SelectedIndexChanged;

            btnC = new Button();
            btnC.BackgroundColor = Color.Gold;
            btnC.BorderWidth = 2;
            btnC.BorderColor = Color.LightGoldenrodYellow;
            btnC.WidthRequest = 40;
            btnC.HeightRequest = 40;
            btnC.Margin = 5;
            btnC.CornerRadius = 30;
            btnC.HorizontalOptions = LayoutOptions.Start;

            btnS = new Button();
            btnS.BackgroundColor = Color.Blue;
            btnS.BorderWidth = 2;
            btnS.BorderColor = Color.LightBlue;
            btnS.WidthRequest = 50;
            btnS.HeightRequest = 60;
            btnS.Margin = 5;
            btnS.CornerRadius = 10;
            btnS.HorizontalOptions = LayoutOptions.Start;
            btnS.VerticalOptions = LayoutOptions.EndAndExpand;

            btnF = new Button();
            btnF.BackgroundColor = Color.White;
            btnF.BorderWidth = 2;
            btnF.BorderColor = Color.LightGray;
            btnF.WidthRequest = 50;
            btnF.HeightRequest = 60;
            btnF.Margin = 5;
            btnF.CornerRadius = 10;
            btnF.HorizontalOptions = LayoutOptions.End;
            btnF.VerticalOptions = LayoutOptions.EndAndExpand;

            var kitchen = new ContentPage
            {
                Content = new StackLayout
                {
                    Spacing = 215,
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 270,
                                Children =
                                {
                                    btnC,
                                    menu,
                                }
                            }
                        },
                        
                        new Label
                        {
                            Text = "Kitchen",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center,
                        },

                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 250,
                                Children =
                                {
                                    btnS,
                                    btnF,
                                }
                            }
                        },
                    }
                }
            };
            var bathroom = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.LightBlue,
                    Children =
                    {
                        new Label
                        {
                            Text = "Bathroom",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var laboratory = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.PeachPuff,
                    Children =
                    {
                        new Label
                        {
                            Text = "Laboratory",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var playroom = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.LightGreen,
                    Children =
                    {
                        new Label
                        {
                            Text = "Playing room",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            var bedroom = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Goldenrod,
                    Children =
                    {
                        new Label
                        {
                            Text = "Bedroom",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                    }
                }
            };
            Children.Add(kitchen);
            Children.Add(bathroom);
            Children.Add(laboratory);
            Children.Add(playroom);
            Children.Add(bedroom);
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(menu.SelectedIndex == 0)
            {
                
            }
        }
    }
}
