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
    public partial class AddBenfillerForm : Form
    {
        public AddBenfillerForm()
        {
            InitializeComponent();
        }

        public int BenfillerId
        {
            get { return Convert.ToInt32(textBoxBenfillerId.Text); }
        }

        public string FirstName
        {
            get { return textBoxFirstName.Text; }
        }

        public string LastName
        {
            get { return textBoxLastName.Text; }
        }
    }
}
