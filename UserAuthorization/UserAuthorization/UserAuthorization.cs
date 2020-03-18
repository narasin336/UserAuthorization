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
    public partial class UserAuthorization : Form
    {
        int valErr = 0;
        //decimal varMaximumDay = 0;
      //  SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
       // SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");

        public UserAuthorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
            ClearData();
            this.ActiveControl = txtUserID;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            CheckError();
            if (valErr == 0)
            {
                string sql1 = "Insert Into UserAuthorization ( UserID,ProgramID,Authority) values( '" + txtUserID.Text + "', '" + txtProgramID.Text + "','" + txtAuthority.Text + "') ";
                OleDbCommand com1 = new OleDbCommand(sql1, conn);
                com1.ExecuteNonQuery();
                MessageBox.Show("Add completed");
                Showdata();
                ClearData();
            }
        }

        private void Showdata()
        {
            int varindex = 0;
            //int ixx = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[varindex].Name = "UserID";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ProgramID";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ProgramName";
            dataGridView1.Columns[varindex].Width = 220;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Authority";
            dataGridView1.Columns[varindex].Width = 100;

            string sql1 = "";
            sql1 = "Select * from UserAuthorization where UserID = '" + txtUserID.Text +"' order by ProgramID";
            OleDbCommand com1 = new OleDbCommand(sql1, conn);
            OleDbDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {

                string varProgramName = "";
                string sql = "Select * from ProgramMaster where ProgramID = '" + dr1["ProgramID"].ToString() + "'";
                OleDbCommand com = new OleDbCommand(sql, conn);
                OleDbDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    varProgramName = dr["Program"].ToString(); 
                }
                dr.Close();

                dataGridView1.Rows.Add(dr1["UserID"].ToString(), dr1["ProgramID"].ToString(), varProgramName, dr1["Authority"].ToString());
            }
            dr1.Close();
        }

        private void CheckError()
        {
            valErr = 0;
            if (txtUserID.Text.Trim() == "") { MessageBox.Show("please input UserID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtProgramID.Text.Trim() == "") { MessageBox.Show("please input ProgramID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtAuthority.Text.Trim() == "") { MessageBox.Show("please input Authority", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            string sql = "Select * from UserAuthorization where UserID = '" + txtUserID.Text + "' ";
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            //while (dr.Read())
            //{
                //MessageBox.Show("txtUserID have already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; break;
            //}
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            //txtUserID.Text = "";
            //txtUserName.Text = "";
            txtProgramID.Text = "";
            txtAuthority.Text = "";
            bttAdd.Enabled = true;
            bttDelete.Enabled = false;

            bttSearchProgramID.Enabled = true;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Trim() == "")
            { MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }

            if (MessageBox.Show("Do you want to delete the data ? " + txtUserID.Text , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Delete from UserAuthorization where UserID ='" + txtUserID.Text + "' and ProgramID = '" + txtProgramID.Text +"' ";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Delete completed");
                Showdata();
                ClearData();
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            Showdata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearData();
            txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
            txtProgramID.Text = dataGridView1.Rows[e.RowIndex].Cells["ProgramID"].Value.ToString();
            txtAuthority.Text = dataGridView1.Rows[e.RowIndex].Cells["Authority"].Value.ToString();

            txtUserID.ReadOnly = true;
            txtUserName.ReadOnly = true;
            txtProgramID.ReadOnly = true;
            bttAdd.Enabled = false;
            bttDelete.Enabled = true;
            bttSearchProgramID.Enabled = false;
        }
    
        private void bttSearchUserID_Click(object sender, EventArgs e)
        {
            SearchUserID WinD = new SearchUserID();
            WinD.ShowDialog();
            txtUserID.Text = MyGlobal.GlobalUserID;
            txtUserName.Text = MyGlobal.GlobalUserName;
            Showdata();
        }

        private void bttSearchProgramID_Click(object sender, EventArgs e)
        {
            SearchProgramID WinD = new SearchProgramID();
            WinD.ShowDialog();
            txtProgramID.Text = MyGlobal.GlobalProgramID;
            Showdata();
        }

        private void UserAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show("คุณต้องการจะปิดโปรแกรมหรือไม่ ?", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUserID.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
