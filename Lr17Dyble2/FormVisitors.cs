using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lr17Dyble2
{
    public partial class FormVisitors : Form
    {
        public FormVisitors()
        {
            InitializeComponent();
        }

        private void FormVisitors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.beautysaloonDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.beautysaloonDataSet.DataTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormInsertIntoVisitors formInsertIntoVisitors = new FormInsertIntoVisitors();
            formInsertIntoVisitors.ShowDialog();
            formInsertIntoVisitors.Dispose();
            dataGridViewVisitors.DataSource = dataTable1TableAdapter.GetData();
            
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
             //MessageBox.Show(dataGridViewVisitors[0, dataGridViewVisitors.RowCount-3].Value.ToString());
            dataGridViewVisitors[0, dataGridViewVisitors.SelectedCells[0].RowIndex].Value =
                 (object)(Convert.ToInt32(dataGridViewVisitors[0, dataGridViewVisitors.SelectedCells[0].RowIndex-1].Value) + 1);
            MessageBox.Show(dataGridViewVisitors.SelectedCells[0].ToString());
            //dataGridViewVisitors.SelectedRows[0];
            beautysaloonDataSet.AcceptChanges();
        }

        static string connection = "server=localhost; Port=3305;user=root;database=BeautySaloon;password=1234;";
        MySqlConnection sqlConnection = new MySqlConnection(connection);
    }

  
}
    

