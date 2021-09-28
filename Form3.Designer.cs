
namespace prolabodev
{
    partial class Form3
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
            this.kayitDataSet2 = new prolabodev.KayitDataSet2();
            this.sarkilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sarkilarTableAdapter = new prolabodev.KayitDataSet2TableAdapters.SarkilarTableAdapter();
            this.sarkiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarkiAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinlenmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 574);
            this.dataGridView1.TabIndex = 0;
            // 
            // kayitDataSet2
            // 
            this.kayitDataSet2.DataSetName = "KayitDataSet2";
            this.kayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sarkilarBindingSource
            // 
            this.sarkilarBindingSource.DataMember = "Sarkilar";
            this.sarkilarBindingSource.DataSource = this.kayitDataSet2;
            // 
            // sarkilarTableAdapter
            // 
            this.sarkilarTableAdapter.ClearBeforeFill = true;
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
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // sanatciIdDataGridViewTextBoxColumn
            // 
            this.sanatciIdDataGridViewTextBoxColumn.DataPropertyName = "sanatciId";
            this.sanatciIdDataGridViewTextBoxColumn.HeaderText = "sanatciId";
            this.sanatciIdDataGridViewTextBoxColumn.Name = "sanatciIdDataGridViewTextBoxColumn";
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "albumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "albumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            // 
            // turIdDataGridViewTextBoxColumn
            // 
            this.turIdDataGridViewTextBoxColumn.DataPropertyName = "turId";
            this.turIdDataGridViewTextBoxColumn.HeaderText = "turId";
            this.turIdDataGridViewTextBoxColumn.Name = "turIdDataGridViewTextBoxColumn";
            // 
            // sureDataGridViewTextBoxColumn
            // 
            this.sureDataGridViewTextBoxColumn.DataPropertyName = "sure";
            this.sureDataGridViewTextBoxColumn.HeaderText = "sure";
            this.sureDataGridViewTextBoxColumn.Name = "sureDataGridViewTextBoxColumn";
            // 
            // dinlenmeDataGridViewTextBoxColumn
            // 
            this.dinlenmeDataGridViewTextBoxColumn.DataPropertyName = "dinlenme";
            this.dinlenmeDataGridViewTextBoxColumn.HeaderText = "dinlenme";
            this.dinlenmeDataGridViewTextBoxColumn.Name = "dinlenmeDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 574);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KayitDataSet2 kayitDataSet2;
        private System.Windows.Forms.BindingSource sarkilarBindingSource;
        private KayitDataSet2TableAdapters.SarkilarTableAdapter sarkilarTableAdapter;
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