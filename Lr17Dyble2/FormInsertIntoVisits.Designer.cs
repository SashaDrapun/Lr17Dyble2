namespace Lr17Dyble2
{
    partial class FormInsertIntoVisits
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
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.nameServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOMasterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautysaloonDataSet = new Lr17Dyble2.beautysaloonDataSet();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.nameServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionServicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewVisitors = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxNameService = new System.Windows.Forms.ComboBox();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.textBoxFIOMaster = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerDateVisit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTimeVisit = new System.Windows.Forms.DateTimePicker();
            this.textBoxNameService = new System.Windows.Forms.TextBox();
            this.labelNameService2 = new System.Windows.Forms.Label();
            this.buttonCountNumberOfVisitsForTheService = new System.Windows.Forms.Button();
            this.dataTableTableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTableTableAdapter();
            this.dataTable1TableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable1TableAdapter();
            this.dataTable3TableAdapter1 = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable3TableAdapter();
            this.beautysaloonDataSet1 = new Lr17Dyble2.beautysaloonDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AutoGenerateColumns = false;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameServiceDataGridViewTextBoxColumn,
            this.dateVisitDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.timeVisitDataGridViewTextBoxColumn,
            this.fIOMasterDataGridViewTextBoxColumn,
            this.Cost});
            this.dataGridViewVisits.DataSource = this.dataTable3BindingSource;
            this.dataGridViewVisits.Location = new System.Drawing.Point(98, 12);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.RowHeadersVisible = false;
            this.dataGridViewVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVisits.Size = new System.Drawing.Size(807, 257);
            this.dataGridViewVisits.TabIndex = 0;
            this.dataGridViewVisits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVisits_CellDoubleClick);
            this.dataGridViewVisits.BindingContextChanged += new System.EventHandler(this.DataGridViewVisits_BindingContextChanged);
            // 
            // nameServiceDataGridViewTextBoxColumn
            // 
            this.nameServiceDataGridViewTextBoxColumn.DataPropertyName = "NameService";
            this.nameServiceDataGridViewTextBoxColumn.Frozen = true;
            this.nameServiceDataGridViewTextBoxColumn.HeaderText = "NameService";
            this.nameServiceDataGridViewTextBoxColumn.Name = "nameServiceDataGridViewTextBoxColumn";
            // 
            // dateVisitDataGridViewTextBoxColumn
            // 
            this.dateVisitDataGridViewTextBoxColumn.DataPropertyName = "DateVisit";
            this.dateVisitDataGridViewTextBoxColumn.Frozen = true;
            this.dateVisitDataGridViewTextBoxColumn.HeaderText = "DateVisit";
            this.dateVisitDataGridViewTextBoxColumn.Name = "dateVisitDataGridViewTextBoxColumn";
            this.dateVisitDataGridViewTextBoxColumn.Width = 300;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.Frozen = true;
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // timeVisitDataGridViewTextBoxColumn
            // 
            this.timeVisitDataGridViewTextBoxColumn.DataPropertyName = "TimeVisit";
            this.timeVisitDataGridViewTextBoxColumn.Frozen = true;
            this.timeVisitDataGridViewTextBoxColumn.HeaderText = "TimeVisit";
            this.timeVisitDataGridViewTextBoxColumn.Name = "timeVisitDataGridViewTextBoxColumn";
            // 
            // fIOMasterDataGridViewTextBoxColumn
            // 
            this.fIOMasterDataGridViewTextBoxColumn.DataPropertyName = "FIOMaster";
            this.fIOMasterDataGridViewTextBoxColumn.Frozen = true;
            this.fIOMasterDataGridViewTextBoxColumn.HeaderText = "FIOMaster";
            this.fIOMasterDataGridViewTextBoxColumn.Name = "fIOMasterDataGridViewTextBoxColumn";
            // 
            // Cost
            // 
            this.Cost.Frozen = true;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.beautysaloonDataSet;
            // 
            // beautysaloonDataSet
            // 
            this.beautysaloonDataSet.DataSetName = "beautysaloonDataSet";
            this.beautysaloonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AutoGenerateColumns = false;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameServiceDataGridViewTextBoxColumn1,
            this.descriptionServicesDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridViewServices.DataSource = this.dataTableBindingSource;
            this.dataGridViewServices.Location = new System.Drawing.Point(40, 86);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.Size = new System.Drawing.Size(427, 77);
            this.dataGridViewServices.TabIndex = 1;
            this.dataGridViewServices.Visible = false;
            // 
            // nameServiceDataGridViewTextBoxColumn1
            // 
            this.nameServiceDataGridViewTextBoxColumn1.DataPropertyName = "NameService";
            this.nameServiceDataGridViewTextBoxColumn1.HeaderText = "NameService";
            this.nameServiceDataGridViewTextBoxColumn1.Name = "nameServiceDataGridViewTextBoxColumn1";
            // 
            // descriptionServicesDataGridViewTextBoxColumn
            // 
            this.descriptionServicesDataGridViewTextBoxColumn.DataPropertyName = "DescriptionServices";
            this.descriptionServicesDataGridViewTextBoxColumn.HeaderText = "DescriptionServices";
            this.descriptionServicesDataGridViewTextBoxColumn.Name = "descriptionServicesDataGridViewTextBoxColumn";
            this.descriptionServicesDataGridViewTextBoxColumn.Width = 120;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.beautysaloonDataSet;
            // 
            // dataGridViewVisitors
            // 
            this.dataGridViewVisitors.AutoGenerateColumns = false;
            this.dataGridViewVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn1,
            this.contactNumberDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridViewVisitors.DataSource = this.dataTable1BindingSource;
            this.dataGridViewVisitors.Location = new System.Drawing.Point(589, 86);
            this.dataGridViewVisitors.Name = "dataGridViewVisitors";
            this.dataGridViewVisitors.RowHeadersVisible = false;
            this.dataGridViewVisitors.Size = new System.Drawing.Size(309, 77);
            this.dataGridViewVisitors.TabIndex = 2;
            this.dataGridViewVisitors.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            this.fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn1.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
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
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.beautysaloonDataSet;
            // 
            // comboBoxNameService
            // 
            this.comboBoxNameService.FormattingEnabled = true;
            this.comboBoxNameService.Location = new System.Drawing.Point(195, 302);
            this.comboBoxNameService.Name = "comboBoxNameService";
            this.comboBoxNameService.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameService.TabIndex = 3;
            this.comboBoxNameService.Tag = "1";
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Location = new System.Drawing.Point(532, 304);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFIO.TabIndex = 4;
            this.comboBoxFIO.Tag = "1";
            // 
            // textBoxFIOMaster
            // 
            this.textBoxFIOMaster.Location = new System.Drawing.Point(865, 304);
            this.textBoxFIOMaster.Name = "textBoxFIOMaster";
            this.textBoxFIOMaster.Size = new System.Drawing.Size(95, 20);
            this.textBoxFIOMaster.TabIndex = 7;
            this.textBoxFIOMaster.Tag = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(485, 349);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 27);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dateTimePickerDateVisit
            // 
            this.dateTimePickerDateVisit.Location = new System.Drawing.Point(322, 304);
            this.dateTimePickerDateVisit.Name = "dateTimePickerDateVisit";
            this.dateTimePickerDateVisit.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateVisit.TabIndex = 9;
            this.dateTimePickerDateVisit.Tag = "1";
            // 
            // dateTimePickerTimeVisit
            // 
            this.dateTimePickerTimeVisit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeVisit.Location = new System.Drawing.Point(659, 305);
            this.dateTimePickerTimeVisit.Name = "dateTimePickerTimeVisit";
            this.dateTimePickerTimeVisit.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTimeVisit.TabIndex = 10;
            this.dateTimePickerTimeVisit.Tag = "1";
            // 
            // textBoxNameService
            // 
            this.textBoxNameService.Location = new System.Drawing.Point(64, 381);
            this.textBoxNameService.Name = "textBoxNameService";
            this.textBoxNameService.Size = new System.Drawing.Size(206, 20);
            this.textBoxNameService.TabIndex = 22;
            // 
            // labelNameService2
            // 
            this.labelNameService2.AutoSize = true;
            this.labelNameService2.Location = new System.Drawing.Point(128, 365);
            this.labelNameService2.Name = "labelNameService2";
            this.labelNameService2.Size = new System.Drawing.Size(74, 13);
            this.labelNameService2.TabIndex = 21;
            this.labelNameService2.Text = "Name Service";
            // 
            // buttonCountNumberOfVisitsForTheService
            // 
            this.buttonCountNumberOfVisitsForTheService.Location = new System.Drawing.Point(49, 407);
            this.buttonCountNumberOfVisitsForTheService.Name = "buttonCountNumberOfVisitsForTheService";
            this.buttonCountNumberOfVisitsForTheService.Size = new System.Drawing.Size(230, 23);
            this.buttonCountNumberOfVisitsForTheService.TabIndex = 20;
            this.buttonCountNumberOfVisitsForTheService.Text = "Count Number Of Visits For The Service";
            this.buttonCountNumberOfVisitsForTheService.UseVisualStyleBackColor = true;
            this.buttonCountNumberOfVisitsForTheService.Click += new System.EventHandler(this.ButtonCountNumberOfVisitsForTheService_Click);
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable3TableAdapter1
            // 
            this.dataTable3TableAdapter1.ClearBeforeFill = true;
            // 
            // beautysaloonDataSet1
            // 
            this.beautysaloonDataSet1.DataSetName = "beautysaloonDataSet";
            this.beautysaloonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormInsertIntoVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.textBoxNameService);
            this.Controls.Add(this.labelNameService2);
            this.Controls.Add(this.buttonCountNumberOfVisitsForTheService);
            this.Controls.Add(this.dateTimePickerTimeVisit);
            this.Controls.Add(this.dateTimePickerDateVisit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFIOMaster);
            this.Controls.Add(this.comboBoxFIO);
            this.Controls.Add(this.comboBoxNameService);
            this.Controls.Add(this.dataGridViewVisitors);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.dataGridViewVisits);
            this.Name = "FormInsertIntoVisits";
            this.Text = "FormInsertIntoVisits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInsertIntoVisits_FormClosing);
            this.Load += new System.EventHandler(this.FormInsertIntoVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private beautysaloonDataSet beautysaloonDataSet;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private beautysaloonDataSetTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewVisitors;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxNameService;
        private System.Windows.Forms.ComboBox comboBoxFIO;
        private System.Windows.Forms.TextBox textBoxFIOMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionServicesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateVisit;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeVisit;
        private System.Windows.Forms.TextBox textBoxNameService;
        private System.Windows.Forms.Label labelNameService2;
        private System.Windows.Forms.Button buttonCountNumberOfVisitsForTheService;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOMasterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private beautysaloonDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter1;
        private beautysaloonDataSet beautysaloonDataSet1;
    }
}