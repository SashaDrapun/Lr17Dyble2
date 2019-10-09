using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr17Dyble2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.beautysaloonDataSet.DataTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.beautysaloonDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.beautysaloonDataSet.DataTable);
            pictureBoxPicture.Load(textBoxPicturePath.Text);
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            dataTableBindingSource.MovePrevious();
            pictureBoxPicture.Load(textBoxPicturePath.Text);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            dataTableBindingSource.MoveNext();
            pictureBoxPicture.Load(textBoxPicturePath.Text);
        }

        private void ButtonTranzitionToVisitors_Click(object sender, EventArgs e)
        {
            FormVisitors formVisitors = new FormVisitors();
            formVisitors.ShowDialog();
            formVisitors.Dispose();
        }

        private void ButtonTranzitionToVisits_Click(object sender, EventArgs e)
        {
            FormVisits formVisits = new FormVisits();
            formVisits.ShowDialog();
            formVisits.Dispose();
        }

        private void ButtonInsertIntoServices_Click(object sender, EventArgs e)
        {
            FormInsertIntoServices formInsertIntoServices = new FormInsertIntoServices();
            formInsertIntoServices.ShowDialog();
            formInsertIntoServices.Dispose();
            dataTableBindingSource.DataSource = dataTableTableAdapter.GetData();
        }

        private void ButtonSearchNameService_Click(object sender, EventArgs e)
        {
            bool isServiceExists = false;
            for (int i = 0; i < beautysaloonDataSet.DataTable.Rows.Count; i++)
            {
                if (beautysaloonDataSet.DataTable[i].NameService == textBoxNameServiceSearch.Text)
                {
                    listBoxInfoService.Items.Clear();
                    isServiceExists = true;
                    listBoxInfoService.Items.Add("Name Service - " + beautysaloonDataSet.DataTable[i].NameService);
                    listBoxInfoService.Items.Add("Description Services - " + beautysaloonDataSet.DataTable[i].DescriptionServices);
                    listBoxInfoService.Items.Add("Cost - " + beautysaloonDataSet.DataTable[i].Cost);
                }
            }

            if (!isServiceExists)
            {
                MessageBox.Show("Service with this name does not exists");
            }
        }

        private void ButtonCountCostAllServices_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < beautysaloonDataSet.DataTable.Rows.Count; i++)
            {
                sum += beautysaloonDataSet.DataTable[i].Cost;
            }

            textBoxCostAllServices.Text = sum.ToString();
        }
    }
}
