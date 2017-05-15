namespace WebComicManager
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.BlogPostLabel = new System.Windows.Forms.Label();
            this.BlogPostTextBox = new System.Windows.Forms.RichTextBox();
            this.PictureNameLabel = new System.Windows.Forms.Label();
            this.ChooseComicPictureButton = new System.Windows.Forms.Button();
            this.SumbitButton = new System.Windows.Forms.Button();
            this.FileDialogComic = new System.Windows.Forms.OpenFileDialog();
            this.DeleteForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 23);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 4);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(89, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Webcomic Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // AuthorBox
            // 
            this.AuthorBox.Location = new System.Drawing.Point(118, 23);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorBox.TabIndex = 2;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(115, 4);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author";
            // 
            // BlogPostLabel
            // 
            this.BlogPostLabel.AutoSize = true;
            this.BlogPostLabel.Location = new System.Drawing.Point(16, 50);
            this.BlogPostLabel.Name = "BlogPostLabel";
            this.BlogPostLabel.Size = new System.Drawing.Size(52, 13);
            this.BlogPostLabel.TabIndex = 4;
            this.BlogPostLabel.Text = "Blog Post";
            // 
            // BlogPostTextBox
            // 
            this.BlogPostTextBox.Location = new System.Drawing.Point(12, 67);
            this.BlogPostTextBox.Name = "BlogPostTextBox";
            this.BlogPostTextBox.Size = new System.Drawing.Size(342, 196);
            this.BlogPostTextBox.TabIndex = 5;
            this.BlogPostTextBox.Text = "";
            // 
            // PictureNameLabel
            // 
            this.PictureNameLabel.AutoSize = true;
            this.PictureNameLabel.Location = new System.Drawing.Point(9, 271);
            this.PictureNameLabel.Name = "PictureNameLabel";
            this.PictureNameLabel.Size = new System.Drawing.Size(91, 13);
            this.PictureNameLabel.TabIndex = 6;
            this.PictureNameLabel.Text = "No picture loaded";
            // 
            // ChooseComicPictureButton
            // 
            this.ChooseComicPictureButton.Location = new System.Drawing.Point(12, 287);
            this.ChooseComicPictureButton.Name = "ChooseComicPictureButton";
            this.ChooseComicPictureButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseComicPictureButton.TabIndex = 7;
            this.ChooseComicPictureButton.Text = "Choose Comic";
            this.ChooseComicPictureButton.UseVisualStyleBackColor = true;
            this.ChooseComicPictureButton.Click += new System.EventHandler(this.ChooseComicPictureButton_Click);
            // 
            // SumbitButton
            // 
            this.SumbitButton.Location = new System.Drawing.Point(279, 287);
            this.SumbitButton.Name = "SumbitButton";
            this.SumbitButton.Size = new System.Drawing.Size(75, 23);
            this.SumbitButton.TabIndex = 8;
            this.SumbitButton.Text = "Submit";
            this.SumbitButton.UseVisualStyleBackColor = true;
            this.SumbitButton.Click += new System.EventHandler(this.SumbitButton_Click);
            // 
            // FileDialogComic
            // 
            this.FileDialogComic.FileName = "FileDialogComic";
            // 
            // DeleteForm
            // 
            this.DeleteForm.Location = new System.Drawing.Point(278, 23);
            this.DeleteForm.Name = "DeleteForm";
            this.DeleteForm.Size = new System.Drawing.Size(75, 23);
            this.DeleteForm.TabIndex = 9;
            this.DeleteForm.Text = "Delete";
            this.DeleteForm.UseVisualStyleBackColor = true;
            this.DeleteForm.Click += new System.EventHandler(this.DeleteForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 318);
            this.Controls.Add(this.DeleteForm);
            this.Controls.Add(this.SumbitButton);
            this.Controls.Add(this.ChooseComicPictureButton);
            this.Controls.Add(this.PictureNameLabel);
            this.Controls.Add(this.BlogPostTextBox);
            this.Controls.Add(this.BlogPostLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label BlogPostLabel;
        private System.Windows.Forms.RichTextBox BlogPostTextBox;
        private System.Windows.Forms.Label PictureNameLabel;
        private System.Windows.Forms.Button ChooseComicPictureButton;
        private System.Windows.Forms.Button SumbitButton;
        private System.Windows.Forms.OpenFileDialog FileDialogComic;
        private System.Windows.Forms.Button DeleteForm;
    }
}

