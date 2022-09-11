using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StaowiskoApp
{
    public partial class formTIC : Form
    {

        TicControls tic;
        //ToolTip ToolTipButtons;
        public formTIC()
        {
            InitializeComponent();
            tic = new TicControls();
        }
        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            tic.openTicSerialPort();

            Thread readThread = new Thread(tic.retTicType);
            readThread.Start();
            readThread.Join();
            String ticModel = tic.retTicModel();

            if (String.Compare(ticModel, "TIC100") == 0)
            {
                toolStripTextBox.Text = tic.retTicModel() + " " + tic.retTicSw_Ver() + " " + tic.retticSerial_Number();
                toolStripTextBox.BackColor = Color.GreenYellow;
                tabControlTic.Enabled = true;
            }
        }
        private void formTIC_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTipButtons = new System.Windows.Forms.ToolTip();
            ToolTipButtons.SetToolTip(buttonPumpTypeList, "See pump type list"); 
            ToolTipButtons.SetToolTip(buttonConfigTurboPump, "Master; preasure or voltage; setpoint; on/off");
        }
        private void formTIC_Shown(object sender, EventArgs e)
        {
            tic.readTicSettings();
        }
        private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
        {
            tic.closeTicSerialPort();
            toolStripTextBox.BackColor = Color.Gray;
            tabControlTic.Enabled = false;
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Clear();
        }

        private void modelButton_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.retTicModel();
        }

        private void swButton_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.retTicSw_Ver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.retticSerial_Number();  
        }

        private void formTIC_FormClosed(object sender, FormClosedEventArgs e)
        {
            tic.closeTicSerialPort();
            toolStripTextBox.BackColor = Color.Gray;
            tabControlTic.Enabled = false;
        }

  
        private void buttonTurboPumpStatus_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTicTurboPumpStatus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTicDevicesStatus();
        }

        private void buttonOnTurboPump_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setTicOnTurboPump();
        }

        private void buttonOffTurboPump_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setTicOffTurboPump();
        }

        private void buttonPumpTypeList_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getPumpTypeList();
        }

        private void buttonConfigTurboPump_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTurboPumpConfig();
        }

        private void buttonGetTurboPumpSpeed_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTurboPumpSpeed();
        }

        private void buttonGetTurboPumpStatus_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTurboPumpSpeedStatus();
        }

        private void buttonGetFailTime_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTurboPumpFailTime();
        }

        private void buttonSetFailTime_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setTurboPumpFailTime(textBoxFailTime.Text);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTurboPumpStbyStatus();
        }

        private void buttonTurboPumpStbyOn_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setTurboPumpStbyOn();
        }

        private void buttonTurboPumpStbyOff_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setTurboPumpStbyOff();
        }

        private void buttontTurboPumWorkTime_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getTurboPumpWorktime();
        }

        private void buttonBackingPumpStatus_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getBackingPumpStatus();
        }

        private void buttonBackingPumpOn_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setBackingPumpOn();
        }

        private void buttonBackingPumpOff_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.setBackingPumpOff();
        }

        private void buttonBackingPumpType_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getBackingPumpType();
        }

        private void buttonBackingPumpSpeed_Click(object sender, EventArgs e)
        {
            richTextBoxTic100Status.Text += Environment.NewLine + tic.getBackingPumpSpeed();
        }
        private void buttonGetBackingSequence_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
