using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class MyInfo : ContentPage
    {
        public MyInfo()
        {
            Title = "My Info";

            Label headerLabel = new Label();
            headerLabel.Text = "My Info";
            headerLabel.FontSize = 48;

            Label nameLabel = new Label();
            nameLabel.Text = "Name: " + UserInfo.getName();
            nameLabel.FontSize = 24;

            Label clubLabel = new Label();
            clubLabel.Text = "Club: " + UserInfo.getClub();
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
