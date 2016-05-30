using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Key_Club
{
    static class UserInfo
    {
        //Can also be setup with builtin gets and sets. might be cleaner
        //private static string name;
        //private static string email;
        //private static string club;

        public static void setName(string newName)
        {
            Application.Current.Properties["name"] = newName;
            Application.Current.SavePropertiesAsync();
        }

        public static void setClub(string newClub)
        {
            Application.Current.Properties["club"] = newClub;
            Application.Current.SavePropertiesAsync();
        }

        public static string getName()
        {
            if (!Application.Current.Properties.ContainsKey("name"))
                return "";
            else
            return Application.Current.Properties["name"].ToString();
        }

        public static string getClub()
        {
            if (!Application.Current.Properties.ContainsKey("club"))
                return "";
            else
                return Application.Current.Properties["club"].ToString();
        }

        public static int getHours()
        {
            return -1;
        }
    }
}
