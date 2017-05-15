namespace WebComicManager
{
    partial class Form2
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
            this.ComicListControl = new System.Windows.Forms.ListBox();
            this.ComicName = new System.Windows.Forms.Label();
            this.ComicAuthor = new System.Windows.Forms.Label();
            this.ComicDate = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComicListControl
            // 
            this.ComicListControl.FormattingEnabled = true;
            this.ComicListControl.Location = new System.Drawing.Point(13, 13);
            this.ComicListControl.Name = "ComicListControl";
            this.ComicListControl.Size = new System.Drawing.Size(225, 264);
            this.ComicListControl.TabIndex = 0;
            this.ComicListControl.SelectedIndexChanged += new System.EventHandler(this.ComicListControl_SelectedIndexChanged);
            // 
            // ComicName
            // 
            this.ComicName.AutoSize = true;
            this.ComicName.Location = new System.Drawing.Point(244, 13);
            this.ComicName.Name = "ComicName";
            this.ComicName.Size = new System.Drawing.Size(0, 13);
            this.ComicName.TabIndex = 1;
            // 
            // ComicAuthor
            // 
            this.ComicAuthor.AutoSize = true;
            this.ComicAuthor.Location = new System.Drawing.Point(244, 26);
            this.ComicAuthor.Name = "ComicAuthor";
            this.ComicAuthor.Size = new System.Drawing.Size(0, 13);
            this.ComicAuthor.TabIndex = 2;
            // 
            // ComicDate
            // 
            this.ComicDate.AutoSize = true;
            this.ComicDate.Location = new System.Drawing.Point(244, 39);
            this.ComicDate.Name = "ComicDate";
            this.ComicDate.Size = new System.Drawing.Size(0, 13);
            this.ComicDate.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(13, 284);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 319);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ComicDate);
            this.Controls.Add(this.ComicAuthor);
            this.Controls.Add(this.ComicName);
            this.Controls.Add(this.ComicListControl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ComicListControl;
        private System.Windows.Forms.Label ComicName;
        private System.Windows.Forms.Label ComicAuthor;
        private System.Windows.Forms.Label ComicDate;
        private System.Windows.Forms.Button DeleteButton;
    }
}