namespace KN_Auto_Trading_Car_Sale
{
    partial class customer_viwe_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_viwe_delete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cid_cmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del_btn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.srch_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.kN_Auto_Trading_PVT_Ltd_dbDataSet = new KN_Auto_Trading_Car_Sale.KN_Auto_Trading_PVT_Ltd_dbDataSet();
            this.customertblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_tblTableAdapter = new KN_Auto_Trading_Car_Sale.KN_Auto_Trading_PVT_Ltd_dbDataSetTableAdapters.customer_tblTableAdapter();
            this.kN_Auto_Trading_PVT_Ltd_dbDataSet1 = new KN_Auto_Trading_Car_Sale.KN_Auto_Trading_PVT_Ltd_dbDataSet1();
            this.customertblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customer_tblTableAdapter1 = new KN_Auto_Trading_Car_Sale.KN_Auto_Trading_PVT_Ltd_dbDataSet1TableAdapters.customer_tblTableAdapter();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kN_Auto_Trading_PVT_Ltd_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kN_Auto_Trading_PVT_Ltd_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 14);
            this.panel1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 40);
            this.label5.TabIndex = 40;
            this.label5.Text = "Customer Viwe";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cid_cmb);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.del_btn);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.closebtn);
            this.groupBox2.Controls.Add(this.srch_btn);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Location = new System.Drawing.Point(20, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1159, 581);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Customer Details";
            // 
            // cid_cmb
            // 
            this.cid_cmb.DataSource = this.customertblBindingSource;
            this.cid_cmb.DisplayMember = "customer_id";
            this.cid_cmb.FormattingEnabled = true;
            this.cid_cmb.Location = new System.Drawing.Point(181, 60);
            this.cid_cmb.Name = "cid_cmb";
            this.cid_cmb.Size = new System.Drawing.Size(142, 27);
            this.cid_cmb.TabIndex = 108;
            this.cid_cmb.ValueMember = "customer_id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customertblBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(31, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 363);
            this.dataGridView1.TabIndex = 107;
            // 
            // del_btn
            // 
            this.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Lucida Sans", 8F);
            this.del_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.del_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.del_btn.Location = new System.Drawing.Point(473, 59);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(100, 28);
            this.del_btn.TabIndex = 106;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Snow;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(27, 60);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 23);
            this.label20.TabIndex = 104;
            this.label20.Text = "Customer ID";
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Lucida Sans", 8F);
            this.closebtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.closebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closebtn.Location = new System.Drawing.Point(595, 59);
            this.closebtn.Margin = new System.Windows.Forms.Padding(4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(100, 28);
            this.closebtn.TabIndex = 87;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // srch_btn
            // 
            this.srch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.srch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srch_btn.Font = new System.Drawing.Font("Lucida Sans", 8F);
            this.srch_btn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.srch_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.srch_btn.Location = new System.Drawing.Point(348, 59);
            this.srch_btn.Margin = new System.Windows.Forms.Padding(4);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(100, 28);
            this.srch_btn.TabIndex = 86;
            this.srch_btn.Text = "Search";
            this.srch_btn.UseVisualStyleBackColor = true;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // kN_Auto_Trading_PVT_Ltd_dbDataSet
            // 
            this.kN_Auto_Trading_PVT_Ltd_dbDataSet.DataSetName = "KN_Auto_Trading_PVT_Ltd_dbDataSet";
            this.kN_Auto_Trading_PVT_Ltd_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customertblBindingSource
            // 
            this.customertblBindingSource.DataMember = "customer_tbl";
            this.customertblBindingSource.DataSource = this.kN_Auto_Trading_PVT_Ltd_dbDataSet;
            // 
            // customer_tblTableAdapter
            // 
            this.customer_tblTableAdapter.ClearBeforeFill = true;
            // 
            // kN_Auto_Trading_PVT_Ltd_dbDataSet1
            // 
            this.kN_Auto_Trading_PVT_Ltd_dbDataSet1.DataSetName = "KN_Auto_Trading_PVT_Ltd_dbDataSet1";
            this.kN_Auto_Trading_PVT_Ltd_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customertblBindingSource1
            // 
            this.customertblBindingSource1.DataMember = "customer_tbl";
            this.customertblBindingSource1.DataSource = this.kN_Auto_Trading_PVT_Ltd_dbDataSet1;
            // 
            // customer_tblTableAdapter1
            // 
            this.customer_tblTableAdapter1.ClearBeforeFill = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            this.nicDataGridViewTextBoxColumn.ReadOnly = true;
            this.nicDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // customer_viwe_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1192, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer_viwe_delete";
            this.Text = "customer_viwe_delete";
            this.Load += new System.EventHandler(this.customer_viwe_delete_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kN_Auto_Trading_PVT_Ltd_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kN_Auto_Trading_PVT_Ltd_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button srch_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cid_cmb;
        private KN_Auto_Trading_PVT_Ltd_dbDataSet kN_Auto_Trading_PVT_Ltd_dbDataSet;
        private System.Windows.Forms.BindingSource customertblBindingSource;
        private KN_Auto_Trading_PVT_Ltd_dbDataSetTableAdapters.customer_tblTableAdapter customer_tblTableAdapter;
        private KN_Auto_Trading_PVT_Ltd_dbDataSet1 kN_Auto_Trading_PVT_Ltd_dbDataSet1;
        private System.Windows.Forms.BindingSource customertblBindingSource1;
        private KN_Auto_Trading_PVT_Ltd_dbDataSet1TableAdapters.customer_tblTableAdapter customer_tblTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}