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
    public partial class FormInsertIntoVisits : Form
    {
        public FormInsertIntoVisits()
        {
            InitializeComponent();
        }

        private void FormInsertIntoVisits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.beautysaloonDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.beautysaloonDataSet.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter1.Fill(this.beautysaloonDataSet.DataTable3);
            for (int i = 0; i < dataGridViewServices.RowCount-1; i++)
            {
                comboBoxNameService.Items.Add(dataGridViewServices[0, i].Value.ToString());
            }
            for (int i = 0; i < dataGridViewVisitors.RowCount-1; i++)
            {
                comboBoxFIO.Items.Add(dataGridViewVisitors[0, i].Value.ToString());
            }
            //beautysaloonDataSet.DataTable3.Rows.Count

            UpdateCost();
        }

        private void UpdateCost()
        {
            for (int i = 0; i < beautysaloonDataSet.DataTable3.Rows.Count; i++)
            {
                dataGridViewVisits[5, i].Value = CountCost(dataGridViewVisits[0, i].Value.ToString(),
                    dataGridViewVisits[2, i].Value.ToString());
            }
        }

        private double CountCost(string nameService, string fIOVisitor)
        {
            return GetCost(nameService) * (1.0 - (GetDiscount(fIOVisitor) / 100.0));
        }

        private double GetDiscount(string fIOVisitor)
        {
            double result = 0;
            for (int i = 0; i < beautysaloonDataSet.DataTable1.Rows.Count; i++)
            {
                if (beautysaloonDataSet.DataTable1[i].FIO == fIOVisitor)
                {
                    result = beautysaloonDataSet.DataTable1[i].Discount;
                }
            }
            return result;
        }

        private double GetCost(string nameService)
        {
            double result = 0;
            for (int i = 0; i < beautysaloonDataSet.DataTable.Rows.Count; i++)
            {
                if(beautysaloonDataSet.DataTable[i].NameService == nameService)
                {
                    result = beautysaloonDataSet.DataTable[i].Cost;
                }
            }
            return result;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsAllTextFieldNotNull())
            {
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Insert into Visits (IdService,DateVisit,IdVisitor,TimeVisit,FIOMaster)" +
                " values((Select IdService from Services where NameService = '" + comboBoxNameService.Text + "'),"
                + "'" + dateTimePickerDateVisit.Text + "',"
                + " (Select IdVisitor from Visitors where FIO = '" + comboBoxFIO.Text + "'),"
                + "'" + dateTimePickerTimeVisit.Text + "',"
                + "'" + textBoxFIOMaster.Text + "'"
                + ")"
                };

                sqlConnection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);


                DataTable dt = new DataTable();

                dt.Clear();
                da.Fill(dt);

                beautysaloonDataSet.AcceptChanges();

                dataGridViewVisits.DataSource = dataTable3TableAdapter.GetData();
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("All fields must be field");
            }
            
        }

        private bool IsAllTextFieldNotNull()
        {
            bool result = true;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if ((this.Controls[i] is TextBox || this.Controls[i] is ComboBox || this.Controls[i] is DateTimePicker))
                {
                    if(this.Controls[i].Tag == "1")
                    {
                        if (this.Controls[i].Text == "")
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }

        static readonly string connection = "server=localhost; Port=3305;user=root;database=BeautySaloon;password=1234;";
        MySqlConnection sqlConnection = new MySqlConnection(connection);

        private void DataGridViewVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const string message = "Are you sure that you would like to delete this row?";
            const string caption = "Delete row";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //sqlConnection.Open();
                //beautysaloonDataSet.DataTable3.Rows.Remove(beautysaloonDataSet.DataTable3.Rows[e.RowIndex]);
                //beautysaloonDataSet.AcceptChanges();
                //dataTable3TableAdapter.Adapter.Update(beautysaloonDataSet);
                //dataTable3BindingSource.ResetBindings(true);
                DeleteFromVisits(dataGridViewVisits[0, e.RowIndex].Value.ToString(),
                    dataGridViewVisits[1, e.RowIndex].Value.ToString(),
                    dataGridViewVisits[2, e.RowIndex].Value.ToString(),
                    dataGridViewVisits[3, e.RowIndex].Value.ToString(),
                    dataGridViewVisits[4, e.RowIndex].Value.ToString());
                sqlConnection.Close();
            }
        }

        private void DeleteFromVisits(string nameService, string dateVisit, string fIO, string timeVisit, string fioMaster)
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                Connection = sqlConnection,
                CommandText = "Delete from Visits where DateVisit  = '" + dateVisit + "' and " +
                "TimeVisit = '" + timeVisit + "' and FIOMaster = '"+ fioMaster + "' and IdService = " +
                "(Select IdService from Services where NameService = '"+nameService + "') and IdVisitor = " +
                "(Select IdVisitor from Visitors where FIO  = '" + fIO +"')"
            };

            sqlConnection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);


            DataTable dt = new DataTable();

            dt.Clear();

            da.Fill(dt);

            beautysaloonDataSet.AcceptChanges();
            dataGridViewVisits.DataSource = dataTable3TableAdapter.GetData();
            sqlConnection.Close();
        }

        private void ButtonCountNumberOfVisitsForTheService_Click(object sender, EventArgs e)
        {
            bool isServiceExists = false;
            int count = 0;
            for (int i = 0; i < beautysaloonDataSet.DataTable3.Rows.Count; i++)
            {
               if(beautysaloonDataSet.DataTable3[i].NameService == textBoxNameService.Text)
                {
                    isServiceExists = true;
                    count++;
                }
            }
            if (!isServiceExists)
            {
                MessageBox.Show("Service with this name does not exists");
            }
            else
            {
                MessageBox.Show("Count NumberOf Visits For "+textBoxNameService.Text + " = "+ count);
            }

           
        }

        private void DataGridViewVisits_BindingContextChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void FormInsertIntoVisits_FormClosing(object sender, FormClosingEventArgs e)
        {
            beautysaloonDataSet.DataTable3.AcceptChanges();
        }
    }
}
