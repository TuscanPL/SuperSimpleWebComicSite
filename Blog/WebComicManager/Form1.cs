using WebComicManager.ComicDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Blog.ComicDatabase;

namespace WebComicManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            //Try to remove this
        }

        private void SumbitButton_Click(object sender, EventArgs e)
        {
            Comic comic = new Comic();
            comic.Name = nameBox.Text;
            comic.Author = AuthorBox.Text;
            comic.BlogPost = BlogPostTextBox.Text;
            comic.Date = DateTime.Now;
            comic.ImageName = nameBox.Text;
            UploadPost(PictureNameLabel.Text, comic);
        }

        private void ChooseComicPictureButton_Click(object sender, EventArgs e)
        {
            FileDialogComic.FileName = "";
            FileDialogComic.Title = "Open File";
            FileDialogComic.Filter = "All Files|*.*";
            FileDialogComic.InitialDirectory = "C:\\";
            FileDialogComic.ShowDialog();
            PictureNameLabel.Text = FileDialogComic.FileName;
        }

        private void UploadPost(string pictureLocation, Comic comic)
        {
            ComicDatabase.ServiceSoapClient ssc = new ComicDatabase.ServiceSoapClient();
            FileInfo fInfo = new FileInfo(pictureLocation);
            long numbytes = fInfo.Length;
            FileStream file = new FileStream(pictureLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(file);
            byte[] data = binaryReader.ReadBytes((int)numbytes);
            binaryReader.Close();
            string result = ssc.FileUpload(data, comic);

            MessageBox.Show(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DeleteForm_Click(object sender, EventArgs e)
        {
            Form2 deleteForm = new Form2();
            deleteForm.Show();
        }
    }
}
