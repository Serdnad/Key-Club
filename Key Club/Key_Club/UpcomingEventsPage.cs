using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class UpcomingEventsPage : ContentPage
    {
        public UpcomingEventsPage()
        {
            Title = "Events";
            List<upcomingEvent> news = new List<upcomingEvent>();

            DateTime dt = new DateTime(2016, 6, 14, 8, 0, 0);
            //Placeholder newsEvents until news can be read from online DB***************************
            news.Add(new upcomingEvent("Save 100 ducks", "Georgia key club got together to save over 99 ducks last weekend, in an renewed effort that's been gaining traction recently to save our furry brothers.", dt));
            news.Add(new upcomingEvent("Angel Aguilar, Liuetenant Governor of Key Club USA", "Comrade Angel Aguilar has been privately elected to the position of supreme leader of USA Key Clubs", dt));
            news.Add(new upcomingEvent("More news", "get your jaw dropping news here", dt));
            news.Add(new upcomingEvent("Even More news", "get your less exciting, just mouth-opening news here", dt));
            news.Add(new upcomingEvent("I need more sleep", "I've come to the realization, at 1am Sunday, 5 hours before I have to wake up for church, that I'm not giving my health any attention.", dt));
            news.Add(new upcomingEvent("I don't have to write these", "I'm glad I don't have to actually make these things. Once this thing works, I get paid, and I'm outta here.", dt));

            ListView listView = new ListView
            {
                RowHeight = 100,
                ItemsSource = news,

                ItemTemplate = new DataTemplate(() =>
                {
                    Label titleLabel = new Label();
                    titleLabel.SetBinding(Label.TextProperty, "title");

                    Label descriptionLabel = new Label();
                    descriptionLabel.SetBinding(Label.TextProperty, "description");

                    Image eventImage = new Image();
                    eventImage.Source = "@drawable/Icon"; //TEMPORARY

                    

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            HeightRequest = 300,
                            Padding = new Thickness(5, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                eventImage,
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 0,
                                    Children =
                                    {
                                        titleLabel,
                                        descriptionLabel
                                    }
                                }
                            }
                        }
                    };
                })
            };

            listView.ItemTapped += (sender, e) => {
                upcomingEvent Event = (upcomingEvent)((ListView)sender).SelectedItem;
                Navigation.PushModalAsync(new EventDetailsPage(Event));
                ((ListView)sender).SelectedItem = null;
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // Build the page.
            this.Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        listView
                    }
                }
            };
        }


        public class upcomingEvent
        {
            public string title { private set; get; }
            public string description { private set; get; }
            public DateTime date { private set; get; }

            public upcomingEvent(string title, string description)
            {
                this.title = title;
                this.description = description;
            }
            public upcomingEvent(string title, string description, DateTime date)
            {
                this.title = title;
                this.description = description;
                this.date = date;
            }

        }
    }
}
