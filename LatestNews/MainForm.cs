using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LatestNews
{
    public partial class MainForm : Form
    {
        private List<string> ListRSS;
        public MainForm()
        {
            InitializeComponent();
            this.ListRSS = new List<string>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ListRSS lr = new ListRSS();
            if (lr.ShowDialog() == DialogResult.OK)
            {
                this.ListRSS = lr.addList;
            }
            else
            {
                this.Close();
            }
            foreach (string url in this.ListRSS)
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                using (StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
                {
                    TreeNode tn = this.treeView1.Nodes.Add(resp.ResponseUri.Host);
                    XDocument doc = XDocument.Load(sr);
                    var items = from item in doc.Descendants("item")
                                select new item(
                                item.Descendants("title").First().Value,
                                item.Descendants("link").First().Value,
                                item.Descendants("pubDate").First().Value,
                                item.Descendants("description").First().Value);
                    foreach (var i in items)
                        tn.Nodes.Add(i.Title).Tag = i;
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            item i = e.Node.Tag as item;
            if (i != null)
            {
                this.pictureBox_image.Image = i.Image;
                this.textBox_title.Text = i.Title;
                this.textBox_text.Text = i.Text;
                this.textBox_date.Text = i.Date;                
            }
        }
    }
}
