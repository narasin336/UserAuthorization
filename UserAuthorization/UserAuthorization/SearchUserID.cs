using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace UserAuthorization
{
    public partial class SearchUserID : Form
    {
        int valErr = 0;
      //  SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        //SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");

        public SearchUserID()
        {
            InitializeComponent();
        }

        private void SearchUserID_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
            this.ActiveControl = txtSearchUsername;
        }
        private void Showdata()
        {
            int varindex = 0;


            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[varindex].Name = "UserID";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "UserName";
            dataGridView1.Columns[varindex].Width = 140;

            string sql1 = "";
            if (txtSearchUsername.Text == "")
            {
                sql1 = "Select * from UserMaster order by UserID  ";
            }
            else { sql1 = "Select * from UserMaster where UserName like '%' + '" +txtSearchUsername.Text + "' + '%' or UserID like '%' + '" + txtSearchUsername.Text + "' + '%'  order by UserID  "; }
            OleDbCommand com1 = new OleDbCommand(sql1, conn);
            OleDbDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                dataGridView1.Rows.Add(dr1["UserID"].ToString(), dr1["UserName"].ToString());
            }
            dr1.Close();
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MyGlobal.GlobalUserID = dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
            MyGlobal.GlobalUserName = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            this.Close();
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            Showdata();
        }
    }


}
