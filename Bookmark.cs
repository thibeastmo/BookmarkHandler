using JsonObjectConverter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookmarkHandler
{
    public class Bookmark
    {
        public DateTime? date_added { get; private set; }
        public string guid { get; private set; }
        public int id { get; private set; }
        public string name { get; private set; }
        public string type { get; private set; }
        public string url { get; private set; }
        public DateTime? date_modified { get; private set; }
        public DateTime? last_visited_desktop { get; private set; }
        public List<Bookmark> bookmarks { get; private set; }
        //private long addThisAsTicksToAllDateTimes = 2995183586579372;

        public Bookmark(Json aJson)
        {
            setValues(aJson);
            if (type != null)
            {
                if (type.ToLower().Equals("folder"))
                {
                    if (aJson.subJsons != null && aJson.subJsons.Count > 0)
                    {
                        this.bookmarks = new List<Bookmark>();
                        foreach (Json subjson in aJson.subJsons)
                        {
                            if (!subjson.head.ToLower().Equals("meta_info"))
                            {
                                this.bookmarks.Add(new Bookmark(subjson));
                            }
                        }
                    }
                }
            }
            if (aJson.subJsons != null && aJson.subJsons.Count > 0)
            {
                if (aJson.subJsons[0].tupleList != null && aJson.subJsons[0].tupleList.Count > 0)
                {
                    last_visited_desktop = Json.convertStringToDateTime(aJson.subJsons[0].tupleList[0].Item2.Item1);
                }
            }
            //decreaseDateTimes();
        }
        private void setValues(Json helper)
        {
            if (helper.tupleList != null)
            {
                foreach (Tuple<string, Tuple<string, bool>> tuple in helper.tupleList)
                {
                    string temp = tuple.Item2.Item1.Trim(' ').Trim('\"');
                    if (!temp.ToLower().Equals("null"))
                    {
                        string item1 = tuple.Item1.Trim(' ').Trim('\"');
                        var property = this.GetType().GetProperty(item1);
                        if (property != null)
                        {
                            var valueToSet = new object();
                            //if (property.PropertyType.Name.Equals("DateTime"))
                            if (property.PropertyType == typeof(DateTime?))
                            {
                                string elevenDigits = temp.Substring(0, 11);
                                long longValue = long.Parse(elevenDigits);
                                DateTime dateTimeVar = new DateTime(1601, 1, 1).AddSeconds(longValue);
                                valueToSet = dateTimeVar;
                                //valueToSet = Json.convertStringToDateTime(temp); //Hardcoded er 1 uur bijgeteld omdat de json, van de site een uur vroeger dan het uur dat op de site staat, teruggeeft
                                //valueToSet = Json.convertStringToDateTime(((long)(Convert.ToInt64(temp)*1.2256925)).ToString()); //Hardcoded er 1 uur bijgeteld omdat de json, van de site een uur vroeger dan het uur dat op de site staat, teruggeeft
                                //valueToSet = Json.convertStringToDateTime(temp);
                            }
                            else
                            {
                                valueToSet = Convert.ChangeType(temp, property.PropertyType);
                            }
                            property.SetValue(this, valueToSet);
                        }
                    }
                }
            }
        }
        private void decreaseDateTimes()
        {
            foreach (System.Reflection.PropertyInfo property in this.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(DateTime?))
                {
                    var tempObj = property.GetValue(this, null);
                    if (tempObj != null)
                    {
                        DateTime tempDT = (DateTime)tempObj;
                        //tempDT = new DateTime((tempDT.Ticks - Json.startingDateTime.Ticks));
                        //if (Json.isWinter(tempDT))
                        //{
                        //    tempDT = tempDT.AddHours(-1);
                        //}
                        tempDT = tempDT.Subtract(new TimeSpan(Json.startingDateTime.Ticks));
                        property.SetValue(this, tempDT);
                    }
                }
            }
        }
        public void sortBookMarksDescending()
        {
            if (this.bookmarks != null && this.bookmarks.Count > 0)
            {
                this.bookmarks = this.bookmarks.OrderBy(x => x.date_added).ToList();
                this.bookmarks.Reverse();
            }
        }
    }
}
