using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class MyInfoPage : ContentPage
    {
        public MyInfoPage()
        {
            Title = "My Info";

            Label headerLabel = new Label();
            headerLabel.Text = "My Info";
            headerLabel.HorizontalOptions = LayoutOptions.Center;
            headerLabel.FontSize = 48;

            Label nameLabel = new Label();
            nameLabel.Text = "Welcome, " + UserInfo.getName();
            //nameLabel.HorizontalOptions = LayoutOptions.Center;
            nameLabel.FontSize = 32;

            Label clubLabel = new Label();
            clubLabel.Text = "Your current club: " + UserInfo.getClub();
            clubLabel.FontSize = 24;

            Label hoursLabel = new Label();
            hoursLabel.Text = "Hours: " + UserInfo.getHours();
            hoursLabel.FontSize = 24;

            StackLayout container = new StackLayout();
            container.Children.Add(headerLabel);
            container.Children.Add(nameLabel);
            container.Children.Add(clubLabel);
            container.Children.Add(hoursLabel);

            Content = container;
        }
    }
}
