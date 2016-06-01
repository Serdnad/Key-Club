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
            List<upcomingEvent> events = new List<upcomingEvent>();

            DateTime dt = new DateTime(2016, 6, 11, 8, 0, 0);
            //Placeholder newsEvents until news can be read from online DB***************************
            int i = 0;
            events.Add(new upcomingEvent("Save 100 ducks", "Georgia key club got together to save over 99 ducks last weekend, in an renewed effort that's been gaining traction recently to save our furry brothers.", "Johnny Appleseed Memorial Park, 1500 Coliseum Blvd E, Fort Wayne, IN 46805", dt.AddDays(i+=7)));
            events.Add(new upcomingEvent("Angel Aguilar, Liuetenant Governor of Key Club USA", "Comrade Angel Aguilar has been privately elected to the position of supreme leader of USA Key Clubs.", "Johnny Appleseed Memorial Park, 1500 Coliseum Blvd E, Fort Wayne, IN 46805", dt.AddDays(i += 3)));
            events.Add(new upcomingEvent("More news", "Get your jaw dropping news here!", "Johnny Appleseed Memorial Park, 1500 Coliseum Blvd E, Fort Wayne, IN 46805", dt.AddDays(i += 3)));
            events.Add(new upcomingEvent("Even More news", "Get your less exciting, just mouth-opening news here.", "Johnny Appleseed Memorial Park, 1500 Coliseum Blvd E, Fort Wayne, IN 46805", dt.AddDays(i += 5)));
            events.Add(new upcomingEvent("I need more sleep", "I've come to the realization, at 1am Sunday, 5 hours before I have to wake up for church, that I'm not giving my health any attention.", "Johnny Appleseed Memorial Park, 1500 Coliseum Blvd E, Fort Wayne, IN 46805", dt.AddDays(i += 3)));
            events.Add(new upcomingEvent("I don't have to write these", "I'm glad I don't have to actually make these things. Once this thing works, I get paid, and I'm outta here.", "Johnny Appleseed Memorial Park, 1500 Coliseum Blvd E, Fort Wayne, IN 46805", dt.AddDays(i += 5)));


            //************************************************** old scrollview - to be replaced with calendar
            ListView listView = new ListView
            {
                RowHeight = 100,
                ItemsSource = events,

                ItemTemplate = new DataTemplate(() =>
                {
                    Label titleLabel = new Label();
                    titleLabel.TextColor = Color.Black;
                    titleLabel.FontSize = 18;
                    titleLabel.SetBinding(Label.TextProperty, "title");

                    Label descriptionLabel = new Label();
                    descriptionLabel.SetBinding(Label.TextProperty, "description");

                    //Image eventImage = new Image();
                    //eventImage.Source = "@drawable/Icon"; //TEMPORARY

                    Label dayLabel = new Label();
                    dayLabel.TextColor = Color.Black;
                    dayLabel.FontSize = 20;
                    dayLabel.HorizontalOptions = LayoutOptions.Center;
                    dayLabel.SetBinding(Label.TextProperty, "dayOfWeek");

                    Label dateLabel = new Label();
                    dateLabel.TextColor = Color.Black;
                    dateLabel.FontSize = 20;
                    dateLabel.HorizontalOptions = LayoutOptions.Center;
                    dateLabel.SetBinding(Label.TextProperty, "formattedDate");

                    Image calendarImage = new Image();
                    calendarImage.Source = "@Drawable/calendar";
                    calendarImage.Aspect = Aspect.AspectFill;

                    StackLayout imageSTL = new StackLayout
                    {
                        //WidthRequest = 400,
                        Children =
                        {
                            calendarImage
                        }
                    };

                    StackLayout dateSTL = new StackLayout
                    {
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center,
                        Spacing = 0,
                        Children =
                        {
                            dayLabel,
                            dateLabel
                        }
                    };

                    RelativeLayout rl = new RelativeLayout();
                    //rl.WidthRequest = 400;
                    rl.Children.Add(imageSTL, Constraint.Constant(0), Constraint.Constant(0), Constraint.Constant(90), Constraint.Constant(300));
                    rl.Children.Add(dateSTL, Constraint.Constant(0), Constraint.Constant(20), Constraint.Constant(90), Constraint.Constant(300));


                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            HeightRequest = 300,
                            Padding = new Thickness(5, 5),
                            Orientation = StackOrientation.Horizontal,

                            Children =
                            {
                                //rl,
                                new StackLayout
                                {
                                    MinimumWidthRequest = 410,
                                    Children = {rl}
                                },
                                
                                new StackLayout
                                {
                                    
                                    //VerticalOptions = LayoutOptions.Center,
                                    HorizontalOptions = LayoutOptions.StartAndExpand,
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
            //***************************************************************

            StackLayout calendarContainer = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new ListView
                    {
                        //ItemTemplate = new DataTemplate() //you are here
                    }
                }
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
                        listView //replace with calendar...

                    }
                }
            };
        }


        public class upcomingEvent
        {
            public string title { private set; get; }
            public string description { private set; get; }
            public string location { private set; get; }
            public string dayOfWeek { private set; get; }
            public string formattedDate { private set; get; }
            public DateTime date { private set; get; }

            public upcomingEvent(string title, string description, string location)
            {
                this.title = title;
                this.description = description;
                this.location = location;
            }
            public upcomingEvent(string title, string description, string location, DateTime date)
            {
                this.title = title;
                this.description = description;
                this.location = location;
                this.date = date;
                dayOfWeek = date.DayOfWeek.ToString();
                formattedDate = date.ToShortDateString();
            }

        }
    }
}
