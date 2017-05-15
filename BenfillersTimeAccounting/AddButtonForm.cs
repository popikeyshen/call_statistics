using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenfillersTimeAccounting
{
    public partial class AddButtonForm : Form
    {
        SerialPort _serialPortLocal;
        private readonly string[] _buttonTypes = {"CALL", "ACCEPT"};
        private readonly string[] _sides = {"B", "AC"};
        public string MacAddress
        {
            get
            {
                return textBoxMacAddress.Text;
            }
            set
            {
                textBoxMacAddress.Text = value;
            }
        }
        public int ButtonNumber
        {
            get
            {
                return Convert.ToInt32(textBoxButtonNumber.Text);
            }
        }
        public int BenfillerId
        {
            get
            {
                return Convert.ToInt32(comboBoxBenfiller.SelectedValue);
            }
        }
        public int SegmentId
        {
            get
            {
                return Convert.ToInt32(comboBox1.SelectedValue);
            }
        }
        public string ButtonType
        {
            get
            {
                return comboBoxButtonTypes.SelectedValue.ToString();
            }
        }

        public AddButtonForm()
        {
            InitializeComponent();
            
            comboBoxButtonTypes.DataSource = this._buttonTypes;
            comboBoxBenfiller.DataSource = DataEngine.GetAllBenfillers();
            comboBoxBenfiller.DisplayMember = "Фамилия";
            comboBoxBenfiller.ValueMember = "Номер участка";
           comboBox1.DataSource = DataEngine.GetAllSegments();
            comboBox1.DisplayMember = "Название сегмента";
            comboBox1.ValueMember = "Номер сегмента";
        }

        private void serialPortMain_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                if ((sender as SerialPort).BytesToRead % 3 != 0) return; 
                StringBuilder sb = new StringBuilder(6);
                byte[] buf = new byte[3];
                int count = (sender as SerialPort).Read(buf, 0, 3);

                foreach (byte x in buf)
                {
                    sb.AppendFormat("{0:x2}", x);
                }
                textBoxMacAddress.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButtonForm_Load(object sender, EventArgs e)
        {
            Program.mainForm.SerialPortMain.Close();
            _serialPortLocal = new SerialPort(Program.mainForm.SerialPortMain.PortName,
                                             Program.mainForm.SerialPortMain.BaudRate);
            try
            {
                _serialPortLocal.Open();
                _serialPortLocal.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortMain_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButtonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _serialPortLocal.Close();
                Program.mainForm.SerialPortMain.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxLineNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxButtonNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxButtonTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBenfiller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMacAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
