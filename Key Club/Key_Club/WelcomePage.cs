using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class WelcomePage : ContentPage
    {
        private string name = "Your Name";
        private string club = "Your Club";

        public WelcomePage()
        {
            Title = "Welcome to Key Club";

            
            Label header = new Label();
            header.Text = "Welcome to Key Club";
            header.XAlign = TextAlignment.Center;
            header.FontSize = 48;

            Image logo = new Image();
            logo.Source = "@drawable/Icon";

            Entry nameCell = new Entry();
            nameCell.Placeholder = "Your Name";
            nameCell.TextChanged += NameCell_TextChanged;

            Entry clubCell = new Entry(); //to be replaced, with a dropdown most likely
            clubCell.Placeholder = "Your Club";
            clubCell.TextChanged += ClubCell_TextChanged;

            Button submitButton = new Button();
            submitButton.Text = "Sign up/in";

            submitButton.Clicked += SubmitButton_Clicked;

            StackLayout container = new StackLayout();
            container.Children.Add(header);
            container.Children.Add(logo);
            container.Children.Add(nameCell);
            container.Children.Add(clubCell);
            container.Children.Add(submitButton);
            

            Content = container;
        }

        private void ClubCell_TextChanged(object sender, TextChangedEventArgs e)
        {
            club = ((Entry)sender).Text;
        }

        private void NameCell_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = ((Entry)sender).Text;
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            //Save Info
            UserInfo.setName(name);
            UserInfo.setClub(club);

            //Return to Main Screen
            Navigation.PopModalAsync();
        }
    }
}
