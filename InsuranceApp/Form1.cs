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
using System.Data.SqlClient;

namespace InsuranceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        SqlConnection sqlConnection;
 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            // string constring = "datasource=127.0.0.1;port=3306;username=root;password=Kh@mbul3;";

            //MySqlConnection conDatabase = new MySqlConnection(constring);
            //MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            //conDatabase.Open();

            if (txtCellphone.Text != string.Empty || txtPassword.Text != string.Empty)
            { 
                sqlCommand = new SqlCommand("select * from registrationtbl where id='" + txtCellphone.Text + "' and password='" + txtPassword.Text + "'", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                
                if (sqlDataReader.Read())
                {
                    sqlDataReader.Close();
                    
                    this.Hide();
                    ChooseTheUse chooseTheUse = new ChooseTheUse();
                    chooseTheUse.ShowDialog();
                }
                else 
                {
                    sqlDataReader.Close();
                    MessageBox.Show("No accounts available with this cellphone and password");
                }
            }
            else 
            {
                MessageBox.Show("Make sure no field is left null!");
            }
            
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True");
            sqlConnection.Open();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registerForm = new Registration();
            registerForm.Show();
        }
    }
}
