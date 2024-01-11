namespace FreeStyleCafeSystemManagement
{
    partial class AddUsersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeStyleDataSet2 = new FreeStyleCafeSystemManagement.FreeStyleDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_role = new System.Windows.Forms.ComboBox();
            this.User_searchBtn = new System.Windows.Forms.Button();
            this.User_backBtn = new System.Windows.Forms.Button();
            this.User_clearBtn = new System.Windows.Forms.Button();
            this.User_deleteBtn = new System.Windows.Forms.Button();
            this.User_updateBtn = new System.Windows.Forms.Button();
            this.User_addBtn = new System.Windows.Forms.Button();
            this.User_password = new System.Windows.Forms.TextBox();
            this.User_name = new System.Windows.Forms.TextBox();
            this.User_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fsusersTableAdapter = new FreeStyleCafeSystemManagement.FreeStyleDataSet2TableAdapters.fsusersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 429);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fsusersBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(23, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 100;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1173, 371);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // fsusersBindingSource
            // 
            this.fsusersBindingSource.DataMember = "fsusers";
            this.fsusersBindingSource.DataSource = this.freeStyleDataSet2;
            // 
            // freeStyleDataSet2
            // 
            this.freeStyleDataSet2.DataSetName = "FreeStyleDataSet2";
            this.freeStyleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data of Users";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.User_role);
            this.panel2.Controls.Add(this.User_searchBtn);
            this.panel2.Controls.Add(this.User_backBtn);
            this.panel2.Controls.Add(this.User_clearBtn);
            this.panel2.Controls.Add(this.User_deleteBtn);
            this.panel2.Controls.Add(this.User_updateBtn);
            this.panel2.Controls.Add(this.User_addBtn);
            this.panel2.Controls.Add(this.User_password);
            this.panel2.Controls.Add(this.User_name);
            this.panel2.Controls.Add(this.User_id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 284);
            this.panel2.TabIndex = 2;
            // 
            // User_role
            // 
            this.User_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_role.FormattingEnabled = true;
            this.User_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.User_role.Location = new System.Drawing.Point(883, 46);
            this.User_role.Name = "User_role";
            this.User_role.Size = new System.Drawing.Size(215, 33);
            this.User_role.TabIndex = 28;
            // 
            // User_searchBtn
            // 
            this.User_searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.User_searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_searchBtn.ForeColor = System.Drawing.Color.White;
            this.User_searchBtn.Location = new System.Drawing.Point(486, 41);
            this.User_searchBtn.Name = "User_searchBtn";
            this.User_searchBtn.Size = new System.Drawing.Size(130, 40);
            this.User_searchBtn.TabIndex = 27;
            this.User_searchBtn.Text = "SEARCH";
            this.User_searchBtn.UseVisualStyleBackColor = false;
            this.User_searchBtn.Click += new System.EventHandler(this.User_searchBtn_Click);
            // 
            // User_backBtn
            // 
            this.User_backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.User_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_backBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_backBtn.ForeColor = System.Drawing.Color.White;
            this.User_backBtn.Location = new System.Drawing.Point(824, 208);
            this.User_backBtn.Name = "User_backBtn";
            this.User_backBtn.Size = new System.Drawing.Size(144, 57);
            this.User_backBtn.TabIndex = 24;
            this.User_backBtn.Text = "BackToMain";
            this.User_backBtn.UseVisualStyleBackColor = false;
            this.User_backBtn.Click += new System.EventHandler(this.User_backBtn_Click);
            // 
            // User_clearBtn
            // 
            this.User_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.User_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_clearBtn.ForeColor = System.Drawing.Color.White;
            this.User_clearBtn.Location = new System.Drawing.Point(670, 208);
            this.User_clearBtn.Name = "User_clearBtn";
            this.User_clearBtn.Size = new System.Drawing.Size(134, 57);
            this.User_clearBtn.TabIndex = 23;
            this.User_clearBtn.Text = "CLEAR";
            this.User_clearBtn.UseVisualStyleBackColor = false;
            this.User_clearBtn.Click += new System.EventHandler(this.User_clearBtn_Click);
            // 
            // User_deleteBtn
            // 
            this.User_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.User_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.User_deleteBtn.Location = new System.Drawing.Point(521, 208);
            this.User_deleteBtn.Name = "User_deleteBtn";
            this.User_deleteBtn.Size = new System.Drawing.Size(134, 57);
            this.User_deleteBtn.TabIndex = 22;
            this.User_deleteBtn.Text = "DELETE";
            this.User_deleteBtn.UseVisualStyleBackColor = false;
            this.User_deleteBtn.Click += new System.EventHandler(this.User_deleteBtn_Click);
            // 
            // User_updateBtn
            // 
            this.User_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.User_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_updateBtn.ForeColor = System.Drawing.Color.White;
            this.User_updateBtn.Location = new System.Drawing.Point(371, 208);
            this.User_updateBtn.Name = "User_updateBtn";
            this.User_updateBtn.Size = new System.Drawing.Size(134, 57);
            this.User_updateBtn.TabIndex = 21;
            this.User_updateBtn.Text = "UPDATE";
            this.User_updateBtn.UseVisualStyleBackColor = false;
            this.User_updateBtn.Click += new System.EventHandler(this.User_updateBtn_Click);
            // 
            // User_addBtn
            // 
            this.User_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.User_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_addBtn.ForeColor = System.Drawing.Color.White;
            this.User_addBtn.Location = new System.Drawing.Point(222, 208);
            this.User_addBtn.Name = "User_addBtn";
            this.User_addBtn.Size = new System.Drawing.Size(134, 57);
            this.User_addBtn.TabIndex = 20;
            this.User_addBtn.Text = "ADD";
            this.User_addBtn.UseVisualStyleBackColor = false;
            this.User_addBtn.Click += new System.EventHandler(this.User_addBtn_Click);
            // 
            // User_password
            // 
            this.User_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_password.Location = new System.Drawing.Point(883, 125);
            this.User_password.Name = "User_password";
            this.User_password.Size = new System.Drawing.Size(215, 30);
            this.User_password.TabIndex = 19;
            // 
            // User_name
            // 
            this.User_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_name.Location = new System.Drawing.Point(265, 125);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(215, 30);
            this.User_name.TabIndex = 17;
            // 
            // User_id
            // 
            this.User_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_id.Location = new System.Drawing.Point(265, 46);
            this.User_id.Name = "User_id";
            this.User_id.Size = new System.Drawing.Size(215, 30);
            this.User_id.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(729, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(777, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "User ID:";
            // 
            // fsusersTableAdapter
            // 
            this.fsusersTableAdapter.ClearBeforeFill = true;
            // 
            // AddUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsersForm";
            this.Load += new System.EventHandler(this.AddUsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button User_searchBtn;
        private System.Windows.Forms.Button User_backBtn;
        private System.Windows.Forms.Button User_clearBtn;
        private System.Windows.Forms.Button User_deleteBtn;
        private System.Windows.Forms.Button User_updateBtn;
        private System.Windows.Forms.Button User_addBtn;
        private System.Windows.Forms.TextBox User_password;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox User_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox User_role;
        private FreeStyleDataSet2 freeStyleDataSet2;
        private System.Windows.Forms.BindingSource fsusersBindingSource;
        private FreeStyleDataSet2TableAdapters.fsusersTableAdapter fsusersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}