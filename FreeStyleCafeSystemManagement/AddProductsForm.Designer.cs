namespace FreeStyleCafeSystemManagement
{
    partial class AddProductsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fsproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeStyleDataSet = new FreeStyleCafeSystemManagement.FreeStyleDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Product_backBtn = new System.Windows.Forms.Button();
            this.Product_clearBtn = new System.Windows.Forms.Button();
            this.Product_deleteBtn = new System.Windows.Forms.Button();
            this.Product_updateBtn = new System.Windows.Forms.Button();
            this.Product_addBtn = new System.Windows.Forms.Button();
            this.Product_qty = new System.Windows.Forms.TextBox();
            this.Product_price = new System.Windows.Forms.TextBox();
            this.Product_name = new System.Windows.Forms.TextBox();
            this.Product_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fsproductsTableAdapter = new FreeStyleCafeSystemManagement.FreeStyleDataSetTableAdapters.fsproductsTableAdapter();
            this.freeStyleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fsproductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.freeStyleDataSet1 = new FreeStyleCafeSystemManagement.FreeStyleDataSet1();
            this.fsproductsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fsproductsTableAdapter1 = new FreeStyleCafeSystemManagement.FreeStyleDataSet1TableAdapters.fsproductsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_searchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsproductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsproductsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 429);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.dateInsert});
            this.dataGridView1.DataSource = this.fsproductsBindingSource2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(23, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 371);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fsproductsBindingSource
            // 
            this.fsproductsBindingSource.DataMember = "fsproducts";
            this.fsproductsBindingSource.DataSource = this.freeStyleDataSet;
            // 
            // freeStyleDataSet
            // 
            this.freeStyleDataSet.DataSetName = "FreeStyleDataSet";
            this.freeStyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data of Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Product_searchBtn);
            this.panel2.Controls.Add(this.Product_backBtn);
            this.panel2.Controls.Add(this.Product_clearBtn);
            this.panel2.Controls.Add(this.Product_deleteBtn);
            this.panel2.Controls.Add(this.Product_updateBtn);
            this.panel2.Controls.Add(this.Product_addBtn);
            this.panel2.Controls.Add(this.Product_qty);
            this.panel2.Controls.Add(this.Product_price);
            this.panel2.Controls.Add(this.Product_name);
            this.panel2.Controls.Add(this.Product_id);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 284);
            this.panel2.TabIndex = 1;
            // 
            // Product_backBtn
            // 
            this.Product_backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Product_backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_backBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_backBtn.ForeColor = System.Drawing.Color.White;
            this.Product_backBtn.Location = new System.Drawing.Point(824, 208);
            this.Product_backBtn.Name = "Product_backBtn";
            this.Product_backBtn.Size = new System.Drawing.Size(144, 57);
            this.Product_backBtn.TabIndex = 24;
            this.Product_backBtn.Text = "BackToMain";
            this.Product_backBtn.UseVisualStyleBackColor = false;
            this.Product_backBtn.Click += new System.EventHandler(this.Product_backBtn_Click);
            // 
            // Product_clearBtn
            // 
            this.Product_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Product_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_clearBtn.ForeColor = System.Drawing.Color.White;
            this.Product_clearBtn.Location = new System.Drawing.Point(670, 208);
            this.Product_clearBtn.Name = "Product_clearBtn";
            this.Product_clearBtn.Size = new System.Drawing.Size(134, 57);
            this.Product_clearBtn.TabIndex = 23;
            this.Product_clearBtn.Text = "CLEAR";
            this.Product_clearBtn.UseVisualStyleBackColor = false;
            this.Product_clearBtn.Click += new System.EventHandler(this.Product_clearBtn_Click);
            // 
            // Product_deleteBtn
            // 
            this.Product_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Product_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_deleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.Product_deleteBtn.Location = new System.Drawing.Point(521, 208);
            this.Product_deleteBtn.Name = "Product_deleteBtn";
            this.Product_deleteBtn.Size = new System.Drawing.Size(134, 57);
            this.Product_deleteBtn.TabIndex = 22;
            this.Product_deleteBtn.Text = "DELETE";
            this.Product_deleteBtn.UseVisualStyleBackColor = false;
            this.Product_deleteBtn.Click += new System.EventHandler(this.Product_deleteBtn_Click);
            // 
            // Product_updateBtn
            // 
            this.Product_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Product_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_updateBtn.ForeColor = System.Drawing.Color.White;
            this.Product_updateBtn.Location = new System.Drawing.Point(371, 208);
            this.Product_updateBtn.Name = "Product_updateBtn";
            this.Product_updateBtn.Size = new System.Drawing.Size(134, 57);
            this.Product_updateBtn.TabIndex = 21;
            this.Product_updateBtn.Text = "UPDATE";
            this.Product_updateBtn.UseVisualStyleBackColor = false;
            this.Product_updateBtn.Click += new System.EventHandler(this.Product_updateBtn_Click);
            // 
            // Product_addBtn
            // 
            this.Product_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Product_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_addBtn.ForeColor = System.Drawing.Color.White;
            this.Product_addBtn.Location = new System.Drawing.Point(222, 208);
            this.Product_addBtn.Name = "Product_addBtn";
            this.Product_addBtn.Size = new System.Drawing.Size(134, 57);
            this.Product_addBtn.TabIndex = 20;
            this.Product_addBtn.Text = "ADD";
            this.Product_addBtn.UseVisualStyleBackColor = false;
            this.Product_addBtn.Click += new System.EventHandler(this.Product_addBtn_Click);
            // 
            // Product_qty
            // 
            this.Product_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_qty.Location = new System.Drawing.Point(883, 125);
            this.Product_qty.Name = "Product_qty";
            this.Product_qty.Size = new System.Drawing.Size(215, 30);
            this.Product_qty.TabIndex = 19;
            // 
            // Product_price
            // 
            this.Product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_price.Location = new System.Drawing.Point(883, 46);
            this.Product_price.Name = "Product_price";
            this.Product_price.Size = new System.Drawing.Size(215, 30);
            this.Product_price.TabIndex = 18;
            // 
            // Product_name
            // 
            this.Product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_name.Location = new System.Drawing.Point(265, 125);
            this.Product_name.Name = "Product_name";
            this.Product_name.Size = new System.Drawing.Size(215, 30);
            this.Product_name.TabIndex = 17;
            // 
            // Product_id
            // 
            this.Product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_id.Location = new System.Drawing.Point(265, 46);
            this.Product_id.Name = "Product_id";
            this.Product_id.Size = new System.Drawing.Size(215, 30);
            this.Product_id.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(798, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "QTY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(761, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price ($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product ID:";
            // 
            // fsproductsTableAdapter
            // 
            this.fsproductsTableAdapter.ClearBeforeFill = true;
            // 
            // freeStyleDataSetBindingSource
            // 
            this.freeStyleDataSetBindingSource.DataSource = this.freeStyleDataSet;
            this.freeStyleDataSetBindingSource.Position = 0;
            // 
            // fsproductsBindingSource1
            // 
            this.fsproductsBindingSource1.DataMember = "fsproducts";
            this.fsproductsBindingSource1.DataSource = this.freeStyleDataSetBindingSource;
            // 
            // freeStyleDataSet1
            // 
            this.freeStyleDataSet1.DataSetName = "FreeStyleDataSet1";
            this.freeStyleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fsproductsBindingSource2
            // 
            this.fsproductsBindingSource2.DataMember = "fsproducts";
            this.fsproductsBindingSource2.DataSource = this.freeStyleDataSet1;
            // 
            // fsproductsTableAdapter1
            // 
            this.fsproductsTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // dateInsert
            // 
            this.dateInsert.DataPropertyName = "dateInsert";
            this.dateInsert.HeaderText = "dateInsert";
            this.dateInsert.MinimumWidth = 6;
            this.dateInsert.Name = "dateInsert";
            // 
            // Product_searchBtn
            // 
            this.Product_searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.Product_searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_searchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_searchBtn.ForeColor = System.Drawing.Color.White;
            this.Product_searchBtn.Location = new System.Drawing.Point(486, 41);
            this.Product_searchBtn.Name = "Product_searchBtn";
            this.Product_searchBtn.Size = new System.Drawing.Size(130, 40);
            this.Product_searchBtn.TabIndex = 27;
            this.Product_searchBtn.Text = "SEARCH";
            this.Product_searchBtn.UseVisualStyleBackColor = false;
            this.Product_searchBtn.Click += new System.EventHandler(this.Product_searchBtn_Click);
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductsForm";
            this.Load += new System.EventHandler(this.AddProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsproductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeStyleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsproductsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Product_backBtn;
        private System.Windows.Forms.Button Product_clearBtn;
        private System.Windows.Forms.Button Product_deleteBtn;
        private System.Windows.Forms.Button Product_updateBtn;
        private System.Windows.Forms.Button Product_addBtn;
        private System.Windows.Forms.TextBox Product_qty;
        private System.Windows.Forms.TextBox Product_price;
        private System.Windows.Forms.TextBox Product_name;
        private System.Windows.Forms.TextBox Product_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FreeStyleDataSet freeStyleDataSet;
        private System.Windows.Forms.BindingSource fsproductsBindingSource;
        private FreeStyleDataSetTableAdapters.fsproductsTableAdapter fsproductsTableAdapter;
        private System.Windows.Forms.BindingSource fsproductsBindingSource1;
        private System.Windows.Forms.BindingSource freeStyleDataSetBindingSource;
        private FreeStyleDataSet1 freeStyleDataSet1;
        private System.Windows.Forms.BindingSource fsproductsBindingSource2;
        private FreeStyleDataSet1TableAdapters.fsproductsTableAdapter fsproductsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInsert;
        private System.Windows.Forms.Button Product_searchBtn;
    }
}