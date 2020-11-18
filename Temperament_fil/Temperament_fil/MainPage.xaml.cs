using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Temperament_fil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var UglyPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Label
                        {
                            Text = "Mosquit - Ugly",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "ugly.jpg",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Click",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.LightSkyBlue,
                            TextColor = Color.Black,
                            WidthRequest = 200,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var GPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Label
                        {
                            Text = "Mosquit - G",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "g.jpg",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Click",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.LightSkyBlue,
                            TextColor = Color.Black,
                            WidthRequest = 200,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var SpaceshipmyloveandmePage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Label
                        {
                            Text = "Moaquit - Spaceshipmyloveandme",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "space.png",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Click",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.LightSkyBlue,
                            TextColor = Color.Black,
                            WidthRequest = 200,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var PorschePage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Label
                        {
                            Text = "Mosquit - Porsche",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            TextColor = Color.Black,
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            WidthRequest = 300,
                            HeightRequest = 300,
                            Source = "porsche.jpg",
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        new Button
                        {
                            Text = "Click",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.LightSkyBlue,
                            TextColor = Color.Black,
                            WidthRequest = 200,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            Children.Add(UglyPage);
            Children.Add(GPage);
            Children.Add(SpaceshipmyloveandmePage);
            Children.Add(PorschePage);
        }
    } 
}
