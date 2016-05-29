using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    class NewsPage : ContentPage
    {
        public NewsPage()
        {
            Title = "News";
            List < newsEvent > news = new List<newsEvent>();

            //Placeholder newsEvents until news can be read from online DB***************************
            news.Add(new newsEvent("Saved 100 ducks", "Georgia key club got together to save over 99 ducks last weekend, in an renewed effort that's been gaining traction recently to save our furry brothers."));
            news.Add(new newsEvent("Angel Aguilar, Liuetenant Governor of Key Club USA", "Comrade Angel Aguilar has been privately elected to the position of supreme leader of USA Key Clubs"));
            news.Add(new newsEvent("More news", "get your jaw dropping news here"));
            news.Add(new newsEvent("Even More news", "get your less exciting, just mouth-opening news here"));
            news.Add(new newsEvent("I need more sleep", "I've come to the realization, at 1am Sunday, 5 hours before I have to wake up for church, that I'm not giving my health any attention."));
            news.Add(new newsEvent("I don't have to write these", "I'm glad I don't have to actually make these things. Once this thing works, I get paid, and I'm outta here."));

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
                            Padding = new Thickness(0, 5),
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

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

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
        

        class newsEvent
        {
            public string title { private set; get; }
            public string description { private set; get; }

            public newsEvent(string title, string description)
            {
                this.title = title;
                this.description = description;
            }
            

        }
    }
}
