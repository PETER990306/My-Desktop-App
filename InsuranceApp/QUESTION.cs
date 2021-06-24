using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceApp
{
    public partial class QUESTION : Form
    {
        public QUESTION()
        {
            InitializeComponent();
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            this.Close();
            Individual indivi = new Individual();
            indivi.Show();
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            this.Close();
            Family family = new Family();
            family.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ChooseTheUse chooseTheUse = new ChooseTheUse();
            chooseTheUse.ShowDialog();
        }
    }
}
