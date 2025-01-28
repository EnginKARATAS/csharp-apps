using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPort_GUI
{
    
    // a delegate is used to callback the update method 
    public delegate void UpdateForm(Byte[] buffer);

    // GUI part 
    public partial class Form1 : Form
    {
        SerialComm com1 = null;//a SerialComm class object.
        StreamWriter sw = null;//
        FileStream fs = null;//


        // Initializes a new instance of the <see cref="Form1"/> class.
        public Form1()
        {
            InitializeComponent();
            com1 = new SerialComm(this);//create a new SerialComm, and pass a reference(Form1)  
        }


        // Updates the text. It will update the form textbox. 
        // If it is neccesary, this method will update txt file at as well.
        public void UpdateText(Byte[] buffer)
        {
            String sentence = String.Format("{0}", Encoding.ASCII.GetString(buffer));
            msgDisplayTextBox.Text += sentence;


         

            
            

            //if the check box is checked, it will save this data to .txt file.

            if (openSaveFileDialogButton.Enabled == true)
            {
                sw.Write(sentence);
            }

        }


        // Handles the Click event of the openSaveFileDialogButton control.
        // open the openfile dialog
        private void openSaveFileDialogButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            filePathTextBox.Text = path.SelectedPath;
        }


        // Handles the DropDown event of the portNumberComboBox control.
        private void portNumberComboBox_DropDown(object sender, EventArgs e)
        {
            string[] SerialPorts = System.IO.Ports.SerialPort.GetPortNames();
            portNumberComboBox.Items.Clear();
            //show all available ports
            foreach (string com in SerialPorts)
            {
                portNumberComboBox.Items.Add(com);
            }
        }


        // Handles the CheckedChanged event of the isSaveFileCheckBox control.
        private void isSaveFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (isSaveFileCheckBox.Checked == true)
            {
                filePathTextBox.Enabled = true;
                openSaveFileDialogButton.Enabled = true;
                

            }
            else
            {
                filePathTextBox.Enabled = false;
                openSaveFileDialogButton.Enabled = false;
            }
        }


        // Handles the CheckedChanged event of the isSendCheckBox control.
        private void isSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isSendCheckBox.Enabled == true)
            {
                sendPeriodTextBox.Enabled = true;
                com1.SleepTime = Convert.ToInt16(sendPeriodTextBox.Text);
            }
            else 
            {
                sendPeriodTextBox.Enabled = false;
            }
        }


        // Handles the Click event of the openPortButton control.
        private void openPortButton_Click(object sender, EventArgs e)
        {
            if (openPortButton.Text == "Open")
            {
                if(this.isSaveFileCheckBox.Checked ==true)
                    OpenTxtStream();
                com1.SetPort(portNumberComboBox.Text, Convert.ToInt32(baudRateComboBox.Text));
                com1.Open();
                openPortButton.Text = "Close";

            }
            else
            {
                openPortButton.Text = "Open";
                com1.Close();
            }

        }


        // Handles the FormClosing event of the Form1 control.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            com1.Terminate();
            if (sw != null && fs != null)
            {
                sw.Close();
                fs.Close();
            }
        }


        // Handles the FormClosed event of the Form1 control.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        // Handles the TextChanged event of the msgDisplayTextBox control.
        private void msgDisplayTextBox_TextChanged(object sender, EventArgs e)
        {

            if (msgDisplayTextBox.Text.Length >= 100000)
                msgDisplayTextBox.Text = "";
        }


        // Handles the Click event of the sendButton control.
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (com1 != null && com1.IsOpen == true)
                //{
                    com1.WriteTimeout = Convert.ToInt32(writeTimeOutTextBox.Text);
                    com1.Write(sendMsgTextBox.Text);
                    
                //}
                //else
                //{

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sending message error: " + ex.Message, "Warning!");
            }
        }


        // Handles the Click event of the clearButton control.
        private void clearButton_Click(object sender, EventArgs e)
        {
            msgDisplayTextBox.Text = "";
        }

        // Opens the TXT stream.
        private void OpenTxtStream()
        {
            fs = null;
            DateTime NowTime = DateTime.Now;
            string dateString = NowTime.ToString("[yyyy-MM-dd]_HHmmss");
            string fileName = filePathTextBox.Text + dateString + "_Record.txt";
            try
            {
                fs = new FileStream(fileName,
                   FileMode.CreateNew, FileAccess.Write, FileShare.Read);
            }
            catch (ArgumentNullException ex)
            {
                fileName = dateString + "_Record.txt";
                fs = new FileStream(fileName,
                   FileMode.CreateNew, FileAccess.Write, FileShare.Read);
                MessageBox.Show(ex.Message + Environment.NewLine + "change folder");
            }

            sw = new StreamWriter(fs);

            sw.WriteLine("Record Time :" + NowTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;

                string[] liste = new string[3];
                listView1.Columns.Add("DATA", 100);
                listView1.Columns.Add("VALUE", 100);

    
        }

 
    }
    
    
    
}
