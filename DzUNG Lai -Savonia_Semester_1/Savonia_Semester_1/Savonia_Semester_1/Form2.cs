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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Class2.Connection2());
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LOGIN where UserName='" + textBox_UserName.Text + "' and Password ='" + textBox_Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                personalDataForm mainForm = new personalDataForm();
                mainForm.Show();
            }

            else
            {
                MessageBox.Show("Please check your Username and Password");
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
