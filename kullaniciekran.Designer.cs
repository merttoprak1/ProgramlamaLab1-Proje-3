
namespace prolabodev
{
    partial class kullaniciekran
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sarkiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarkiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinlenmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarkilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitDataSet1 = new prolabodev.KayitDataSet1();
            this.sarkilarTableAdapter = new prolabodev.KayitDataSet1TableAdapters.SarkilarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sarkiIdDataGridViewTextBoxColumn,
            this.sarkiAdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.sanatciIdDataGridViewTextBoxColumn,
            this.albumIdDataGridViewTextBoxColumn,
            this.turIdDataGridViewTextBoxColumn,
            this.sureDataGridViewTextBoxColumn,
            this.dinlenmeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sarkilarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(876, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // sarkiIdDataGridViewTextBoxColumn
            // 
            this.sarkiIdDataGridViewTextBoxColumn.DataPropertyName = "sarkiId";
            this.sarkiIdDataGridViewTextBoxColumn.HeaderText = "sarkiId";
            this.sarkiIdDataGridViewTextBoxColumn.Name = "sarkiIdDataGridViewTextBoxColumn";
            this.sarkiIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sarkiAdDataGridViewTextBoxColumn
            // 
            this.sarkiAdDataGridViewTextBoxColumn.DataPropertyName = "sarkiAd";
            this.sarkiAdDataGridViewTextBoxColumn.HeaderText = "sarkiAd";
            this.sarkiAdDataGridViewTextBoxColumn.Name = "sarkiAdDataGridViewTextBoxColumn";
            this.sarkiAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sanatciIdDataGridViewTextBoxColumn
            // 
            this.sanatciIdDataGridViewTextBoxColumn.DataPropertyName = "sanatciId";
            this.sanatciIdDataGridViewTextBoxColumn.HeaderText = "sanatciId";
            this.sanatciIdDataGridViewTextBoxColumn.Name = "sanatciIdDataGridViewTextBoxColumn";
            this.sanatciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "albumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "albumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            this.albumIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turIdDataGridViewTextBoxColumn
            // 
            this.turIdDataGridViewTextBoxColumn.DataPropertyName = "turId";
            this.turIdDataGridViewTextBoxColumn.HeaderText = "turId";
            this.turIdDataGridViewTextBoxColumn.Name = "turIdDataGridViewTextBoxColumn";
            this.turIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sureDataGridViewTextBoxColumn
            // 
            this.sureDataGridViewTextBoxColumn.DataPropertyName = "sure";
            this.sureDataGridViewTextBoxColumn.HeaderText = "sure";
            this.sureDataGridViewTextBoxColumn.Name = "sureDataGridViewTextBoxColumn";
            this.sureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dinlenmeDataGridViewTextBoxColumn
            // 
            this.dinlenmeDataGridViewTextBoxColumn.DataPropertyName = "dinlenme";
            this.dinlenmeDataGridViewTextBoxColumn.HeaderText = "dinlenme";
            this.dinlenmeDataGridViewTextBoxColumn.Name = "dinlenmeDataGridViewTextBoxColumn";
            this.dinlenmeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sarkilarBindingSource
            // 
            this.sarkilarBindingSource.DataMember = "Sarkilar";
            this.sarkilarBindingSource.DataSource = this.kayitDataSet1;
            // 
            // kayitDataSet1
            // 
            this.kayitDataSet1.DataSetName = "KayitDataSet1";
            this.kayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sarkilarTableAdapter
            // 
            this.sarkilarTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 522);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullaniciekran";
            this.Text = "Şarkılar";
            this.Load += new System.EventHandler(this.kullaniciekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KayitDataSet1 kayitDataSet1;
        private System.Windows.Forms.BindingSource sarkilarBindingSource;
        private KayitDataSet1TableAdapters.SarkilarTableAdapter sarkilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarkiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarkiAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinlenmeDataGridViewTextBoxColumn;
    }
}