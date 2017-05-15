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
    public partial class ButtonsForm : Form
    {
        public ButtonsForm()
        {
            InitializeComponent();
        }

        private void buttonAddBtn_Click(object sender, EventArgs e)
        {
            var addBtnFrm = new AddButtonForm();
            if (addBtnFrm.ShowDialog() == DialogResult.OK)
            {
                //Сохраняем кнопку в БД
                if (String.IsNullOrEmpty(addBtnFrm.MacAddress))
                {
                    MessageBox.Show("Не заполнено поле \'Mac address\'!");
                }
                else
                {
                    DataEngine.AddButton(addBtnFrm.MacAddress, addBtnFrm.ButtonNumber, '1', '1', addBtnFrm.ButtonType, "AC", addBtnFrm.BenfillerId,addBtnFrm.SegmentId );

                    dataGridViewButtons.DataSource = DataEngine.GetAllButtons();
                }
            }
        }

        private void ButtonsForm_Load(object sender, EventArgs e)
        {
            dataGridViewButtons.DataSource = DataEngine.GetAllButtons();
        }

        private void buttonDelBtn_Click(object sender, EventArgs e)
        {
            var delBtnFrm = new DelButtonForm();
            if (delBtnFrm.ShowDialog() == DialogResult.OK)
            {
                DataEngine.DelButton(delBtnFrm.ButtonId);
                dataGridViewButtons.DataSource = DataEngine.GetAllButtons();
            }
            
        }

        private void dataGridViewButtons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
