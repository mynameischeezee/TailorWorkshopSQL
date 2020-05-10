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
    public partial class DeleteOperationForm : Form
    {
        public MainForm Form;
        public string table;
        public string IDNAME;
        public DeleteOperationForm()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете вийти ?", "Увага !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Form.Show();
                Form.BringToFront();
                this.Hide();
            }
            
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SqlComponent.ConnectToDataBase();
            if (string.IsNullOrEmpty(txtBox_ID.Text) || string.IsNullOrWhiteSpace(txtBox_ID.Text))
            {
                MessageBox.Show("Невірно введені данні!", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    Convert.ToInt32(txtBox_ID.Text);
                    SqlCommand command = new SqlCommand($"DELETE FROM [{table}] WHERE [{IDNAME}]=@{IDNAME}", connection);
                    command.Parameters.AddWithValue(IDNAME, txtBox_ID.Text);
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                    Form.Show();
                    Form.BringToFront();
                    Form.UpdateAndRead();
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("Введені данні не є числовим типом даних!", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
