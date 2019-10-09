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
using MySql.Data;
using MySql;


namespace Lr17Dyble2
{
    public partial class FormVisits : Form
    {
        public FormVisits()
        {
            InitializeComponent();
        }

        private void FormVisits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.beautysaloonDataSet.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.beautysaloonDataSet.DataTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable3". При необходимости она может быть перемещена или удалена.

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonInsertIntoVisits_Click(object sender, EventArgs e)
        {
            FormInsertIntoVisits formInsertIntoVisits = new FormInsertIntoVisits();
            formInsertIntoVisits.ShowDialog();
            formInsertIntoVisits.Dispose();
        }
    }
}
