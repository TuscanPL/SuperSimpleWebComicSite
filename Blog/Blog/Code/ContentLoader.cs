using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using Blog.ComicDatabase;

namespace Blog.Code
{
    public class ContentLoader
    {
        public ServiceSoapClient ComicDatabase = new ServiceSoapClient();
        public List<Comic> getComics()
        {
            Comic[] listOfComics = ComicDatabase.PostAllAquire();

            return listOfComics.ToList();
        }

        public Comic getComic(string name)
        {
            List<Comic> comics = getComics();
            Comic returnComic = new Comic();
            foreach (var comic in comics)
            {
                if (name == comic.Name)
                {
                    returnComic = comic;
                }
            }
            return returnComic;
        }

        public Comic getComic()
        {
            List<Comic> comics = getComics();
            List<DateTime> dt = new List<DateTime>();
            DateTime date = new DateTime();
            foreach (var comic in comics)
            {
                dt.Add(comic.Date);
            }
            date = dt.Max();
            Comic returnComic = new Comic();
            foreach (var comic in comics)
            {
                if (date == comic.Date)
                {
                    returnComic = comic;
                }
            }

            return returnComic;
        }

        public string GetImage(string name)
        {
            return ComicDatabase.GetComicImage(name); 
        }
    }
}