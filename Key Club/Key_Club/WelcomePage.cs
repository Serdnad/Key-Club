using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class WelcomePage : ContentPage
    {
        public List<string> clubs;
        private string name = "Your Name";
        private string club = "Your Club";


        public WelcomePage()
        {
            clubs = DBHelper.getClubList();
            clubs.Insert(0, "Your Key Club");



            Title = "Welcome to Key Club";
            //BackgroundColor = Color.FromHex("#2196F3");
            
            Label header = new Label();
            header.Text = "Welcome to Key Club";
            header.TextColor = Color.Black;
            header.XAlign = TextAlignment.Center;
            header.FontSize = 48;

            Image logo = new Image();
            logo.Source = "@drawable/Icon";

            Entry nameCell = new Entry();
            nameCell.TextColor = Color.Black;
            nameCell.Placeholder = "Your Name";
            nameCell.TextChanged += NameCell_TextChanged;

            Picker clubPicker = new Picker(); //to be replaced, with a dropdown most likely
            foreach (string club in clubs)
                clubPicker.Items.Add(club);
            clubPicker.SelectedIndex = 0;
            clubPicker.SelectedIndexChanged += ClubPicker_SelectedIndexChanged;

            Button submitButton = new Button();
            submitButton.BackgroundColor = Color.FromHex("#1976D2");
            submitButton.Text = "Sign up/in";

            submitButton.Clicked += SubmitButton_Clicked;

            StackLayout container = new StackLayout();
            container.Children.Add(header);
            container.Children.Add(logo);
            container.Children.Add(nameCell);
            container.Children.Add(clubPicker);
            container.Children.Add(submitButton);
            

            Content = container;
        }

        private void ClubPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            club = clubs[((Picker)sender).SelectedIndex-1];
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
