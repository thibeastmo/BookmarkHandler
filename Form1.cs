using JsonObjectConverter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarkHandler
{
    public partial class Form1 : Form
    {
        private BM_Handler bm;
        private DateTime? x;
        public Form1()
        {
            InitializeComponent();
            bm = new BM_Handler();
        }

        private async void btnGetBookmarks_Click(object sender, EventArgs e)
        {
            List<Bookmark> bookmarkList = new List<Bookmark>();
            await Task.Run(() => {
                bookmarkList = bm.getAllBookMarksAsList();
            });
        }

        private void btnGetSortedBookMarkList_Click(object sender, EventArgs e)
        {
            List<Bookmark> bookmarkList = bm.getBookmarksOfDir("series", bm.getAllBookMarksAsList());
            bookmarkList = bm.sortOnDateDescending(bookmarkList);
        }

        private void btnGetDirByName_Click(object sender, EventArgs e)
        {
            List<Bookmark> bookmarkListOfDir = bm.getBookmarksOfDir("kdg>Computersystemen", bm.getAllBookMarksAsList());
        }

        private void btnGenerateJson_Click(object sender, EventArgs e)
        {
            Json originalJson = bm.getAllBookMarksInJson();
            string originalCreatedJson = originalJson.generateJson();
            //string originalJson = System.IO.File.ReadAllText("../../../exampleJson.json");
            //string originalJson = System.IO.File.ReadAllText(@"C:\Users\thimo\Documents\Mijn projecten\BookmarkHandler\BookmarkHandler\exampleJson.json");
            //Json theOriginalJson = new Json(originalJson, string.Empty);
            //string createdJson = theOriginalJson.generateJson();
        }

        private void btnBookmarkJson_Click(object sender, EventArgs e)
        {
            List<Bookmark> bookmarkList = bm.getAllBookMarksAsList();
            foreach (Bookmark aBookmark in bookmarkList)
            {
                if (aBookmark.name.Equals("Keyboard"))
                {
                    string generatedBookmarkJson = Json.generateJsonFromObject(aBookmark, aBookmark.GetType());
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Json allJson = bm.getAllBookMarksInJson();
            List<Json> sortedJson = allJson.sortProperty("date_added", allJson, true, true);
        }

        private void btnGenerateSortedBookmarks_Click(object sender, EventArgs e)
        {
            Json allJson = bm.getAllBookMarksInJson();
            Json sortedJson = allJson.sortProperty("date_added", allJson, true, true)[0];
            //string generateSortedBookmarksString = sortedJson.generateJson();
        }

        private void btnGenerateHTML_Click(object sender, EventArgs e)
        {
            string exportableHTMLFromBookmarks = bm.generateBookmarksHTML(bm.getAllBookMarksInJson());
        }

        private void btnGenerateSortedHTML_Click(object sender, EventArgs e)
        {
            Json allJson = bm.getAllBookMarksInJson();
            Json sortedJson = allJson.sortProperty("date_added", allJson, true, true)[0];
            string exportableHTMLFromBookmarks = bm.generateBookmarksHTML(sortedJson);
            string filePath = @"C:\Users\thimo\Documents\bookmarks_28-07-2021.html";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                File.WriteAllText(filePath, exportableHTMLFromBookmarks);
                System.Diagnostics.Process.Start(filePath);
            }
            catch
            {
                MessageBox.Show("Er is iets mis gegaan tijdens het opslagen van het html bestand.");
            }
        }
    }
}
