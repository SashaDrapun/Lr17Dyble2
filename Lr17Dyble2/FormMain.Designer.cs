namespace Lr17Dyble2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautysaloonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautysaloonDataSet = new Lr17Dyble2.beautysaloonDataSet();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonTranzitionToVisits = new System.Windows.Forms.Button();
            this.buttonTranzitionToVisitors = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBoxPicture = new System.Windows.Forms.PictureBox();
            this.dataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPicturePath = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dataTableTableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTableTableAdapter();
            this.dataTable1TableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable1TableAdapter();
            this.dataTable2TableAdapter = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable2TableAdapter();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter1 = new Lr17Dyble2.beautysaloonDataSetTableAdapters.DataTable1TableAdapter();
            this.buttonInsertIntoServices = new System.Windows.Forms.Button();
            this.textBoxNameServiceSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchNameService = new System.Windows.Forms.Button();
            this.labelNameService = new System.Windows.Forms.Label();
            this.listBoxInfoService = new System.Windows.Forms.ListBox();
            this.buttonCountCostAllServices = new System.Windows.Forms.Button();
            this.textBoxCostAllServices = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.beautysaloonDataSetBindingSource;
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
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // buttonTranzitionToVisits
            // 
            this.buttonTranzitionToVisits.Location = new System.Drawing.Point(403, 367);
            this.buttonTranzitionToVisits.Name = "buttonTranzitionToVisits";
            this.buttonTranzitionToVisits.Size = new System.Drawing.Size(137, 23);
            this.buttonTranzitionToVisits.TabIndex = 1;
            this.buttonTranzitionToVisits.Text = "TransitionToVisits";
            this.buttonTranzitionToVisits.UseVisualStyleBackColor = true;
            this.buttonTranzitionToVisits.Click += new System.EventHandler(this.ButtonTranzitionToVisits_Click);
            // 
            // buttonTranzitionToVisitors
            // 
            this.buttonTranzitionToVisitors.Location = new System.Drawing.Point(224, 367);
            this.buttonTranzitionToVisitors.Name = "buttonTranzitionToVisitors";
            this.buttonTranzitionToVisitors.Size = new System.Drawing.Size(140, 23);
            this.buttonTranzitionToVisitors.TabIndex = 2;
            this.buttonTranzitionToVisitors.Text = "TranzitionToVisitors";
            this.buttonTranzitionToVisitors.UseVisualStyleBackColor = true;
            this.buttonTranzitionToVisitors.Click += new System.EventHandler(this.ButtonTranzitionToVisitors_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dataTableBindingSource, "NameService", true));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableBindingSource, "NameService", true));
            this.textBox2.Location = new System.Drawing.Point(134, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableBindingSource, "DescriptionServices", true));
            this.textBox3.Location = new System.Drawing.Point(264, 303);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableBindingSource, "Cost", true));
            this.textBox4.Location = new System.Drawing.Point(387, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.Location = new System.Drawing.Point(498, 294);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPicture.TabIndex = 6;
            this.pictureBoxPicture.TabStop = false;
            // 
            // dataTableBindingSource1
            // 
            this.dataTableBindingSource1.DataMember = "DataTable";
            this.dataTableBindingSource1.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // textBoxPicturePath
            // 
            this.textBoxPicturePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableBindingSource, "Photo", true));
            this.textBoxPicturePath.Location = new System.Drawing.Point(502, 304);
            this.textBoxPicturePath.Name = "textBoxPicturePath";
            this.textBoxPicturePath.Size = new System.Drawing.Size(96, 20);
            this.textBoxPicturePath.TabIndex = 7;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(28, 300);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(617, 301);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.beautysaloonDataSetBindingSource;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // buttonInsertIntoServices
            // 
            this.buttonInsertIntoServices.Location = new System.Drawing.Point(324, 415);
            this.buttonInsertIntoServices.Name = "buttonInsertIntoServices";
            this.buttonInsertIntoServices.Size = new System.Drawing.Size(118, 23);
            this.buttonInsertIntoServices.TabIndex = 10;
            this.buttonInsertIntoServices.Text = "Insert Into Services";
            this.buttonInsertIntoServices.UseVisualStyleBackColor = true;
            this.buttonInsertIntoServices.Click += new System.EventHandler(this.ButtonInsertIntoServices_Click);
            // 
            // textBoxNameServiceSearch
            // 
            this.textBoxNameServiceSearch.Location = new System.Drawing.Point(236, 148);
            this.textBoxNameServiceSearch.Name = "textBoxNameServiceSearch";
            this.textBoxNameServiceSearch.Size = new System.Drawing.Size(206, 20);
            this.textBoxNameServiceSearch.TabIndex = 11;
            // 
            // buttonSearchNameService
            // 
            this.buttonSearchNameService.Location = new System.Drawing.Point(265, 174);
            this.buttonSearchNameService.Name = "buttonSearchNameService";
            this.buttonSearchNameService.Size = new System.Drawing.Size(139, 23);
            this.buttonSearchNameService.TabIndex = 12;
            this.buttonSearchNameService.Text = "Search";
            this.buttonSearchNameService.UseVisualStyleBackColor = true;
            this.buttonSearchNameService.Click += new System.EventHandler(this.ButtonSearchNameService_Click);
            // 
            // labelNameService
            // 
            this.labelNameService.AutoSize = true;
            this.labelNameService.Location = new System.Drawing.Point(310, 132);
            this.labelNameService.Name = "labelNameService";
            this.labelNameService.Size = new System.Drawing.Size(74, 13);
            this.labelNameService.TabIndex = 13;
            this.labelNameService.Text = "Name Service";
            // 
            // listBoxInfoService
            // 
            this.listBoxInfoService.FormattingEnabled = true;
            this.listBoxInfoService.Location = new System.Drawing.Point(236, 203);
            this.listBoxInfoService.Name = "listBoxInfoService";
            this.listBoxInfoService.Size = new System.Drawing.Size(206, 82);
            this.listBoxInfoService.TabIndex = 14;
            // 
            // buttonCountCostAllServices
            // 
            this.buttonCountCostAllServices.Location = new System.Drawing.Point(521, 223);
            this.buttonCountCostAllServices.Name = "buttonCountCostAllServices";
            this.buttonCountCostAllServices.Size = new System.Drawing.Size(183, 23);
            this.buttonCountCostAllServices.TabIndex = 15;
            this.buttonCountCostAllServices.Text = "Count Cost All Services";
            this.buttonCountCostAllServices.UseVisualStyleBackColor = true;
            this.buttonCountCostAllServices.Click += new System.EventHandler(this.ButtonCountCostAllServices_Click);
            // 
            // textBoxCostAllServices
            // 
            this.textBoxCostAllServices.Location = new System.Drawing.Point(521, 252);
            this.textBoxCostAllServices.Name = "textBoxCostAllServices";
            this.textBoxCostAllServices.ReadOnly = true;
            this.textBoxCostAllServices.Size = new System.Drawing.Size(183, 20);
            this.textBoxCostAllServices.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.textBoxCostAllServices);
            this.Controls.Add(this.buttonCountCostAllServices);
            this.Controls.Add(this.listBoxInfoService);
            this.Controls.Add(this.labelNameService);
            this.Controls.Add(this.buttonSearchNameService);
            this.Controls.Add(this.textBoxNameServiceSearch);
            this.Controls.Add(this.buttonInsertIntoServices);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxPicturePath);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonTranzitionToVisitors);
            this.Controls.Add(this.buttonTranzitionToVisits);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautysaloonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource beautysaloonDataSetBindingSource;
        private beautysaloonDataSet beautysaloonDataSet;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private beautysaloonDataSetTableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.Button buttonTranzitionToVisits;
        private System.Windows.Forms.Button buttonTranzitionToVisitors;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBoxPicture;
        private System.Windows.Forms.BindingSource dataTableBindingSource1;
        private System.Windows.Forms.TextBox textBoxPicturePath;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private beautysaloonDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.Button buttonInsertIntoServices;
        private System.Windows.Forms.TextBox textBoxNameServiceSearch;
        private System.Windows.Forms.Button buttonSearchNameService;
        private System.Windows.Forms.Label labelNameService;
        private System.Windows.Forms.ListBox listBoxInfoService;
        private System.Windows.Forms.Button buttonCountCostAllServices;
        private System.Windows.Forms.TextBox textBoxCostAllServices;
    }
}

