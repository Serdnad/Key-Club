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
            
            //AndroidTitleBarVisibility
            //UserInfo.setName("");
            if (UserInfo.getName().Equals(""))
                Navigation.PushModalAsync(new WelcomePage());

            this.Children.Add(new NewsPage());
            this.Children.Add(new UpcomingEventsPage());
            this.Children.Add(new MyInfoPage());
        }

        protected override void OnAppearing() //refresh MyInfo after login - NOT WORKING***************
        {
            this.Children.RemoveAt(2);
            this.Children.Add(new MyInfoPage());
        }
    }
}
