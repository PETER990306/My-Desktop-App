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
    public partial class ChooseTheUse : Form
    {
        public ChooseTheUse()
        {
            InitializeComponent();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            this.Close();
            QUESTION question = new QUESTION();
            question.Show();
        }

        private void btnExistingMember_Click(object sender, EventArgs e)
        {
            this.Close();
            Information information = new Information();
            information.Show();
        }
    }
}
