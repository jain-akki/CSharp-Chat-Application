using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InstantChat
{
    public partial class AllUsers : Form
    {
        SqlConnection con;
        SqlCommand myCommand, SqlCommand1;
        DataSet myDataSet;
        SqlDataAdapter myDataAdapter;
        bool validUser1 = false;
        public AllUsers()
        {
            InitializeComponent();
            ToolTip1.SetToolTip(btnFirst,"First");
            ToolTip1.SetToolTip(btnPrevious, "Previous");
            ToolTip1.SetToolTip(btnNext, "Next");
            ToolTip1.SetToolTip(btnLast, "Last");
            con = new SqlConnection(TempClass.connectionString);
            con.Open();
            myDataSet = new DataSet();
            myCommand = new SqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = "Select * From tbCreateAccount Where loginName !='admin' OR loginName!='Admin' OR loginName!='ADMIN'";
            myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;
            myDataAdapter.TableMappings.Add("Table","tbCreateAccount");
            myDataAdapter.Fill(myDataSet);
            txtLoginName.DataBindings.Add("Text", myDataSet, "tbCreateAccount.loginName");
            txtFirstName.DataBindings.Add("Text", myDataSet, "tbCreateAccount.firstName");
            txtLastName.DataBindings.Add("Text", myDataSet, "tbCreateAccount.lastName");
            txtPwd.DataBindings.Add("Text", myDataSet, "tbCreateAccount.passwd");
            txtGender.DataBindings.Add("Text", myDataSet, "tbCreateAccount.gender");
            txtType.DataBindings.Add("Text", myDataSet, "tbCreateAccount.type");
            labelPosition.Text = Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Position + 1) + "/" +
                Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Count);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource=myDataSet.Tables["tbCreateAccount"].DefaultView;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource = null;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[myDataSet, "tbCreateAccount"].Position = 0;
            labelPosition.Text = Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Position + 1)+"/"+
                Convert.ToString(this.BindingContext[myDataSet,"tbCreateAccount"].Count);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.BindingContext[myDataSet, "tbCreateAccount"].Position = (this.BindingContext[myDataSet, "tbCreateAccount"].Position - 1);
            labelPosition.Text = Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Position + 1) + "/" +
                Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Count);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[myDataSet, "tbCreateAccount"].Position = (this.BindingContext[myDataSet, "tbCreateAccount"].Position + 1);
            labelPosition.Text = Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Position + 1) + "/" +
                Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Count);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[myDataSet, "tbCreateAccount"].Position = (this.BindingContext[myDataSet, "tbCreateAccount"].Count - 1);
            labelPosition.Text = Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Position + 1) + "/" +
                Convert.ToString(this.BindingContext[myDataSet, "tbCreateAccount"].Count);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand1 = con.CreateCommand();
                SqlCommand1.CommandText = "Delete From tbAddContact Where login=@loginname";
                SqlCommand1.Parameters.Add("@loginname", SqlDbType.VarChar, 100);
                SqlCommand1.Parameters[0].Value = TempClass.username;
                SqlCommand1.ExecuteNonQuery();
                SqlDataAdapter adp4 = new SqlDataAdapter("Select * From tbContactList", con);
                DataSet ds4 = new DataSet();
                adp4.Fill(ds4, "tbContactList");
                if (ds4.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds4.Tables[0].Rows)
                    {
                        if ((dr["loginName"].ToString() == TempClass.username) && (dr["userStatus"].ToString() == "Online"))
                        {
                            validUser1 = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (validUser1 == true)
                {
                    SqlCommand SqlCommand2 = con.CreateCommand();
                    SqlCommand2.CommandText = "Update tbContactList Set userStatus=@userstatus Where loginName=@username";
                    SqlCommand2.Parameters.Add("@userstatus", SqlDbType.VarChar, 10);
                    SqlCommand2.Parameters.Add("@username", SqlDbType.VarChar, 100);
                    SqlCommand2.Parameters[0].Value = "Offline";
                    SqlCommand2.Parameters[1].Value = TempClass.username;
                    SqlCommand2.ExecuteNonQuery();
                    Application.Exit();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("User cannot logout");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            TempClass.admin.Show();
            base.OnClosing(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TempClass.admin.Show();
        }
    }
}
