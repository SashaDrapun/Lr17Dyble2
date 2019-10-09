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
    public partial class FormInsertIntoServices : Form
    {
        public FormInsertIntoServices()
        {
            InitializeComponent();
        }

        private void FormInsertIntoServices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.beautysaloonDataSet.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautysaloonDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
        }

        private void TextBoxPhoto_Click(object sender, EventArgs e)
        {
         
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsAllCorect())
            {
                //DataRow dataRow = beautysaloonDataSet.DataTable.NewRow();
                //dataRow.ItemArray = new object[]{textBoxName.Text,textBoxDescription.Text, textBoxCost.Text,
                //textBoxPhoto.Text};

                //beautysaloonDataSet.DataTable.Rows.Add(dataRow);
                MySqlCommand mySqlCommand = new MySqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "Insert into Services (NameService,DescriptionServices,Cost,Photo)" +
                " values('" + textBoxName.Text + "','" + textBoxDescription.Text + "'," +
                textBoxCost.Text + ",'" + textBoxPhoto.Text + "'" + ")"
                };

                sqlConnection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);


                DataTable dt = new DataTable();

                dt.Clear();

                da.Fill(dt);

                beautysaloonDataSet.AcceptChanges();
                dataGridViewServices.DataSource = dataTableTableAdapter.GetData();
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
            if (!IsCostCorrect())
            {
                result = false;
                MessageBox.Show("The cost must be expressed in natural number!");
            }
            if (IsServiceExists(textBoxName.Text))
            {
                result = false;
                MessageBox.Show("Service with this Name Exists");
            }
            return result;
        }

        private bool IsServiceExists(string nameService)
        {
            bool result = false;
            for (int i = 0; i < dataGridViewServices.RowCount-1; i++)
            {
                if(dataGridViewServices[0,i].Value.ToString() == nameService)
                {
                    result = true;
                }
            }
            return result;
        }

        private bool IsAllTextBoxesNotNull()
        {
            bool result = true;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    if (this.Controls[i].Text == "")
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        private bool IsCostCorrect()
        {
            try
            {
                int discount = Convert.ToInt32(textBoxCost.Text);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        private string DoNormalPath(string wrongPath)
        {
            string result = "";
            for (int i = 0; i < wrongPath.Length; i++)
            {
                result += wrongPath[i];
                if (wrongPath[i] == '\\')
                {
                    result += wrongPath[i];
                }

            }
            return result;
        }

        static string connection = "server=localhost; Port=3305;user=root;database=BeautySaloon;password=1234;";
        MySqlConnection sqlConnection = new MySqlConnection(connection);

        private void TextBoxPhoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLoadImage_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            pictureBoxPhoto.Load(openDialog.FileName);
            textBoxPhoto.Text = DoNormalPath((openDialog.FileName));
            // сохраняем текст в файл
        }

        private void DeleteFromServices(string nameService)
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                Connection = sqlConnection,
                CommandText = "Delete from Services where NameService = '" + nameService + "'"
            };

            sqlConnection.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(mySqlCommand);


            DataTable dt = new DataTable();

            dt.Clear();

            da.Fill(dt);

            beautysaloonDataSet.AcceptChanges();
            dataGridViewServices.DataSource = dataTableTableAdapter.GetData();
            sqlConnection.Close();
        }

        private void DataGridViewServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            const string message = "Are you sure that you would like to delete this row?";
            const string caption = "Delete row";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteFromServices(dataGridViewServices[0, e.RowIndex].Value.ToString());
            }
        }
    }
}
