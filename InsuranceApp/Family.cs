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
    public partial class Family : Form
    {
        public Family()
        {
            InitializeComponent();
        }

        private void btnFamSaveNewMember_Click(object sender, EventArgs e)
        {
            string typeOfplan = "Family";
            string methodOfpayment = "";

            methodOfpayment = comboBoxFam.SelectedItem.ToString();

        


            try
            {
                string Query = "INSERT INTO applicanttbl(idnumber,firstnames,lastname,dob,contactNumber,emailAddress,homeAddress,typeOfPlan,methodOfPayment)VALUES('" + txtFamIDPassport.Text + "','" + txtFamFirstnames.Text + "','" + txtFamLastname.Text + "','" + dateTimePicker1.Text + "','" + txtFamContact.Text + "','" + txtFamEmail.Text + "','" + txtFamHomeAddress.Text + "','" + typeOfplan + "','" + methodOfpayment + "');";

                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                MessageBox.Show("Successfully saved", "Notice");
                txtFamIDPassport.Text = null;
                txtFamFirstnames.Text = null;
                txtFamLastname.Text = null;
                txtFamHomeAddress.Text = null;
                txtFamContact.Text = null;
                txtFamEmail.Text = null;
                dateTimePickerFam1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFMAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string Query = "INSERT INTO familytbl(idNumber,firstnames,surname,dob,relationship,identity_FK)VALUES('" + txtFMID.Text + "','" + txtFMFirstName.Text + "','" + txtFMSurname.Text + "','" + dateTimePicker1.Text + "','" + txtFMRelationship.Text + "','" + txtFamIDPassport.Text + "');";

                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                SqlDataReader dataReader;
                sqlConnection.Open();
                dataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Successfully saved", "Notice");

                txtFMID.Text = null;
                txtFMFirstName.Text = null;
                txtFMSurname.Text = null;
                txtFMRelationship.Text = null;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            QUESTION qUESTION = new QUESTION();
            qUESTION.ShowDialog();
        }

        private void Family_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePickerFam1.Value = DateTime.Now;
        }
    }
}
