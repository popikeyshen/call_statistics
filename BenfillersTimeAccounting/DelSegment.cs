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
    public partial class DelSegment : Form
    {
        public DelSegment()
        {
            InitializeComponent();
        }

        public int BenfillerId
        {
            get { return Convert.ToInt32(comboBoxBenfiller.SelectedValue); }
        }
        private void DelBenfillerForm_Load(object sender, EventArgs e)
        {
            comboBoxBenfiller.DataSource = DataEngine.GetAllSegments();
            comboBoxBenfiller.DisplayMember = "Название сегмента";
            comboBoxBenfiller.ValueMember = "Номер сегмента";

        }

        private void comboBoxBenfiller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
