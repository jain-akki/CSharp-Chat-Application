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
    public partial class OfflineMessages : Form
    {
        private SqlConnection con;
        private DataSet myDataSet;
        private SqlDataAdapter da;
        public OfflineMessages()
        {
            InitializeComponent();
            con = new SqlConnection(TempClass.connectionString);
        }

        private void OfflineMessages_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "Select * From tbOfflineUserMessage Where ToLoginName=@tologinname";
            SqlCommand SqlCommand1 = con.CreateCommand();
            SqlCommand1.CommandText = sql;
            int res;
            SqlCommand1.Parameters.Add("@tologinname", SqlDbType.VarChar, 100);
            SqlCommand1.Parameters[0].Value = TempClass.username;
            da = new SqlDataAdapter();
            da.SelectCommand = SqlCommand1;
            myDataSet = new System.Data.DataSet();
            res = da.Fill(myDataSet, "tbOfflineUserMessage");
            for(int i=0;i<res;i++)
            {
                string from = myDataSet.Tables["tbOfflineUserMessage"].Rows[i]["FromLoginName"].ToString();
                string msg = myDataSet.Tables["tbOfflineUserMessage"].Rows[i]["Message"].ToString();
                rtbOfflineMessages.AppendText(from + " : ");
                rtbOfflineMessages.AppendText(msg + " \n");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlCommand SqlCommand1 = con.CreateCommand();
            SqlCommand1.CommandText = "Delete From tbOfflineUserMessage Where ToLoginName=@tologinname";
            int res;
            SqlCommand1.Parameters.Add("@tologinname", SqlDbType.VarChar, 100);
            SqlCommand1.Parameters[0].Value = TempClass.username;
            res = SqlCommand1.ExecuteNonQuery();
            con.Close();
            this.Hide();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            base.OnClosing(e);
            btnOK_Click(this, e);
        }
    }
}
