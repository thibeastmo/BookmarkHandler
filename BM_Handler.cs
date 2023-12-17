using JsonObjectConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BookmarkHandler
{
    public class BM_Handler
    {
        private string bookmarkDirPath = @"C:\Users\thimo\AppData\Local\Google\Chrome\User Data\Default\Bookmarks";
        /// <summary>
        /// Gets the list of bookmarks in the folder
        /// You can get the subfolders by typing the > character
        /// </summary>
        /// <param name="dirName"></param>
        /// <param name="bookmarkList"></param>
        /// <returns>list of bookmarks</returns>
        public List<Bookmark> getBookmarksOfDir(string dirName, List<Bookmark> bookmarkList)
        {
            string[] splitted = dirName.Split('>');
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < splitted.Length; i++)
            {
                if (i > 1)
                {
                    sb.Append('>');
                }
                sb.Append(splitted[i]);
            }
            if (bookmarkList != null && bookmarkList.Count > 0)
            {
                foreach (Bookmark bookmark in bookmarkList)
                {
                    if (bookmark.type != null && bookmark.type.ToLower().Equals("folder"))
                    {
                        if (splitted.Length == 1 && bookmark.name != null && bookmark.name.ToLower().Equals(splitted[0].ToLower())) {
                            return bookmark.bookmarks;
                        }
                        else if (bookmark.bookmarks != null && bookmark.bookmarks.Count > 0 && splitted.Length > 1)
                        {
                            return getBookmarksOfDir(sb.ToString(), bookmark.bookmarks);
                        }
                    }
                }
            }
            return null;
        }
        public Json getAllBookMarksInJson()
        {
            if (File.Exists(bookmarkDirPath))
            {
                return new Json(File.ReadAllText(bookmarkDirPath), string.Empty);
            }
            return new Json(string.Empty, string.Empty);
        }
        public List<Bookmark> getAllBookMarksAsList()
        {
            List<Bookmark> bookmarkList = new List<Bookmark>();
            Json allBm = getAllBookMarksInJson();
            if (allBm.subJsons != null && allBm.subJsons.Count > 0)
            {
                if (allBm.subJsons[0].subJsons != null && allBm.subJsons[0].subJsons.Count > 0)
                {
                    if (allBm.subJsons[0].subJsons[0].subJsons != null && allBm.subJsons[0].subJsons[0].subJsons.Count > 0)
                    {
                        foreach (Json aSubjson in allBm.subJsons[0].subJsons[0].subJsons)
                        {
                            Bookmark tempBookMark = new Bookmark(aSubjson);
                            bookmarkList.Add(tempBookMark);
                        }
                    }
                }
            }
            return bookmarkList;
        }
        public List<Bookmark> sortOnDateDescending(List<Bookmark> bookmarkList)
        {
            for (int i = 0; i < bookmarkList.Count; i++)
            {
                if (bookmarkList[i].bookmarks != null)
                {
                    bookmarkList[i].sortBookMarksDescending();
                    if (bookmarkList[i].bookmarks != null && bookmarkList[i].bookmarks.Count > 0)
                    {
                        sortOnDateDescending(bookmarkList[i].bookmarks);
                    }
                }
            }
            bookmarkList = bookmarkList.OrderBy(x => x.date_added).ToList();
            bookmarkList.Reverse();
            return bookmarkList;
        }
        public string generateBookmarksHTML(Json json)
        {
            if (json.head.ToLower().Equals("bookmark_bar"))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<!DOCTYPE NETSCAPE-Bookmark-file-1>");
                sb.AppendLine("<!-- This is an automatically generated file.");
                sb.AppendLine("     It will be read and overwritten.");
                sb.AppendLine("     DO NOT EDIT! -->");
                sb.AppendLine("<META HTTP-EQUIV=\"Content - Type\" CONTENT=\"text / html; charset = UTF - 8\">");
                sb.AppendLine("<TITLE>Bookmarks</TITLE>");
                sb.AppendLine("<H1>Bookmarks</H1>");
                sb.AppendLine(generateDL(new Bookmark(json), 0));
                return sb.ToString();
            }
            else if (json.subJsons != null && json.subJsons.Count > 0) 
            {
                foreach (Json aJson in json.subJsons)
                {
                    string tempReturn = generateBookmarksHTML(aJson);
                    if (tempReturn != null)
                    {
                        return tempReturn;
                    }
                }
            }
            return null;
        }
        private string generateDL(Bookmark bm, int tabsAmount)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(generateTabs(tabsAmount)+ "<DT><H3 ADD_DATE=\"" + bm.date_added.Value.getSecondsFromDateTime() + "\" LAST_MODIFIED=\"" + bm.date_modified.Value.getSecondsFromDateTime() + "\">" + bm.name + "</H3>");
            sb.AppendLine(generateTabs(tabsAmount) + "<DL><P>");
            if (bm.bookmarks != null && bm.bookmarks.Count > 0)
            {
                foreach (Bookmark subBM in bm.bookmarks)
                {
                    string temp = generateDT(subBM, tabsAmount + 1);
                    if (temp != null && temp.Length > 0)
                    {
                        sb.AppendLine(temp);
                    }
                }
            }
            sb.Append(generateTabs(tabsAmount) + "</DL><p>");
            return sb.ToString();
        }
        public long getLatestModified(Json json, long lm) {
            if (json.tupleList != null && json.tupleList.Count > 0)
            {
                foreach (Tuple<string, Tuple<string, bool>> tupleItem in json.tupleList)
                {
                    if (tupleItem.Item1.ToLower().Equals(""))
                    {
                        try
                        {
                            long tempLong = Convert.ToInt64(tupleItem.Item2);
                            if (lm < tempLong)
                            {
                                lm = tempLong;
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
            if (json.subJsons != null && json.subJsons.Count > 0)
            {
                foreach (Json subJson in json.subJsons)
                {
                    long longest = getLatestModified(subJson, lm);
                    if (lm < longest)
                    {
                        lm = longest;
                    }
                }
            }
            return lm;
        }
        private string generateDT(Bookmark bm, int tabsAmount)
        {
            if (!bm.type.Equals("folder"))
            {
                StringBuilder sb = new StringBuilder(generateTabs(tabsAmount + 1) + "<DT><");
                if (tabsAmount == 0)
                {
                    sb.Append("H3 ADD_DATE=\"1568217949\" LAST_MODIFIED=\"" + getLatestModified(getAllBookMarksInJson(), 0).ToString() + "\" PERSONAL_TOOLBAR_FOLDER=\"true\">Bookmarkbalk</H3");
                }
                else
                {
                    //link
                    sb.Append("A HREF=\"" + bm.url + "\" ADD_DATE=\"" + bm.date_added.Value.getSecondsFromDateTime() + "\">" + bm.name + "</A");
                }
                sb.Append(">");
                return sb.ToString();
            }
            else if (bm.bookmarks != null && bm.bookmarks.Count > 0) {
                return generateDL(bm, tabsAmount + 1);
            }
            return null;
        }
        private static string generateTabs(int amount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < amount; i++)
            {
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
    public static class DateTimeHelper
    {
        public static string getSecondsFromDateTime(this DateTime dt)
        {
            return dt.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString();
        }
    }
}
