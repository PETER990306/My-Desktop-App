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

namespace InsuranceApp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        private void btnCompleteRegistration_Click(object sender, EventArgs e)
        {
            //Trying new code to see it can work
            if (txtCellphone.Text != string.Empty || txtPassword.Text != string.Empty || txtConfirmPassword.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    sqlCommand = new SqlCommand("select * from registrationtbl where Id='" + txtCellphone.Text + "'", con);
                    sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        sqlDataReader.Close();
                        MessageBox.Show("Cellphone number entered already exist try another one please");
                    }
                    else
                    {
                        sqlDataReader.Close();
                        sqlCommand = new SqlCommand("insert into registrationtbl(Id,fullnames,surname,password) VALUES('" + txtCellphone.Text + "','" + txtFullNames.Text + "','" + txtSurname.Text + "','" + txtPassword.Text + "');", con);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please you can Log In");

                    }
                }
                else
                {
                    MessageBox.Show("Your passwords are not matching. Enter matching Passwords!");
                }
            }
            else 
            {
                MessageBox.Show("Please enter value in all fields");
            }
        }

        private void btnReturnToLogIN_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True");
            con.Open();
        }
    }
}
