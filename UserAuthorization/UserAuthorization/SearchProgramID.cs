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
    public partial class SearchProgramID : Form
    {

        //        SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        // SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");

        public SearchProgramID()
        {
            InitializeComponent();
        }

        private void SearchProgramID_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
            this.ActiveControl = txtSearchProgram;
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[varindex].Name = "ProgramID";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Program_Name";
            dataGridView1.Columns[varindex].Width = 140;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Program_Description";
            dataGridView1.Columns[varindex].Width = 250;

            string sql1 = "";
            if (txtSearchProgram.Text == "")
            {
                sql1 = "Select * from ProgramMaster order by ProgramID  ";
            }
            else { sql1 = "Select * from ProgramMaster where ProgramID like '%' + '" +txtSearchProgram.Text + "' + '%' or Program like '%' + '" + txtSearchProgram.Text + "' + '%' order by ProgramID  "; }
            OleDbCommand com1 = new OleDbCommand(sql1, conn);
            OleDbDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                dataGridView1.Rows.Add(dr1["ProgramID"].ToString(), dr1["Program"].ToString(), dr1["ProgramDescription"].ToString());
            }
            dr1.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MyGlobal.GlobalProgramID = dataGridView1.Rows[e.RowIndex].Cells["ProgramID"].Value.ToString();
            this.Close();
        }     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Showdata();
        }
    }
}
