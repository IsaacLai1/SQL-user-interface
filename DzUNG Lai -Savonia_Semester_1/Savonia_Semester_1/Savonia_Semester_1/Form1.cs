using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Savonia_Semester_1
{
    public partial class personalDataForm : Form
    {
        public personalDataForm()
        {
            InitializeComponent();
        }
        private void ConnectToDataBase()
        {
            try
            {
                SqlConnection Conn = new SqlConnection(Class1.Connection());
                Conn.Open();
                string sql = "select * from [Table]";
                SqlCommand commandsql = new SqlCommand(sql, Conn); // Impletement funtions in SQL library
                SqlDataAdapter com = new SqlDataAdapter(commandsql); //Tranfer data from database to class and form
                DataTable table = new DataTable(); // creat a temporary table in program
                com.Fill(table); // Tranfer data in database to temporary table
                dataGridView_PersonData.DataSource = table; // this temporary table then pour all information into GridView
            }
            catch
            {
                MessageBox.Show("Connection Error!");
            }
            finally
            {
                SqlConnection Conn = new SqlConnection(Class1.Connection());
            }
        }

        private void personalDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spring_Semester_DatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.spring_Semester_DatabaseDataSet.Table);
            ConnectToDataBase();
        }

        int index;
        private void dataGridView_PersonData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView_PersonData.CurrentRow.Index;
            TBoxFirstName.Text = dataGridView_PersonData.Rows[index].Cells[0].Value.ToString();
            TBoxFamilyName.Text = dataGridView_PersonData.Rows[index].Cells[1].Value.ToString();
            dateTimePicker_DOB.Value = DateTime.Parse(dataGridView_PersonData.Rows[index].Cells[2].Value.ToString());
            TBoxPlaceOfBirth.Text = dataGridView_PersonData.Rows[index].Cells[3].Value.ToString();
            if (dataGridView_PersonData.Rows[index].Cells[4].Value.ToString() == "Male") { ButtonMale.PerformClick(); }
            if (dataGridView_PersonData.Rows[index].Cells[4].Value.ToString() == "Female") { ButtonMale.PerformClick(); }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TBoxFirstName.Text = "";
            TBoxFamilyName.Text = "";
            dateTimePicker_DOB.Text = "";
            TBoxPlaceOfBirth.Text = "";
            ButtonMale.Checked = false;
            ButtonFemale.Checked = false;
        }

        string Add_A_Person;
        private void Button_Save_Click_1(object sender, EventArgs e)
        {
            String Get_Gender_Choice()
            {
                String Sex = "";
                if (ButtonMale.Checked == true) { Sex = "Male"; }
                else if (ButtonFemale.Checked == true) { Sex = "Female"; }
                return Sex;
            }
            try
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Open();
                Add_A_Person = "INSERT INTO [Table] VALUES (@Id,@firstName,@lastName,@DOB,@POB,@Gender)";
                SqlCommand commandAdd = new SqlCommand(Add_A_Person, conn);
                commandAdd.Parameters.AddWithValue("Id", dataGridView_PersonData.Rows.Count + 1);
                commandAdd.Parameters.AddWithValue("firstName", TBoxFirstName.Text);
                commandAdd.Parameters.AddWithValue("lastName", TBoxFamilyName.Text);
                commandAdd.Parameters.AddWithValue("DOB", dateTimePicker_DOB.Value.Date);
                commandAdd.Parameters.AddWithValue("POB", TBoxPlaceOfBirth.Text);
                commandAdd.Parameters.AddWithValue("Gender", Get_Gender_Choice());
                commandAdd.ExecuteNonQuery();
                ConnectToDataBase();
            }
            catch
            {
                MessageBox.Show("ERROR! Can not insert data.");
            }
            finally
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Close();
            }
        }

        String Del_A_Person;
        private void Button_Del_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Open();
                int Marked_flag = dataGridView_PersonData.CurrentRow.Index;
                Del_A_Person = "delete [Table] where ID ='" + (Marked_flag+1) + "'";
                SqlCommand comm = new SqlCommand(Del_A_Person, conn);
                comm.ExecuteNonQuery();
                ConnectToDataBase();
            }
            catch
            {
                MessageBox.Show("ERROR! Can not delete data.");
            }
            finally
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Close();
            }
        }

        String Update_A_Person;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String Get_Gender_Choice()
            {
                String Sex = "";
                if (ButtonMale.Checked) { Sex = "Male"; }
                else if (ButtonFemale.Checked) { Sex = "Female"; }
                return Sex;
            }

            try
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Open();
                int Marked_ID = dataGridView_PersonData.CurrentRow.Index;
                Update_A_Person = "UPDATE [Table] SET firstName = @firstName,lastName = @lastName,DOB = @DOB,POB = @POB,Gender = @Gender WHERE ID = @Id";
                SqlCommand commandUpdate = new SqlCommand(Update_A_Person, conn);
                commandUpdate.Parameters.Add("@Id", SqlDbType.Int).Value = Marked_ID+1;
                commandUpdate.Parameters.AddWithValue("firstName", TBoxFirstName.Text);
                commandUpdate.Parameters.AddWithValue("lastName", TBoxFamilyName.Text);
                commandUpdate.Parameters.AddWithValue("DOB", dateTimePicker_DOB.Value.Date);
                commandUpdate.Parameters.AddWithValue("POB", TBoxPlaceOfBirth.Text);
                commandUpdate.Parameters.AddWithValue("Gender", Get_Gender_Choice());
                commandUpdate.ExecuteNonQuery();
                ConnectToDataBase();
            }
            catch
            {
                MessageBox.Show("ERROR! Can not update data.");
            }
            finally
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Close();
            }
        }

        private void Button_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult Question;
            Question = MessageBox.Show("Do you want to close program ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Question == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TBox_Searching_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               try
                {
                    SqlConnection conn = new SqlConnection(Class1.Connection());
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from [Table] where firstName like '%" + TBox_Searching.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_PersonData.DataSource = dt;
                }
               catch
                {
                    MessageBox.Show("ERROR! Can not find data.");
                }
                finally
                {
                    SqlConnection conn = new SqlConnection(Class1.Connection());
                    conn.Close();
                }
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from [Table] where firstName like '%" + TBox_Searching.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_PersonData.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERROR! Can not find data.");
            }
            finally
            {
                SqlConnection conn = new SqlConnection(Class1.Connection());
                conn.Close();
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            ConnectToDataBase();
        }
        private void Button_Static_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Class1.Connection());
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE Gender = 'Male'", conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            comm = new SqlCommand("SELECT COUNT(*) FROM [Table] WHERE Gender = 'Female'", conn);
            Int32 count2 = (Int32)comm.ExecuteScalar();
            MessageBox.Show("Number of people: " + (dataGridView_PersonData.RowCount-1).ToString() +
                            "\nMen: "+ count.ToString() + "\nWomen: "+ count2.ToString());
        }

       
    }
}
