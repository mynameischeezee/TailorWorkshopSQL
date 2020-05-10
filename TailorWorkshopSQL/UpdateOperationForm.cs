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
    public partial class UpdateOperationForm : Form
    {
        public MainForm Form;
        public string table;
        public List<string> IDs;
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<Label> labels = new List<Label>();
        public UpdateOperationForm()
        {
            InitializeComponent();
            textBoxes.Add(textBox0);
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);
            textBoxes.Add(textBox6);
            textBoxes.Add(textBox7);
            textBoxes.Add(textBox8);
            textBoxes.Add(textBox9);
            textBoxes.Add(textBox10);
            textBoxes.Add(textBox11);
            textBoxes.Add(textBox12);
            textBoxes.Add(textBox13);


            labels.Add(label0);
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);

        }
        public void ShowTools()
        {
            foreach (Label label in labels)
            {
                label.Visible = false;
            }

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Visible = false;
            }
            for (int i = 0; i <= (IDs.Count - 1); i++)
            {
                textBoxes[i].Visible = true;
                labels[i].Visible = true;
                labels[i].Text = IDs[i];
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете вийти ?", "Увага !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Form.Show();
                Form.UpdateAndRead();
                Form.BringToFront();
                
                this.Hide();
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            List<int> OptionalIDs = InputOutPutSettings.OptionalIDs(table);
            try
            {
                if (OptionalIDs.Any())
                {
                    foreach (TextBox textBox in textBoxes)
                    {
                        if (IDs.Count > textBoxes.IndexOf(textBox))
                        {
                            if (OptionalIDs.Contains(textBoxes.IndexOf(textBox)))
                            {

                            }
                            else
                            {

                                if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
                                {
                                    MessageBox.Show(textBox.Name);
                                    throw new Exception("Empty Field");
                                }
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                SqlConnection connection = SqlComponent.ConnectToDataBase();
            string dataFirst = "";
            string dataSecond = "";
            foreach (string element in IDs)
            {
                if (IDs.IndexOf(element) == 0)
                {
                    continue;
                }
                else if (IDs.IndexOf(element) == 1)
                {
                    dataFirst += $"[{element}]=@{element}";

                }
                else
                {

                    dataFirst += $", [{element}]=@{element}";
                }

            }
            SqlCommand command = new SqlCommand($"UPDATE [{table}] SET {dataFirst} WHERE [{IDs[0]}] = @{IDs[0]}", connection);
            foreach (string ID in IDs)
            {
                command.Parameters.AddWithValue(ID, textBoxes[IDs.IndexOf(ID)].Text);
            }

            try
            {
                connection.Open();
                await command.ExecuteNonQueryAsync();
                connection.Close();
                Form.Show();
                Form.UpdateAndRead();
                Form.BringToFront();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невірно введені данні!", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
            catch
            {
                MessageBox.Show("Не всі данні заповнені!", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
