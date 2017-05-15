using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using Newtonsoft.Json;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
//[System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string FileUpload(byte[] bytearray, Comic postName)
    {
        try
        {
            MemoryStream ms = new MemoryStream(bytearray);
            FileStream fs = new FileStream(HttpContext.Current.Server.MapPath("~/Images/") + postName.ImageName + ".jpg", FileMode.Create);
            ms.WriteTo(fs);
            ms.Close();
            fs.Close();
            fs.Dispose();
            using (StreamWriter sw = File.CreateText(HttpContext.Current.Server.MapPath("~/Posts/") + postName.Name + ".json"))
            {
                string writeString = JsonConvert.SerializeObject(postName);
                sw.WriteLine(writeString);
                sw.Close();
                sw.Dispose();
            }
            return postName.Name + " done uploading";
        }
        catch (Exception e)
        {
            return "Something went wrong with the upload " + e.Message;
        }
        
    }

    [WebMethod]
    public string DeletePost(Comic comic)
    {
        try
        {
            File.Delete(HttpContext.Current.Server.MapPath("~/Images/") + comic.ImageName + ".jpg");
            File.Delete(HttpContext.Current.Server.MapPath("~/Posts/") + comic.Name + ".json");
            return comic.Name + " has been deleted!";
        }
        catch (Exception e)
        {
            return "A problem has occured while deleting your file: \n" + e.Message;
        }
        

    }

    [WebMethod]
    public Comic[] PostAllAquire()
    {
        try
        {
            List<Comic> listOfComics = new List<Comic>();
            foreach (var file in Directory.GetFiles(System.Web.Hosting.HostingEnvironment.MapPath("~/Posts/"), "*.json"))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string toDeserialize = sr.ReadToEnd();
                    Comic comic = JsonConvert.DeserializeObject<Comic>(toDeserialize);
                    listOfComics.Add(comic);
                }
            }

            return listOfComics.ToArray();
        }
        catch (Exception e)
        {
            Comic comic = new Comic();
            comic.Name = e.Message;
            comic.BlogPost = e.StackTrace;
            Comic[] returnVal = { comic };
            return returnVal;
        }
    }

    [WebMethod]
    public string GetComicImage(string name)
    {
        try
        {
            return @"http://" + HttpContext.Current.Request.Url.Authority + @"/Images/" + name + ".jpg";
        }
        catch (Exception e)
        {
            return "Something went wrong " + e.Message;
        }
           
    }
    
}