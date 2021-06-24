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
    public partial class Individual : Form
    {
        public Individual()
        {
            InitializeComponent();
        }

        private void btnIFSaveNewMember_Click(object sender, EventArgs e)
        {
            string typeOfplan = "Individual";
            string methodOfpayment = "";

            methodOfpayment = comboBox1.SelectedItem.ToString();

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True;";
            string Query = "INSERT INTO applicanttbl(idnumber,firstnames,lastname,dob,contactNumber,emailAddress,homeAddress,typeOfPlan,methodOfPayment)VALUES('" + txtIFIDPassport.Text + "','" + txtIFFirstnames.Text + "','" + txtIFLastname.Text + "','" + dateTimePicker1.Text + "','" + txtIFContact.Text + "','" + txtIFEmail.Text + "','" + txtIFHomeAddress.Text + "','" + typeOfplan + "','" + methodOfpayment + "');";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("Successfully saved", "Notice");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIFDeleteMember_Click(object sender, EventArgs e)
        {

        }

        private void btnIFReadInformation_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIFModify_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyInd_Click(object sender, EventArgs e)
        {
            /*string constring = "datasource=127.0.0.1;port=3306;username=root;password=Kh@mbul3;";
            string Query = "INSERT INTO registration.applicationform(firstnames,lastname,dateofbirth,identityNumberorPassport,contactNumber,emailAddress,homeAddress,typeOfPlan,methodOfPayment)VALUES('" + txtIFFirstnames.Text + "','" + txtIFLastname.Text + "','" + dateTimePicker1.Text + "','" + txtIFIDPassport.Text + "','" + txtIFContact.Text + "','" + txtIFEmail.Text + "','" + txtIFHomeAddress.Text + "','" + typeOfplan + "','" + methodOfpayment + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            QUESTION qUESTION = new QUESTION();
            qUESTION.ShowDialog();
        }

        private void Individual_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
