using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TailorWorkshopSQL.DataAccessLayer;
namespace TailorWorkshopSQL
{
    public partial class MainForm : Form
    {
        public string IDNAME;
        public List<string> Columns;
        public MainForm()
        {
            InitializeComponent();
            foreach (string table in ReadTables.Read())
            {
                cmbBox_Tables.Items.Add(table);
            }
            
        }
        private async void AddFirst()
        {
            lstBox_Data.Items.Clear();
            string data = "";
            SqlConnection connection = SqlComponent.ConnectToDataBase();
            SqlCommand command = new SqlCommand("", SqlComponent.ConnectToDataBase());
            List<string> columns = new List<string>();
            List<string> rows = new List<string>();
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {cmbBox_Tables.SelectedItem.ToString()}", SqlComponent.ConnectToDataBase());
            DataTable dataTableColumns = new DataTable();
            DataTable dataTableRows = new DataTable();

            sqlData.Fill(dataTableColumns);
            sqlData.Fill(dataTableRows);
            foreach (DataColumn column in dataTableColumns.Columns)
            {
                columns.Add(column.ToString());
            }
            foreach (DataRow row in dataTableRows.Rows)
            {
                rows.Add(row.ToString());
            }
            IDNAME = columns[0];
            data = "";
            SqlDataReader reader = null;
            SqlCommand Data = new SqlCommand($"SELECT * FROM [{cmbBox_Tables.SelectedItem.ToString()}] WHERE {IDNAME}=@{IDNAME}", connection);
                Data.Parameters.AddWithValue($"@{IDNAME}", "1");
                connection.Open();
                reader = await Data.ExecuteReaderAsync();
                await reader.ReadAsync();
                foreach (string column in columns)
                {
                    data += reader[column];
                    data += "   ";
                }
                lstBox_Data.Items.Add(data);
                data = "";
                connection.Close();
          }
        public async void UpdateAndRead()
        {
            lstBox_Data.Items.Clear();
            AddFirst();
            string data = "";
            SqlConnection connection = SqlComponent.ConnectToDataBase();
            SqlCommand command = new SqlCommand("", SqlComponent.ConnectToDataBase());
            List<string> columns = new List<string>();
            List<string> rows = new List<string>();
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {cmbBox_Tables.SelectedItem.ToString()}", SqlComponent.ConnectToDataBase());
            DataTable dataTableColumns = new DataTable();
            DataTable dataTableRows = new DataTable();

            sqlData.Fill(dataTableColumns);
            sqlData.Fill(dataTableRows);
            foreach (DataColumn column in dataTableColumns.Columns)
            {
                columns.Add(column.ToString());
            }
            foreach (DataRow row in dataTableRows.Rows)
            {
                rows.Add(row.ToString());
            }
            IDNAME = columns[0];
            Columns = columns;
            await connection.OpenAsync();
            SqlDataReader reader = null;
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [{cmbBox_Tables.SelectedItem.ToString()}]", connection);
            foreach (string column in columns)
            {
                data += column;
                data += "   ";
            }
            lstBox_Data.Items.Add(data);

            data = "";
            try
            {
                reader = await sqlCommand.ExecuteReaderAsync();
                await reader.ReadAsync();
                while (await reader.ReadAsync())
                {
                    foreach (string column in columns)
                    {
                        data += reader[column];
                        data += "   ";
                    }
                    lstBox_Data.Items.Add(data);
                    data = "";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        private async void cmbBox_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAndRead();
            
        }
        
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
              DeleteOperationForm deleteOperationForm = new DeleteOperationForm();
            deleteOperationForm.Form = this;
            deleteOperationForm.lbl_Info.Text = $"Видалити поле з таблиці {cmbBox_Tables.SelectedItem.ToString()}";
            deleteOperationForm.table = cmbBox_Tables.SelectedItem.ToString();
            deleteOperationForm.IDNAME = IDNAME;
            deleteOperationForm.Show();
            deleteOperationForm.BringToFront();
            this.Hide();  
            }
            catch
            {
                MessageBox.Show(":( Щось пішло не так... Можливо ви не обрали таблицю.", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                InsertOperationForm insertOperationForm = new InsertOperationForm();
                insertOperationForm.Form = this;
                insertOperationForm.lbl_Info.Text = $"Додавання у таблицю {cmbBox_Tables.SelectedItem.ToString()}";
                insertOperationForm.table = cmbBox_Tables.SelectedItem.ToString();
                insertOperationForm.IDs = Columns;
                insertOperationForm.ShowTools();
                insertOperationForm.Show();
                insertOperationForm.BringToFront();
                this.Hide();
            }
            catch
            {
                MessageBox.Show(":( Щось пішло не так... Можливо ви не обрали таблицю.", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOperationForm updateOperationForm = new UpdateOperationForm();
                updateOperationForm.Form = this;
                updateOperationForm.lbl_Info.Text = $"Додавання у таблицю {cmbBox_Tables.SelectedItem.ToString()}";
                updateOperationForm.table = cmbBox_Tables.SelectedItem.ToString();
                updateOperationForm.IDs = Columns;
                updateOperationForm.ShowTools();
                updateOperationForm.Show();
                updateOperationForm.BringToFront();
                this.Hide();
            }
            catch
            {
                MessageBox.Show(":( Щось пішло не так... Можливо ви не обрали таблицю.", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }



        private async void btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                lstBox_Data.Items.Clear();
                string data = "";
                SqlConnection connection = SqlComponent.ConnectToDataBase();
                SqlCommand command = new SqlCommand("", SqlComponent.ConnectToDataBase());
                List<string> columns = new List<string>();
                List<string> rows = new List<string>();
                SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT * FROM {cmbBox_Tables.SelectedItem.ToString()}", SqlComponent.ConnectToDataBase());
                DataTable dataTableColumns = new DataTable();
                DataTable dataTableRows = new DataTable();

                sqlData.Fill(dataTableColumns);
                sqlData.Fill(dataTableRows);
                foreach (DataColumn column in dataTableColumns.Columns)
                {
                    columns.Add(column.ToString());
                }
                foreach (DataRow row in dataTableRows.Rows)
                {
                    rows.Add(row.ToString());
                }
                IDNAME = columns[0];
                lstBox_Data.Items.Add(data);
                lstBox_Data.Items.Add(" ");
                data = "";
                try
                {
                    SqlDataReader reader = null;
                    SqlCommand Data = new SqlCommand($"SELECT * FROM [{cmbBox_Tables.SelectedItem.ToString()}] WHERE {IDNAME}=@{IDNAME}", connection);
                    Data.Parameters.AddWithValue($"@{IDNAME}", txtBox_ID.Text);
                    connection.Open();
                    reader = await Data.ExecuteReaderAsync();
                    await reader.ReadAsync();
                    foreach (string column in columns)
                    {
                        data += reader[column];
                        data += "   ";
                    }
                    lstBox_Data.Items.Add(data);
                    data = "";
                    connection.Close();
                }
                catch { MessageBox.Show("Невірно введені данні Такого ID в даній таблиці не існує!", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch
            {
                MessageBox.Show(":( Щось пішло не так... Можливо ви не обрали таблицю.", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
            
        }
    }
}
