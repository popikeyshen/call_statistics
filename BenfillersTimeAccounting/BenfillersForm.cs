using System;
using System.Windows.Forms;

namespace BenfillersTimeAccounting
{
    public partial class BenfillersForm : Form
    {
        public BenfillersForm()
        {
            InitializeComponent();
        }

        private void BenfillersForm_Load(object sender, EventArgs e)
        {
            dataGridViewBenfillers.DataSource = DataEngine.GetAllBenfillers();
        }

        private void buttonDelBenfiller_Click(object sender, EventArgs e)
        {
            var delBenfillerFrm = new DelBenfillerForm();
            if (delBenfillerFrm.ShowDialog() == DialogResult.OK)
            {
                DataEngine.DelBenfiller(delBenfillerFrm.BenfillerId);
                dataGridViewBenfillers.DataSource = DataEngine.GetAllBenfillers();
            }
        }

        private void buttonAddBenfiller_Click(object sender, EventArgs e)
        {
            var addBenfillerFrm = new AddBenfillerForm();
            if (addBenfillerFrm.ShowDialog() == DialogResult.OK)
            {
                DataEngine.AddBenfiller(addBenfillerFrm.BenfillerId, addBenfillerFrm.FirstName, addBenfillerFrm.LastName);
                dataGridViewBenfillers.DataSource = DataEngine.GetAllBenfillers();
            }
        }

        private void dataGridViewBenfillers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBenfillers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
