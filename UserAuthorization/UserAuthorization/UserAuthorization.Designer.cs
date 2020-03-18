namespace UserAuthorization
{
    partial class UserAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAuthorization));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtProgramID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAuthority = new System.Windows.Forms.ComboBox();
            this.bttSearchProgramID = new System.Windows.Forms.Button();
            this.bttSearchUserID = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(75, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProgramID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(82, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authority";
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserID.Location = new System.Drawing.Point(145, 23);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(149, 20);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // txtProgramID
            // 
            this.txtProgramID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProgramID.Location = new System.Drawing.Point(145, 76);
            this.txtProgramID.MaxLength = 6;
            this.txtProgramID.Name = "txtProgramID";
            this.txtProgramID.ReadOnly = true;
            this.txtProgramID.Size = new System.Drawing.Size(149, 20);
            this.txtProgramID.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(563, 249);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtAuthority);
            this.groupBox1.Controls.Add(this.bttSearchProgramID);
            this.groupBox1.Controls.Add(this.bttSearchUserID);
            this.groupBox1.Controls.Add(this.bttClear);
            this.groupBox1.Controls.Add(this.bttAdd);
            this.groupBox1.Controls.Add(this.txtProgramID);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 137);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(145, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(202, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtAuthority
            // 
            this.txtAuthority.FormattingEnabled = true;
            this.txtAuthority.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.txtAuthority.Location = new System.Drawing.Point(145, 102);
            this.txtAuthority.Name = "txtAuthority";
            this.txtAuthority.Size = new System.Drawing.Size(100, 21);
            this.txtAuthority.TabIndex = 6;
            // 
            // bttSearchProgramID
            // 
            this.bttSearchProgramID.Image = global::UserAuthorization.Properties.Resources.ic_search_48px_1281;
            this.bttSearchProgramID.Location = new System.Drawing.Point(300, 74);
            this.bttSearchProgramID.Name = "bttSearchProgramID";
            this.bttSearchProgramID.Size = new System.Drawing.Size(22, 24);
            this.bttSearchProgramID.TabIndex = 5;
            this.bttSearchProgramID.UseVisualStyleBackColor = true;
            this.bttSearchProgramID.Click += new System.EventHandler(this.bttSearchProgramID_Click);
            // 
            // bttSearchUserID
            // 
            this.bttSearchUserID.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttSearchUserID.Image = global::UserAuthorization.Properties.Resources.ic_search_48px_1281;
            this.bttSearchUserID.Location = new System.Drawing.Point(300, 22);
            this.bttSearchUserID.Name = "bttSearchUserID";
            this.bttSearchUserID.Size = new System.Drawing.Size(23, 23);
            this.bttSearchUserID.TabIndex = 2;
            this.bttSearchUserID.UseVisualStyleBackColor = true;
            this.bttSearchUserID.Click += new System.EventHandler(this.bttSearchUserID_Click);
            // 
            // bttClear
            // 
            this.bttClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttClear.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClear.Image = global::UserAuthorization.Properties.Resources.vacuum_cleaner;
            this.bttClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttClear.Location = new System.Drawing.Point(422, 78);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(85, 39);
            this.bttClear.TabIndex = 8;
            this.bttClear.Text = "Clear";
            this.bttClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttAdd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.Image = global::UserAuthorization.Properties.Resources.file__2_;
            this.bttAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdd.Location = new System.Drawing.Point(422, 23);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(85, 39);
            this.bttAdd.TabIndex = 7;
            this.bttAdd.Text = "Add";
            this.bttAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserAuthorization.Properties.Resources.PST_PCL_l2;
            this.pictureBox1.Location = new System.Drawing.Point(46, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bttDelete
            // 
            this.bttDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttDelete.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.Image = global::UserAuthorization.Properties.Resources.garbage;
            this.bttDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttDelete.Location = new System.Drawing.Point(434, 462);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(85, 39);
            this.bttDelete.TabIndex = 9;
            this.bttDelete.Text = "Delete";
            this.bttDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // UserAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(587, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAuthorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtProgramID;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttSearchUserID;
        private System.Windows.Forms.Button bttSearchProgramID;
        private System.Windows.Forms.ComboBox txtAuthority;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

