using Blog.ComicDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebComicManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ServiceSoapClient ssc = new ServiceSoapClient();

        private void loadListItems()
        {
            Comic[] comics = ssc.PostAllAquire();
            if (ComicListControl.Items.Count > 0)
            {
                ComicListControl.Items.Clear();
            }
            foreach (var comic in comics.OrderByDescending(c => c.Date))
            {
                ComicListControl.Items.Add(comic.Name);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            loadListItems();
        }

        private void ComicListControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comic[] comics = ssc.PostAllAquire();
            foreach (var comic in comics)
            {
                if (comic.Name == ComicListControl.SelectedItem.ToString())
                {
                    ComicName.Text = comic.Name;
                    ComicAuthor.Text = comic.Author;
                    ComicDate.Text = comic.Date.ToString();
                }
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ComicListControl.SelectedItem != null)
            {
                Comic[] comics = ssc.PostAllAquire();
                foreach (var comic in comics)
                {
                    if (comic.Name == ComicListControl.SelectedItem.ToString())
                    {
                        string result = ssc.DeletePost(comic);
                        MessageBox.Show(result);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a comic to delete");
            }
            loadListItems();
        }
    }
}
