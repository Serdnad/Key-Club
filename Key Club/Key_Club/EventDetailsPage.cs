using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class EventDetailsPage : ContentPage
    {
        public EventDetailsPage(UpcomingEventsPage.upcomingEvent eventDetails)
        {
            Title = "Service Opportuniy";
            //BackgroundColor = Color.FromHex("#2196F3");

            Label header = new Label();
            header.Text = "Volunteer Opportunity";
            header.TextColor = Color.Black;
            header.FontSize = 36;
            header.FontFamily = Device.OnPlatform("Helvetica", "Droid Sans", "Comic Sans MS");
            header.XAlign = TextAlignment.Center;

            Label title = new Label();
            title.Text = eventDetails.title;
            title.TextColor = Color.Black;
            title.FontSize = 30;
            title.XAlign = TextAlignment.Center;

            Label description = new Label();
            description.Text = eventDetails.description + "\n\n";
            description.TextColor = Color.Black;
            description.HorizontalOptions = LayoutOptions.FillAndExpand;
            description.FontSize = 16;

            Label date = new Label();
            date.Text = "When: " + eventDetails.dayOfWeek + ", " + eventDetails.formattedDate;
            date.TextColor = Color.Black;
            date.FontSize = 16;

            Label locationLabel = new Label();
            locationLabel.Text = "Where: " + eventDetails.location;
            locationLabel.TextColor = Color.Black;
            locationLabel.FontSize = 16;

            Label time = new Label();
            time.Text = "Time: " + eventDetails.date.ToShortTimeString() + "\n\n";
            time.TextColor = Color.Black;
            time.FontSize = 16;

            Button signUpButton = new Button();
            signUpButton.Text = "Sign up for this event";
            signUpButton.BackgroundColor = Color.FromHex("#1976D2");
            signUpButton.Clicked += signUpPressed;

            Button addToCalenderButton = new Button();
            addToCalenderButton.Text = "Add to my calender";
            addToCalenderButton.BackgroundColor = Color.FromHex("#1976D2");
            addToCalenderButton.Clicked += addToCalendarPressed;

          

            StackLayout stl = new StackLayout();
            //stl.HorizontalOptions = LayoutOptions.Center;
            stl.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            
            stl.Children.Add(header);
            stl.Children.Add(title);
            stl.Children.Add(description);
            stl.Children.Add(date);
            stl.Children.Add(locationLabel);
            stl.Children.Add(time);
            stl.Children.Add(signUpButton);
            stl.Children.Add(addToCalenderButton);


            Content = new ScrollView
            {
                Content = stl
            };
        }

        public void signUpPressed(object sender, EventArgs e)
        {
            //TO BE IMPLEMENTED
        }

        public void addToCalendarPressed(object sender, EventArgs e)
        {
            //TO BE IMPLEMENTED (IF POSSIBLE)
        }
    }
}
