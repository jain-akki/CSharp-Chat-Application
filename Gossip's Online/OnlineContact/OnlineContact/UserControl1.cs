using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineContact
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            picSmiley.Image = imageList.Images[0];
        }
        public UserControl1(string contact)
        {
            picSmiley.Image = imageList.Images[0];
            txtContact.Text = contact;
        }
        public bool online;
        public bool Online
        {
            get 
            {
                return online;
            }
            set 
            {
                online = value;
                if (value == true)
                {
                    picSmiley.Image = imageList.Images[1];
                }
                else 
                {
                    picSmiley.Image = imageList.Images[0];
                }
                picSmiley.Update();
                picSmiley.Refresh();
            }
        }
        public string Contact
        {
            get
            {
                return txtContact.Text;
            }
            set
            {
                txtContact.Text = value;
            }
        }

        private void picSmiley_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(new EventArgs());
        }

        private void txtContact_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(new EventArgs());
        }
    }
}
