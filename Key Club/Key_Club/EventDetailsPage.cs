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
            Label header = new Label();
            header.Text = "Volunteer Opportunity";
            header.FontSize = 36;
            header.XAlign = TextAlignment.Center;

            Label title = new Label();
            title.Text = eventDetails.title;
            title.FontSize = 24;
            title.XAlign = TextAlignment.Center;

            Label description = new Label();
            description.Text = eventDetails.description;
            description.FontSize = 16;

            Label date = new Label();
            date.Text = "When: " + eventDetails.date.ToShortDateString();
            date.FontSize = 16;

            Label time = new Label();
            time.Text = "Time: " + eventDetails.date.ToShortTimeString();
            time.FontSize = 16;

            Button signUpButton = new Button();
            signUpButton.Text = "Sign up for event";
            signUpButton.Clicked += signUpPressed;

            Button addToCalenderButton = new Button();
            addToCalenderButton.Text = "Add to my calender";
            addToCalenderButton.Clicked += addToCalendarPressed;

          

            StackLayout stl = new StackLayout();
            //stl.HorizontalOptions = LayoutOptions.Center;
            
            
            stl.Children.Add(header);
            stl.Children.Add(title);
            stl.Children.Add(description);
            stl.Children.Add(date);
            stl.Children.Add(time);
            stl.Children.Add(signUpButton);
            stl.Children.Add(addToCalenderButton);


            Content = stl;
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
