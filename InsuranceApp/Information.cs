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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
           //string constring = "datasource=127.0.0.1;port=3306;username=root;password=Kh@mbul3;";
            string Query = "SELECT * FROM applicanttbl";
            SqlConnection conDatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True");
            SqlDataAdapter queryAdapter = new SqlDataAdapter(Query, conDatabase);
            DataSet ds = new DataSet();
            queryAdapter.Fill(ds,"mylist");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "mylist";
            //MySqlDataReader myReader;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf;Integrated Security=True";
            string Query2 = "DELETE FROM applicanttbl WHERE idnumber ='" + txtIdentityNumber.Text + "';";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase1 = new SqlCommand(Query2, conDatabase);
            SqlDataReader myReader;

            try
            {
                conDatabase.Open();           
                myReader = cmdDatabase1.ExecuteReader();
                MessageBox.Show("Deleted Successful", "Notice");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\Sgela\TryItOut\InsuranceApp\InsuranceDatabase.mdf; Integrated Security = True";
            string Query = "SELECT * FROM familytbl";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlDataAdapter queryAdapter = new SqlDataAdapter(Query, conDatabase);
            DataSet ds = new DataSet();
            queryAdapter.Fill(ds, "mylist");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "mylist";
            //MySqlDataReader myReader;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ChooseTheUse chooseTheUse = new ChooseTheUse();
            chooseTheUse.ShowDialog();
        }
    }
}
