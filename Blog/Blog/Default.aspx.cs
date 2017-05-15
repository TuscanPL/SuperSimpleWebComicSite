using Blog.Code;
using Blog.ComicDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class MainPage : System.Web.UI.Page
    {
        ContentLoader cl = new ContentLoader();

        protected void Page_Load(object sender, EventArgs e)
        {
            //ToDo:
            //Make the website nicer
            //Move the DropDown data into a second menu
            //Implement AJAX for Data Loading?
            //Rewrite for WCF?
            //Rewrite for MVC?
            if (!IsPostBack)
            {
                List<Comic> comicServerList = cl.getComics();
                comicServerList = comicServerList.OrderByDescending(c => c.Date).ToList();

                foreach (var comic in comicServerList)
                {
                    comicList.Items.Add(comic.Name);
                }
                Comic latestComic = cl.getComic();
                SetComic(latestComic);
            }


        }

        protected void SetComic(Comic comic)
        {
            comicTitle.Text = comic.Name;
            string date = String.Format("{0}.{1}.{2}", comic.Date.Day, comic.Date.Month, comic.Date.Year);
            comicBlogPost.Text = String.Format(@"{0}<br \><br \>{1}<br \>{2}", comic.BlogPost, comic.Author, date);
            comicImage.ImageUrl = cl.GetImage(comic.ImageName);
        }

        protected void comicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comic comic = cl.getComic(comicList.SelectedValue);
            SetComic(comic);
        }

        protected void moveToOldestButton_Click(object sender, ImageClickEventArgs e)
        {
            List<Comic> comicServerList = cl.getComics();
            comicServerList = comicServerList.OrderByDescending(c => c.Date).ToList();
            Comic comic = comicServerList.Last();
            SetComic(comic);
        }

        protected void moveToMostRecenButton_Click(object sender, ImageClickEventArgs e)
        {
            List<Comic> comicServerList = cl.getComics();
            comicServerList = comicServerList.OrderByDescending(c => c.Date).ToList();
            Comic comic = comicServerList.First();
            SetComic(comic);
        }

        protected void moveForwardButton_Click(object sender, ImageClickEventArgs e)
        {
            List<Comic> comicServerList = cl.getComics();
            comicServerList = comicServerList.OrderByDescending(c => c.Date).ToList();
            int position = 0;
            foreach (var item in comicServerList)
            {
                if (comicTitle.Text == item.Name)
                {
                    position = comicServerList.FindIndex(c => c.Name == item.Name);
                }
            }
            if (position <= 0)
            {
                Comic comic = comicServerList[0];
                SetComic(comic);
            }
            else
            {
                Comic comic = comicServerList[position - 1];
                SetComic(comic);
            }
        }

        protected void moveBackButton_Click(object sender, ImageClickEventArgs e)
        {
            List<Comic> comicServerList = cl.getComics();
            comicServerList = comicServerList.OrderByDescending(c => c.Date).ToList();
            int position = 0;
            foreach (var item in comicServerList)
            {
                if (comicTitle.Text == item.Name)
                {
                    position = comicServerList.FindIndex(c => c.Name == item.Name);
                }
            }
            if (position >= comicServerList.Count)
            {
                Comic comic = comicServerList[comicServerList.Count - 1];
                SetComic(comic);
            }
            else
            {
                Comic comic = comicServerList[position + 1];
                SetComic(comic);
            }
        }
    }
}