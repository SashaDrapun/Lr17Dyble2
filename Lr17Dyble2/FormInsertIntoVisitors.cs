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
    public partial class FormInsertIntoVisitors : Form
    {
        public FormInsertIntoVisitors()
        {
            InitializeComponent();
        }

        private void FormInsertIntoVisitors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.beautysaloonDataSet.DataTable1);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsAllCorect())
            {
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Insert into Visitors (FIO,ContactNumber,Discount)" +
                 " values('" + textBoxFIO.Text + "','" + textBoxContactNumber.Text + "'," +
                 textBoxDiscount.Text + ")"
                };

                sqlConnection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);


                DataTable dt = new DataTable();

                dt.Clear();

                da.Fill(dt);

                beautysaloonDataSet.AcceptChanges();
                dataGridViewVisitors.DataSource = dataTable1TableAdapter.GetData();
                sqlConnection.Close();
            }
        }

        private bool IsAllCorect()
        {
            bool result = true;
            if (!IsAllTextBoxesNotNull())
            {
                result = false;
                MessageBox.Show("All fields must be field");
            }
            if (!IsDiscountCorrect())
            {
                result = false;
                MessageBox.Show("The discount must be expressed in natural number!");
            }
            if (IsVisitorExists(textBoxFIO.Text))
            {
                result = false;
                MessageBox.Show("User with this FIO Exists");
            }
                return result;
         }

        private bool IsDiscountCorrect()
        {
            try
            {
                int discount = Convert.ToInt32(textBoxDiscount.Text);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        private bool IsAllTextBoxesNotNull()
        {
            bool result = true;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if(this.Controls[i] is TextBox)
                {
                    if(this.Controls[i].Text == "")
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        private bool IsVisitorExists(string visitorFIO)
        {
            bool result = false;

            for (int i = 0; i < dataGridViewVisitors.RowCount-1; i++)
            {
                if(dataGridViewVisitors[0,i].Value.ToString() == visitorFIO)
                {
                    result = true;
                }
            }

            return result;
        }

        static readonly string connection = "server=localhost; Port=3305;user=root;database=BeautySaloon;password=1234;";
        MySqlConnection sqlConnection = new MySqlConnection(connection);

        private void DeleteFromVisitors(string FIO)
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                Connection = sqlConnection,
                CommandText = "Delete from Visitors where FIO  = '" + FIO + "'"
            };

            sqlConnection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);


            DataTable dt = new DataTable();

            dt.Clear();

            da.Fill(dt);

            beautysaloonDataSet.AcceptChanges();
            dataGridViewVisitors.DataSource = dataTable1TableAdapter.GetData();
            sqlConnection.Close();
        }

        private void DataGridViewVisitors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const string message = "Are you sure that you would like to delete this row?";
            const string caption = "Delete row";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteFromVisitors(dataGridViewVisitors[0, e.RowIndex].Value.ToString());
            }
        }
    }
}
