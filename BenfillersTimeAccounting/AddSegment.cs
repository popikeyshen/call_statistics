using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenfillersTimeAccounting
{
    public partial class AddSegment : Form
    {
        public AddSegment()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return Convert.ToInt32(textBoxBenfillerId.Text); }
        }

        public string value
        {
            get { return textBoxFirstName.Text; }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBenfillerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
