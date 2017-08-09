using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LatestNews
{
    public partial class ListRSS : Form
    {
        public ListRSS()
        {
            InitializeComponent();
        }
        public List<string> addList
        {
            get
            {
                return this.listBox_addList.Items.Cast<string>().ToList();
            }
        }
        private void button_del_Click(object sender, EventArgs e)
        {
            if (this.listBox_addList.SelectedItem != null)
            {
                this.listBox_addList.Items.Remove(this.listBox_addList.SelectedItem);
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                this.listBox_addList.Items.Add(this.textBox1.Text);
                this.textBox1.Text = "";
            }
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void LoadFromFile()
        {
            try
            {
                using (StreamReader sr = File.OpenText("ListLinks.txt"))
                {
                    string s = String.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        this.listBox_addList.Items.Add(s);
                    }
                }
            }
            catch {}
        }
        private void SaveToFile()
        {
            using (FileStream fs = new FileStream("ListLinks.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (string s in this.listBox_addList.Items)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
        }
        private void ListRSS_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }
        private void ListRSS_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }
    }
}
