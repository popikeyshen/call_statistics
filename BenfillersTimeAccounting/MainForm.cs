using System;
using System.Collections;
using System.Globalization;
using System.Text;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;
using System.Diagnostics;

namespace BenfillersTimeAccounting
{
    public partial class MainForm : Form
    {
        private readonly string[] _range = { "неделя","день", "час",  "месяц" };
        public MainForm()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
             //  String msg = "Bytes to read: " + serialPort1.BytesToRead;
             //  MessageBox.Show( msg + "\n" );
                if (serialPort1.BytesToRead % 3 != 0) return;
                //String msg = "Bytes to read: " + serialPort1.BytesToRead;
                StringBuilder sb = new StringBuilder(6);
                byte[] buf = new byte[3];
                int count = serialPort1.Read(buf, 0, 3);
                foreach (byte x in buf)
                {
                    sb.AppendFormat("{0:x2}", x);
                }
                //MessageBox.Show( msg + "\n" + sb.ToString());
                //-----------------------------------
                int buttonId = DataEngine.GetButtonIdByMacAddress(sb.ToString());
                if (DataEngine.IsCallButton(buttonId))
                {
                    DataEngine.AddCallEvent(buttonId);
                }
                else
                {
                    DataEngine.AddAcceptEvent(buttonId);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxCallsRange.DataSource = _range;
                comboBoxReactionsRange.DataSource = _range;


                serialPort1.PortName = Properties.Settings.Default.PortName;
                serialPort1.Open();

                //chart1.DataSource = DataEngine.GetReactionTimeByBenfillers();
                //chart1.DataBind();
                //chart1.DataSource = DataEngine.GetReactionTimeByBenfillers(comboBox1.SelectedValue.ToString());
                //chart1.DataBind();

                chartCalls.Series["Series1"].XValueMember = "LastName";
                chartCalls.Series["Series1"].YValueMembers = "Calls";

                chartReactions.Series["Series1"].XValueMember = "LastName";
                chartReactions.Series["Series1"].YValueMembers = "AvgReactionTime";

                chart1.Series["Series1"].XValueMember = "LastName";
                chart1.Series["Series1"].YValueMembers = "Calls";

                comboBox1.DataSource = DataEngine.GetAllBenfillers();
                comboBox1.DisplayMember = "Фамилия";
                comboBox1.ValueMember = "Номер участка";


               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void кнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var btnsForm = new ButtonsForm();
            btnsForm.Show();
        }


        private void приемникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var receiverForm = new ReceiverForm();
            if (receiverForm.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PortName = receiverForm.PortName;
                Program.mainForm.SerialPortMain.Close();
                Program.mainForm.SerialPortMain.PortName = receiverForm.PortName;
                Program.mainForm.SerialPortMain.Open();

            }
        }

        private void бенфиллерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var benfillersFrm = new BenfillersForm();
            benfillersFrm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход из приложения", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataEngine.CloseDB();
                Properties.Settings.Default.Save();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void comboBoxRange_SelectedValueChanged(object sender, EventArgs e)
        {
            chartCalls.DataSource = DataEngine.GetAcceptedEventCountsByBenfillers(comboBoxCallsRange.SelectedValue.ToString());
            chartCalls.DataBind();
        }

