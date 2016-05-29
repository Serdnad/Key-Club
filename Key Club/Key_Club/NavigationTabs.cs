using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class NavigationTabs : TabbedPage
    {
        public NavigationTabs()
        {
            this.Title = "Key Club";
            this.Children.Add(new ContentPage
            {
                Title = "Calendar",
                Content = new BoxView
                {
                    Color = Color.Blue,
                    HeightRequest = 100f,
                    VerticalOptions = LayoutOptions.Center
                },
            });

            this.Children.Add(new ContentPage
            {
                Title = "News",
                Content = new ScrollView
                {
                    Content = new BoxView
                    {
                        Color = Color.Blue,
                        HeightRequest = 100f,
                        VerticalOptions = LayoutOptions.Center
                    },
                }
            });
        }
    }
}
