using System;
using System.Collections.Generic;
using System.Text;

namespace Key_Club
{
    public static class DBHelper
    {
        private static string placeHolderForDBConnection; //keep one var for all DB interactions

        public static List<string> getClubList()
        {
            List<string> clubs = new List<string>();

            //TO BE IMPLEMENTED
            ///check for existing connection to DB, if not, establish connection
            ///form, execute query to fetch clubs under certain state/ country
            ///loop through results, adding each to clubs

            clubs.Add("Belen Jesuit");




            return clubs;
        }
    }
}
