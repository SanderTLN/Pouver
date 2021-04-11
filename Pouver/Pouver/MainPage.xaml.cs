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
        Picker menu, menu2, menu3, menu4, menu5;
        Button btnC, btnS, btnF, btnC2, btnS2, btnC3, btnS3, btnC4, btnS4, btnC5, btnS5, btnW, btnCB, btnG, btnL;
        Image Pouver, Pouver2, Pouver3, Pouver4, Pouver5;
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

            menu2 = new Picker();
            menu2.BackgroundColor = Color.Gray;
            menu2.TextColor = Color.Gray;
            menu2.WidthRequest = 40;
            menu2.HeightRequest = 40;
            menu2.Margin = 5;
            menu2.HorizontalOptions = LayoutOptions.End;
            menu2.Items.Add("Kitchen");
            menu2.Items.Add("Bathroom");
            menu2.Items.Add("Laboratory");
            menu2.Items.Add("Playing room");
            menu2.Items.Add("Bedroom");
            menu2.SelectedIndexChanged += Menu_SelectedIndexChanged;

            menu3 = new Picker();
            menu3.BackgroundColor = Color.Gray;
            menu3.TextColor = Color.Gray;
            menu3.WidthRequest = 40;
            menu3.HeightRequest = 40;
            menu3.Margin = 5;
            menu3.HorizontalOptions = LayoutOptions.End;
            menu3.Items.Add("Kitchen");
            menu3.Items.Add("Bathroom");
            menu3.Items.Add("Laboratory");
            menu3.Items.Add("Playing room");
            menu3.Items.Add("Bedroom");
            menu3.SelectedIndexChanged += Menu_SelectedIndexChanged;

            menu4 = new Picker();
            menu4.BackgroundColor = Color.Gray;
            menu4.TextColor = Color.Gray;
            menu4.WidthRequest = 40;
            menu4.HeightRequest = 40;
            menu4.Margin = 5;
            menu4.HorizontalOptions = LayoutOptions.End;
            menu4.Items.Add("Kitchen");
            menu4.Items.Add("Bathroom");
            menu4.Items.Add("Laboratory");
            menu4.Items.Add("Playing room");
            menu4.Items.Add("Bedroom");
            menu4.SelectedIndexChanged += Menu_SelectedIndexChanged;

            menu5 = new Picker();
            menu5.BackgroundColor = Color.Gray;
            menu5.TextColor = Color.Gray;
            menu5.WidthRequest = 40;
            menu5.HeightRequest = 40;
            menu5.Margin = 5;
            menu5.HorizontalOptions = LayoutOptions.End;
            menu5.Items.Add("Kitchen");
            menu5.Items.Add("Bathroom");
            menu5.Items.Add("Laboratory");
            menu5.Items.Add("Playing room");
            menu5.Items.Add("Bedroom");
            menu5.SelectedIndexChanged += Menu_SelectedIndexChanged;

            btnC = new Button();
            btnC.Text = "2K";
            btnC.FontSize = 10;
            btnC.TextColor = Color.LightYellow;
            btnC.BackgroundColor = Color.Gold;
            btnC.BorderWidth = 2;
            btnC.BorderColor = Color.LightGoldenrodYellow;
            btnC.WidthRequest = 45;
            btnC.HeightRequest = 45;
            btnC.Margin = 5;
            btnC.CornerRadius = 30;
            btnC.HorizontalOptions = LayoutOptions.Start;
            btnC.Clicked += BtnC_Clicked;

            btnC2 = new Button();
            btnC2.Text = "2K";
            btnC2.FontSize = 10;
            btnC2.TextColor = Color.LightYellow;
            btnC2.BackgroundColor = Color.Gold;
            btnC2.BorderWidth = 2;
            btnC2.BorderColor = Color.LightGoldenrodYellow;
            btnC2.WidthRequest = 45;
            btnC2.HeightRequest = 45;
            btnC2.Margin = 5;
            btnC2.CornerRadius = 30;
            btnC2.HorizontalOptions = LayoutOptions.Start;
            btnC2.Clicked += BtnC_Clicked;

            btnC3 = new Button();
            btnC3.Text = "2K";
            btnC3.FontSize = 10;
            btnC3.TextColor = Color.LightYellow;
            btnC3.BackgroundColor = Color.Gold;
            btnC3.BorderWidth = 2;
            btnC3.BorderColor = Color.LightGoldenrodYellow;
            btnC3.WidthRequest = 45;
            btnC3.HeightRequest = 45;
            btnC3.Margin = 5;
            btnC3.CornerRadius = 30;
            btnC3.HorizontalOptions = LayoutOptions.Start;
            btnC3.Clicked += BtnC_Clicked;

            btnC4 = new Button();
            btnC4.Text = "2K";
            btnC4.FontSize = 10;
            btnC4.TextColor = Color.LightYellow;
            btnC4.BackgroundColor = Color.Gold;
            btnC4.BorderWidth = 2;
            btnC4.BorderColor = Color.LightGoldenrodYellow;
            btnC4.WidthRequest = 45;
            btnC4.HeightRequest = 45;
            btnC4.Margin = 5;
            btnC4.CornerRadius = 30;
            btnC4.HorizontalOptions = LayoutOptions.Start;
            btnC4.Clicked += BtnC_Clicked;

            btnC5 = new Button();
            btnC5.Text = "2K";
            btnC5.FontSize = 10;
            btnC5.TextColor = Color.LightYellow;
            btnC5.BackgroundColor = Color.Gold;
            btnC5.BorderWidth = 2;
            btnC5.BorderColor = Color.LightGoldenrodYellow;
            btnC5.WidthRequest = 45;
            btnC5.HeightRequest = 45;
            btnC5.Margin = 5;
            btnC5.CornerRadius = 30;
            btnC5.HorizontalOptions = LayoutOptions.Start;
            btnC5.Clicked += BtnC_Clicked;

            btnS = new Button();
            btnS.Text = "Shop";
            btnS.FontSize = 10;
            btnS.TextColor = Color.Gray;
            btnS.BackgroundColor = Color.Blue;
            btnS.BorderWidth = 2;
            btnS.BorderColor = Color.LightBlue;
            btnS.WidthRequest = 55;
            btnS.HeightRequest = 60;
            btnS.Margin = 5;
            btnS.CornerRadius = 10;
            btnS.VerticalOptions = LayoutOptions.End;
            btnS.Clicked += BtnS_Clicked;

            btnS2 = new Button();
            btnS2.Text = "Shop";
            btnS2.FontSize = 10;
            btnS2.TextColor = Color.Gray;
            btnS2.BackgroundColor = Color.Blue;
            btnS2.BorderWidth = 2;
            btnS2.BorderColor = Color.LightBlue;
            btnS2.WidthRequest = 55;
            btnS2.HeightRequest = 60;
            btnS2.Margin = 5;
            btnS2.CornerRadius = 10;
            btnS2.VerticalOptions = LayoutOptions.End;
            btnS2.Clicked += BtnS_Clicked;

            btnS3 = new Button();
            btnS3.Text = "Shop";
            btnS3.FontSize = 10;
            btnS3.TextColor = Color.Gray;
            btnS3.BackgroundColor = Color.Blue;
            btnS3.BorderWidth = 2;
            btnS3.BorderColor = Color.LightBlue;
            btnS3.WidthRequest = 55;
            btnS3.HeightRequest = 60;
            btnS3.Margin = 5;
            btnS3.CornerRadius = 10;
            btnS3.VerticalOptions = LayoutOptions.End;
            btnS3.Clicked += BtnS_Clicked;

            btnS4 = new Button();
            btnS4.Text = "Shop";
            btnS4.FontSize = 10;
            btnS4.TextColor = Color.Gray;
            btnS4.BackgroundColor = Color.Blue;
            btnS4.BorderWidth = 2;
            btnS4.BorderColor = Color.LightBlue;
            btnS4.WidthRequest = 55;
            btnS4.HeightRequest = 60;
            btnS4.Margin = 5;
            btnS4.CornerRadius = 10;
            btnS4.VerticalOptions = LayoutOptions.End;
            btnS4.Clicked += BtnS_Clicked;

            btnS5 = new Button();
            btnS5.Text = "Shop";
            btnS5.FontSize = 10;
            btnS5.TextColor = Color.Gray;
            btnS5.BackgroundColor = Color.Blue;
            btnS5.BorderWidth = 2;
            btnS5.BorderColor = Color.LightBlue;
            btnS5.WidthRequest = 55;
            btnS5.HeightRequest = 60;
            btnS5.Margin = 5;
            btnS5.CornerRadius = 10;
            btnS5.VerticalOptions = LayoutOptions.End;
            btnS5.Clicked += BtnS_Clicked;

            btnF = new Button();
            btnF.Text = "Fridge";
            btnF.FontSize = 10;
            btnF.TextColor = Color.Gray;
            btnF.BackgroundColor = Color.White;
            btnF.BorderWidth = 2;
            btnF.BorderColor = Color.Gray;
            btnF.WidthRequest = 60;
            btnF.HeightRequest = 70;
            btnF.Margin = 5;
            btnF.CornerRadius = 10;
            btnF.VerticalOptions = LayoutOptions.End;
            btnF.Clicked += BtnF_Clicked;

            btnW = new Button();
            btnW.Text = "Wash";
            btnW.FontSize = 10;
            btnW.TextColor = Color.Gray;
            btnW.BackgroundColor = Color.LightCyan;
            btnW.BorderWidth = 2;
            btnW.BorderColor = Color.LightSkyBlue;
            btnW.WidthRequest = 55;
            btnW.HeightRequest = 70;
            btnW.Margin = 5;
            btnW.CornerRadius = 10;
            btnW.VerticalOptions = LayoutOptions.End;
            btnW.Clicked += BtnW_Clicked;

            btnCB = new Button();
            btnCB.Text = "Cupboard";
            btnCB.FontSize = 10;
            btnCB.TextColor = Color.Gray;
            btnCB.BackgroundColor = Color.Brown;
            btnCB.BorderWidth = 2;
            btnCB.BorderColor = Color.SandyBrown;
            btnCB.WidthRequest = 80;
            btnCB.HeightRequest = 70;
            btnCB.Margin = 5;
            btnCB.CornerRadius = 10;
            btnCB.VerticalOptions = LayoutOptions.End;
            btnCB.Clicked += BtnCB_Clicked;

            btnG = new Button();
            btnG.Text = "Games";
            btnG.FontSize = 10;
            btnG.TextColor = Color.Gray;
            btnG.BackgroundColor = Color.Orange;
            btnG.BorderWidth = 2;
            btnG.BorderColor = Color.YellowGreen;
            btnG.WidthRequest = 80;
            btnG.HeightRequest = 70;
            btnG.Margin = 5;
            btnG.CornerRadius = 10;
            btnG.VerticalOptions = LayoutOptions.End;
            btnG.Clicked += BtnG_Clicked;

            btnL = new Button();
            btnL.Text = "Lamp";
            btnL.FontSize = 10;
            btnL.TextColor = Color.Gray;
            btnL.BackgroundColor = Color.Yellow;
            btnL.BorderWidth = 2;
            btnL.BorderColor = Color.LightYellow;
            btnL.WidthRequest = 60;
            btnL.HeightRequest = 70;
            btnL.Margin = 5;
            btnL.CornerRadius = 10;
            btnL.VerticalOptions = LayoutOptions.End;
            btnL.Clicked += BtnL_Clicked;

            Pouver = new Image();
            Pouver.Source = "Pouver.png";
            Pouver.WidthRequest = 200;
            Pouver.HeightRequest = 200;
            Pouver.GestureRecognizers.Add(new TapGestureRecognizer(OnTap));

            Pouver2 = new Image();
            Pouver2.Source = "Pouver.png";
            Pouver2.WidthRequest = 200;
            Pouver2.HeightRequest = 200;
            Pouver2.GestureRecognizers.Add(new TapGestureRecognizer(OnTap));

            Pouver3 = new Image();
            Pouver3.Source = "Pouver.png";
            Pouver3.WidthRequest = 200;
            Pouver3.HeightRequest = 200;
            Pouver3.GestureRecognizers.Add(new TapGestureRecognizer(OnTap));
            
            Pouver4 = new Image();
            Pouver4.Source = "Pouver.png";
            Pouver4.WidthRequest = 200;
            Pouver4.HeightRequest = 200;
            Pouver4.GestureRecognizers.Add(new TapGestureRecognizer(OnTap));

            Pouver5 = new Image();
            Pouver5.Source = "Pouver.png";
            Pouver5.WidthRequest = 200;
            Pouver5.HeightRequest = 200;
            Pouver5.GestureRecognizers.Add(new TapGestureRecognizer(OnTap));

            var kitchen = new ContentPage
            {
                Content = new StackLayout
                {
                    Spacing = 90,
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
                                Spacing = 265,
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

                        Pouver,

                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 240,
                                Children =
                                {
                                    btnF,
                                    btnS,
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
                    Spacing = 90,
                    BackgroundColor = Color.LightBlue,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 265,
                                Children =
                                {
                                    btnC2,
                                    menu2,
                                }
                            }
                        },

                        new Label
                        {
                            Text = "Bathroom",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },

                        Pouver2,

                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 245,
                                Children =
                                {
                                    btnW,
                                    btnS2,
                                }
                            }
                        },
                    }
                }
            };
            var laboratory = new ContentPage
            {
                Content = new StackLayout
                {
                    Spacing = 90,
                    BackgroundColor = Color.PeachPuff,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 265,
                                Children =
                                {
                                    btnC3,
                                    menu3,
                                }
                            }
                        },

                        new Label
                        {
                            Text = "Laboratory",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },

                        Pouver3,

                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 215,
                                Children =
                                {
                                    btnCB,
                                    btnS3,
                                }
                            }
                        },
                    }
                }
            };
            var playroom = new ContentPage
            {
                Content = new StackLayout
                {
                    Spacing = 90,
                    BackgroundColor = Color.LightGreen,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 265,
                                Children =
                                {
                                    btnC4,
                                    menu4,
                                }
                            }
                        },

                        new Label
                        {
                            Text = "Playing room",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },

                        Pouver4,

                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 220,
                                Children =
                                {
                                    btnG,
                                    btnS4,
                                }
                            }
                        },
                    }
                }
            };
            var bedroom = new ContentPage
            {
                Content = new StackLayout
                {
                    Spacing = 90,
                    BackgroundColor = Color.Goldenrod,
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 265,
                                Children =
                                {
                                    btnC5,
                                    menu5,
                                }
                            }
                        },

                        new Label
                        {
                            Text = "Bedroom",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },

                        Pouver5,

                        new Frame
                        {
                            BackgroundColor = Color.LightGray,
                            Content = new StackLayout
                            {
                                BackgroundColor = Color.LightGray,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 240,
                                Children =
                                {
                                    btnL,
                                    btnS5,
                                }
                            }
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

        private void BtnL_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Light", "This is a magic lamp and you can't turn off it", "Umm.. Ok?");
        }

        private async void BtnG_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Games());
        }

        private async void BtnCB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cupboard());
        }

        private void BtnW_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Washing", "Can't you see I'm naked?", "Oops..");
        }

        private async void BtnF_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Fridge());
        }

        private async void BtnS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Shop());
        }

        private void OnTap(View arg1, object arg2)
        {
            DisplayAlert("Description", "This is a main character Pouver", "Understood");
        }

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Coins", "You have: 2311 coins", "Great");
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(menu.SelectedIndex == 0)
            {
                
            }
        }
    }
}