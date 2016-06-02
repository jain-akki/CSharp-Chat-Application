namespace OnlineContact
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.picSmiley = new System.Windows.Forms.PictureBox();
            this.txtContact = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSmiley)).BeginInit();
            this.SuspendLayout();
            // 
            // picSmiley
            // 
            this.picSmiley.BackColor = System.Drawing.Color.White;
            this.picSmiley.Location = new System.Drawing.Point(0, 0);
            this.picSmiley.Name = "picSmiley";
            this.picSmiley.Size = new System.Drawing.Size(16, 16);
            this.picSmiley.TabIndex = 0;
            this.picSmiley.TabStop = false;
            this.picSmiley.DoubleClick += new System.EventHandler(this.picSmiley_DoubleClick);
            // 
            // txtContact
            // 
            this.txtContact.AutoSize = true;
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(24, 0);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(48, 15);
            this.txtContact.TabIndex = 1;
            this.txtContact.Text = "Contact";
            this.txtContact.DoubleClick += new System.EventHandler(this.txtContact_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Offline.png");
            this.imageList.Images.SetKeyName(1, "Online.png");
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.picSmiley);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(176, 16);
            ((System.ComponentModel.ISupportInitialize)(this.picSmiley)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSmiley;
        private System.Windows.Forms.Label txtContact;
        private System.Windows.Forms.ImageList imageList;
    }
}
