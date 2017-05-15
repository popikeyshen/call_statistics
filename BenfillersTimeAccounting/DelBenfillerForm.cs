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
    public partial class DelBenfillerForm : Form
    {
        public DelBenfillerForm()
        {
            InitializeComponent();
        }

        public int BenfillerId
        {
            get { return Convert.ToInt32(comboBoxBenfiller.SelectedValue); }
        }
        private void DelBenfillerForm_Load(object sender, EventArgs e)
        {
            comboBoxBenfiller.DataSource = DataEngine.GetAllBenfillers();
            comboBoxBenfiller.DisplayMember = "Фамилия";
            comboBoxBenfiller.ValueMember = "Номер участка";
        }

        private void comboBoxBenfiller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
