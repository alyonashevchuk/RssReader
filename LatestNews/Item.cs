using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace LatestNews
{
    class item
    {
        private bool isTextParse;
        public string Title { get; set; }
        public string Link { get; set; }
        public string Date { get; set; }
        private string text;
        public string Text
        {
            get
            {
                if (!isTextParse)
                    text = parseText();
                return text;
            }
            set
            {
                text = value;
            }
        }
        private Bitmap image;
        public Bitmap Image
        {
            get
            {
                if (image == null)
                    image = GetImg();
                return image;
            }
            set
            {
                image = value;
            }
        }

        public item(string title, string link, string date, string text)
        {
            this.Title = title;
            this.Link = link;
            this.Date = date;
            this.Text = text;
        }
        public Bitmap GetImg()
        {
            Regex regex = new Regex(@"src=.[a-zA-Z/.:0-9_]*", RegexOptions.IgnoreCase);
            string imgUrl = regex.Match(this.text).Value.Replace("src=\"", "");
            if (imgUrl != "" && (imgUrl.Contains(".jpg") || imgUrl.Contains(".png") || imgUrl.Contains(".gif")))
            {
                WebClient wc = new WebClient();
                byte[] img = wc.DownloadData(imgUrl);
                MemoryStream ms = new MemoryStream(img);
                return new Bitmap(ms);
            }
            return null;
        }
        public string parseText()
        {
            this.isTextParse = true;            
            Regex regex = new Regex(@"<[A-z/ =?"":.0-9-#%]*>", RegexOptions.IgnoreCase);
            var rm = regex.Matches(this.text);
            foreach (var rmv in rm)
            {
                this.text = this.text.Replace(rmv.ToString(), "");
            }
            this.text = this.text.Replace("&rarr;", "...");
            return this.text;
        }
        public override string ToString()
        {
            return this.Title;
        }
    }
}
