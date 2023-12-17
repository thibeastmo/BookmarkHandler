
namespace BookmarkHandler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetBookmarks = new System.Windows.Forms.Button();
            this.btnGetSortedBookMarkList = new System.Windows.Forms.Button();
            this.btnGetDirByName = new System.Windows.Forms.Button();
            this.btnGenerateJson = new System.Windows.Forms.Button();
            this.btnBookmarkJson = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnGenerateSortedBookmarks = new System.Windows.Forms.Button();
            this.btnGenerateHTML = new System.Windows.Forms.Button();
            this.btnGenerateSortedHTML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetBookmarks
            // 
            this.btnGetBookmarks.BackColor = System.Drawing.Color.Gray;
            this.btnGetBookmarks.FlatAppearance.BorderSize = 0;
            this.btnGetBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBookmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBookmarks.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGetBookmarks.Location = new System.Drawing.Point(12, 12);
            this.btnGetBookmarks.Name = "btnGetBookmarks";
            this.btnGetBookmarks.Size = new System.Drawing.Size(231, 44);
            this.btnGetBookmarks.TabIndex = 0;
            this.btnGetBookmarks.Text = "GetBookmarks";
            this.btnGetBookmarks.UseVisualStyleBackColor = false;
            this.btnGetBookmarks.Click += new System.EventHandler(this.btnGetBookmarks_Click);
            // 
            // btnGetSortedBookMarkList
            // 
            this.btnGetSortedBookMarkList.BackColor = System.Drawing.Color.Gray;
            this.btnGetSortedBookMarkList.FlatAppearance.BorderSize = 0;
            this.btnGetSortedBookMarkList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSortedBookMarkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSortedBookMarkList.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGetSortedBookMarkList.Location = new System.Drawing.Point(14, 112);
            this.btnGetSortedBookMarkList.Name = "btnGetSortedBookMarkList";
            this.btnGetSortedBookMarkList.Size = new System.Drawing.Size(231, 44);
            this.btnGetSortedBookMarkList.TabIndex = 2;
            this.btnGetSortedBookMarkList.Text = "GetSortedBookMarkList";
            this.btnGetSortedBookMarkList.UseVisualStyleBackColor = false;
            this.btnGetSortedBookMarkList.Click += new System.EventHandler(this.btnGetSortedBookMarkList_Click);
            // 
            // btnGetDirByName
            // 
            this.btnGetDirByName.BackColor = System.Drawing.Color.Gray;
            this.btnGetDirByName.FlatAppearance.BorderSize = 0;
            this.btnGetDirByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDirByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDirByName.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGetDirByName.Location = new System.Drawing.Point(12, 62);
            this.btnGetDirByName.Name = "btnGetDirByName";
            this.btnGetDirByName.Size = new System.Drawing.Size(231, 44);
            this.btnGetDirByName.TabIndex = 3;
            this.btnGetDirByName.Text = "GetDirByName";
            this.btnGetDirByName.UseVisualStyleBackColor = false;
            this.btnGetDirByName.Click += new System.EventHandler(this.btnGetDirByName_Click);
            // 
            // btnGenerateJson
            // 
            this.btnGenerateJson.BackColor = System.Drawing.Color.Gray;
            this.btnGenerateJson.FlatAppearance.BorderSize = 0;
            this.btnGenerateJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateJson.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateJson.Location = new System.Drawing.Point(12, 162);
            this.btnGenerateJson.Name = "btnGenerateJson";
            this.btnGenerateJson.Size = new System.Drawing.Size(231, 44);
            this.btnGenerateJson.TabIndex = 4;
            this.btnGenerateJson.Text = "GenerateJson";
            this.btnGenerateJson.UseVisualStyleBackColor = false;
            this.btnGenerateJson.Click += new System.EventHandler(this.btnGenerateJson_Click);
            // 
            // btnBookmarkJson
            // 
            this.btnBookmarkJson.BackColor = System.Drawing.Color.Gray;
            this.btnBookmarkJson.FlatAppearance.BorderSize = 0;
            this.btnBookmarkJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookmarkJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookmarkJson.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnBookmarkJson.Location = new System.Drawing.Point(12, 214);
            this.btnBookmarkJson.Name = "btnBookmarkJson";
            this.btnBookmarkJson.Size = new System.Drawing.Size(231, 44);
            this.btnBookmarkJson.TabIndex = 5;
            this.btnBookmarkJson.Text = "BookmarkJson";
            this.btnBookmarkJson.UseVisualStyleBackColor = false;
            this.btnBookmarkJson.Click += new System.EventHandler(this.btnBookmarkJson_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Gray;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSort.Location = new System.Drawing.Point(12, 264);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(231, 44);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnGenerateSortedBookmarks
            // 
            this.btnGenerateSortedBookmarks.BackColor = System.Drawing.Color.Gray;
            this.btnGenerateSortedBookmarks.FlatAppearance.BorderSize = 0;
            this.btnGenerateSortedBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSortedBookmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSortedBookmarks.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateSortedBookmarks.Location = new System.Drawing.Point(14, 314);
            this.btnGenerateSortedBookmarks.Name = "btnGenerateSortedBookmarks";
            this.btnGenerateSortedBookmarks.Size = new System.Drawing.Size(231, 44);
            this.btnGenerateSortedBookmarks.TabIndex = 7;
            this.btnGenerateSortedBookmarks.Text = "GenerateSortedBookmarks";
            this.btnGenerateSortedBookmarks.UseVisualStyleBackColor = false;
            this.btnGenerateSortedBookmarks.Click += new System.EventHandler(this.btnGenerateSortedBookmarks_Click);
            // 
            // btnGenerateHTML
            // 
            this.btnGenerateHTML.BackColor = System.Drawing.Color.Gray;
            this.btnGenerateHTML.FlatAppearance.BorderSize = 0;
            this.btnGenerateHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateHTML.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateHTML.Location = new System.Drawing.Point(12, 364);
            this.btnGenerateHTML.Name = "btnGenerateHTML";
            this.btnGenerateHTML.Size = new System.Drawing.Size(231, 44);
            this.btnGenerateHTML.TabIndex = 8;
            this.btnGenerateHTML.Text = "GenerateHTML";
            this.btnGenerateHTML.UseVisualStyleBackColor = false;
            this.btnGenerateHTML.Click += new System.EventHandler(this.btnGenerateHTML_Click);
            // 
            // btnGenerateSortedHTML
            // 
            this.btnGenerateSortedHTML.BackColor = System.Drawing.Color.Gray;
            this.btnGenerateSortedHTML.FlatAppearance.BorderSize = 0;
            this.btnGenerateSortedHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSortedHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSortedHTML.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnGenerateSortedHTML.Location = new System.Drawing.Point(12, 443);
            this.btnGenerateSortedHTML.Name = "btnGenerateSortedHTML";
            this.btnGenerateSortedHTML.Size = new System.Drawing.Size(231, 44);
            this.btnGenerateSortedHTML.TabIndex = 9;
            this.btnGenerateSortedHTML.Text = "GenerateSortedHTML";
            this.btnGenerateSortedHTML.UseVisualStyleBackColor = false;
            this.btnGenerateSortedHTML.Click += new System.EventHandler(this.btnGenerateSortedHTML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 499);
            this.Controls.Add(this.btnGenerateSortedHTML);
            this.Controls.Add(this.btnGenerateHTML);
            this.Controls.Add(this.btnGenerateSortedBookmarks);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnBookmarkJson);
            this.Controls.Add(this.btnGenerateJson);
            this.Controls.Add(this.btnGetDirByName);
            this.Controls.Add(this.btnGetSortedBookMarkList);
            this.Controls.Add(this.btnGetBookmarks);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetBookmarks;
        private System.Windows.Forms.Button btnGetSortedBookMarkList;
        private System.Windows.Forms.Button btnGetDirByName;
        private System.Windows.Forms.Button btnGenerateJson;
        private System.Windows.Forms.Button btnBookmarkJson;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnGenerateSortedBookmarks;
        private System.Windows.Forms.Button btnGenerateHTML;
        private System.Windows.Forms.Button btnGenerateSortedHTML;
    }
}

