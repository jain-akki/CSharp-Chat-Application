namespace InstantChat
{
    partial class OfflineMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineMessages));
            this.rtbOfflineMessages = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOfflineMessages
            // 
            this.rtbOfflineMessages.BackColor = System.Drawing.Color.White;
            this.rtbOfflineMessages.Location = new System.Drawing.Point(12, 12);
            this.rtbOfflineMessages.Name = "rtbOfflineMessages";
            this.rtbOfflineMessages.Size = new System.Drawing.Size(550, 232);
            this.rtbOfflineMessages.TabIndex = 1;
            this.rtbOfflineMessages.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(467, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // OfflineMessages
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(574, 285);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rtbOfflineMessages);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OfflineMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline Messages";
            this.Load += new System.EventHandler(this.OfflineMessages_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.RichTextBox rtbOfflineMessages;
    }
}