        private void comboBoxReactionsRange_SelectedValueChanged(object sender, EventArgs e)
        {
            chartReactions.DataSource = DataEngine.GetAverageReactionTimeByBenfillers(comboBoxReactionsRange.SelectedValue.ToString());
            chartReactions.DataBind();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.DataSource = DataEngine.GetReactionTimeByBenfillers(comboBox1.SelectedValue.ToString(), this.dateTimePicker1.Text, this.dateTimePicker2.Text, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            chart1.DataBind();
        }

        private void tabPageCalls_Enter(object sender, EventArgs e)
        {
            chartCalls.DataSource = DataEngine.GetAcceptedEventCountsByBenfillers(comboBoxCallsRange.SelectedValue.ToString());
            chartCalls.DataBind();
        }

        private void tabPageTimes_Enter(object sender, EventArgs e)
        {
            chartReactions.DataSource = DataEngine.GetAverageReactionTimeByBenfillers(comboBoxReactionsRange.SelectedValue.ToString());
            chartReactions.DataBind();
        }


          private void tabPage1_Enter(object sender, EventArgs e)
           {
            chart1.DataSource = DataEngine.GetReactionTimeByBenfillers(comboBox1.SelectedValue.ToString(), this.dateTimePicker1.Text, this.dateTimePicker2.Text, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            chart1.DataBind();
           }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение контроля времени работы официантов.\n(c) 2016", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartReactions_Click(object sender, EventArgs e)
        {

        }

        private void кухниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var btnsForm = new AddSegmentsForm();
            btnsForm.Show();
        }

        private void tabPageTimes_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
  
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {


       



        }

        private void comboBoxReactionsRange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            chart1.DataSource = DataEngine.GetReactionTimeByBenfillers(comboBox1.SelectedValue.ToString(), this.dateTimePicker1.Text, this.dateTimePicker2.Text, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            chart1.DataBind();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            chart1.DataSource = DataEngine.GetReactionTimeByBenfillers(comboBox1.SelectedValue.ToString(), this.dateTimePicker1.Text, this.dateTimePicker2.Text, this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            chart1.DataBind();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chartCalls_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            string cs = "URI=file:test.db";
            string data = String.Empty;

            int i = 0;
            int j = 0;
            int k = 0;
            SQLiteConnection con;

            using (con = new SQLiteConnection("Data Source=AvonBenfillers.sqlite;Version=3;"))
            {
                con.Open();

                string stm1 = "SELECT * FROM CallEvents      WHERE BenfillerID = '" + this.comboBox1.SelectedValue.ToString() + "'   AND strftime('%Y-%m-%d', AcceptTime) BETWEEN strftime('%Y-%m-%d', '" + this.dateTimePicker2.Text + "')  AND strftime('%Y-%m-%d', '" + this.dateTimePicker1.Text + "')";

                xlWorkSheet.Cells[i + 1, 5] = "Время вызова";
                xlWorkSheet.Cells[i + 1, 6] = "Время ответа";
                xlWorkSheet.Cells[i + 1, 7] = "Время реакции";

                using (SQLiteCommand cmd = new SQLiteCommand(stm1, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) // Reading Rows
                        {
                            for (j = 4; j <= 5; j++) // Looping throw colums
                            {
                                data = rdr.GetValue(j).ToString();
                                xlWorkSheet.Cells[i + 2, j + 1] = data;
                            }
                            i++;
                        }
                        k = rdr.FieldCount;
                    }
                }


                // var datee1 = (string)(xlWorkSheet.Cells[3, 5]).Value ;
                //var datee2 = (string)(xlWorkSheet.Cells[3, 6]).Value;
                // xlWorkSheet.Cells[3, 7] = datee1 - datee2;

                //xlWorkSheet.Cells[3, 7].Formula = 


                i = 0;
                string stm2 = "SELECT  strftime('%H:%M', CallTime) AS LastName, abs(strftime('%M', AcceptTime)-strftime('%M', CallTime) )  AS Calls FROM CallEvents WHERE BenfillerID = '" + this.comboBox1.SelectedValue.ToString() + "'   AND strftime('%Y-%m-%d', AcceptTime) BETWEEN strftime('%Y-%m-%d', '" + dateTimePicker2.Text + "')  AND strftime('%Y-%m-%d', '" + dateTimePicker1.Text + "')";
                using (SQLiteCommand cmd = new SQLiteCommand(stm2, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) // Reading Rows
                        {
                            for (j = 6; j <= 6; j++) // Looping throw colums
                            {
                                data = rdr.GetValue(1).ToString();
                                xlWorkSheet.Cells[i + 2, j + 1] = data;

                            }
                            i++;
                        }
                        k = rdr.FieldCount;
                    }
                }



                i = 0;
                string stm4 = "SELECT * FROM Benfillers WHERE BenfillerID = '" + this.comboBox1.SelectedValue.ToString() + "' ";

                using (SQLiteCommand cmd = new SQLiteCommand(stm4, con))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) // Reading Rows
                        {
                            for (j = 1; j <= 2; j++) // Looping throw colums
                            {
                                data = rdr.GetValue(j).ToString();
                                xlWorkSheet.Cells[i + 2, j + 1] = data;
                             
                            }
                            i++;
                        }
                        k = rdr.FieldCount;
                    }
                }

                con.Close();
            }

            string filepath = @"C:\excel\qliteToExcel.xls";
            xlWorkBook.SaveAs(filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

             
             Process.Start("EXCEL.EXE", filepath);
            //xlWorkBook.SaveAs(@"c:\test2.xls");
        }
    }
}
