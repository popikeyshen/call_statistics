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
    public partial class AddSegmentsForm : Form
    {
        public AddSegmentsForm()
        {
            InitializeComponent();
        }



        private void dataGridViewBenfillers_Load(object sender, EventArgs e)
        {
            dataGridViewBenfillers.DataSource = DataEngine.GetAllSegments();
        }

        private void dataGridViewBenfillers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void buttonAddBenfiller_Click(object sender, EventArgs e)
        {
            var addBenfillerFrm = new AddSegment();
            if (addBenfillerFrm.ShowDialog() == DialogResult.OK)
            {
                DataEngine.AddSegment(addBenfillerFrm.Id, addBenfillerFrm.value);
                dataGridViewBenfillers.DataSource = DataEngine.GetAllSegments();
            }
            //DataEngine.AddSegmentBase();
        }

        private void buttonDelBenfiller_Click(object sender, EventArgs e)
        {
            var delBenfillerFrm = new DelSegment();
            if (delBenfillerFrm.ShowDialog() == DialogResult.OK)
            {
                DataEngine.DelSegment(delBenfillerFrm.BenfillerId);
                dataGridViewBenfillers.DataSource = DataEngine.GetAllSegments();
            }
        }

        private void dataGridViewBenfillers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
