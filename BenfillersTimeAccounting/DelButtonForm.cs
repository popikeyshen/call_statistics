using System;
using System.Windows.Forms;

namespace BenfillersTimeAccounting
{
    public partial class DelButtonForm : Form
    {
        public DelButtonForm()
        {
            InitializeComponent();
        }

        public int ButtonId
        {
            get { return Convert.ToInt32(comboBoxButtonID.SelectedValue); }

        }
        private void DelButtonForm_Load(object sender, EventArgs e)
        {
            comboBoxButtonID.DataSource = DataEngine.GetAllButtons();
            comboBoxButtonID.DisplayMember = "Номер кнопки";
            comboBoxButtonID.ValueMember = "Номер кнопки";
        }

        private void comboBoxButtonID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
