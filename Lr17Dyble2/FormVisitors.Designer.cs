namespace Lr17Dyble2
{
    partial class FormVisitors
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
            this.dataGridViewVisitors = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautysaloonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautysaloonDataSet = new Lr17Dyble2.beautysaloonDataSet();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable2TableAdapter();
            this.dataTable1TableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable1TableAdapter();
            this.buttonInsertIntoVisitors = new System.Windows.Forms.Button();
            this.IdVisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisitors
            // 
            this.dataGridViewVisitors.AutoGenerateColumns = false;
            this.dataGridViewVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVisitor,
            this.fIODataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridViewVisitors.DataSource = this.dataTable1BindingSource;
            this.dataGridViewVisitors.Location = new System.Drawing.Point(220, 41);
            this.dataGridViewVisitors.Name = "dataGridViewVisitors";
            this.dataGridViewVisitors.RowHeadersVisible = false;
            this.dataGridViewVisitors.Size = new System.Drawing.Size(304, 172);
            this.dataGridViewVisitors.TabIndex = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // beautysaloonDataSetBindingSource
            // 
            this.beautysaloonDataSetBindingSource.DataSource = this.beautysaloonDataSet;
            this.beautysaloonDataSetBindingSource.Position = 0;
            // 
            // beautysaloonDataSet
            // 
            this.beautysaloonDataSet.DataSetName = "beautysaloonDataSet";
            this.beautysaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // buttonInsertIntoVisitors
            // 
            this.buttonInsertIntoVisitors.Location = new System.Drawing.Point(303, 228);
            this.buttonInsertIntoVisitors.Name = "buttonInsertIntoVisitors";
            this.buttonInsertIntoVisitors.Size = new System.Drawing.Size(170, 23);
            this.buttonInsertIntoVisitors.TabIndex = 4;
            this.buttonInsertIntoVisitors.Text = "Insert Into Visitors";
            this.buttonInsertIntoVisitors.UseVisualStyleBackColor = true;
            this.buttonInsertIntoVisitors.Click += new System.EventHandler(this.Button1_Click);
            // 
            // IdVisitor
            // 
            this.IdVisitor.DataPropertyName = "IdVisitor";
            this.IdVisitor.HeaderText = "IdVisitor";
            this.IdVisitor.Name = "IdVisitor";
            this.IdVisitor.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // FormVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.buttonInsertIntoVisitors);
            this.Controls.Add(this.dataGridViewVisitors);
            this.Name = "FormVisitors";
            this.Text = "FormVisitors";
            this.Load += new System.EventHandler(this.FormVisitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisitors;
        private System.Windows.Forms.BindingSource beautysaloonDataSetBindingSource;
        private beautysaloonDataSet beautysaloonDataSet;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Button buttonInsertIntoVisitors;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}