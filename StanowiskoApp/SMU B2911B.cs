using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa.Interop;
using System.Windows.Forms;
using System.Threading;

namespace StaowiskoApp
{
    public partial class SMU_B2911B : Form
    {
        Thread t1;
        SmuControl ivSmu;
        FormMessage OrdersFormMsg;
        int command;
        private ResourceManager ioMgr = new ResourceManager(); 
        private FormattedIO488 instrument = null;               //wrzucić to do wątku t1 :)
        private const int WAIT_BEFORE_QUERY = 10;
        
        private SmuControl smu = new SmuControl();
        private delegate void Update(int s);

        public SMU_B2911B()
        {
            InitializeComponent(); 
        }

        private void SMU_B2911B_Shown(object sender, EventArgs e)
             {
              ivSmu = new SmuControl();
              
             }
        private void Operation(object command)
        {

                UpdateUI((int)(command));
                Thread.Sleep(10);
                command = 255; 
        }
        private void UpdateUI(int commandNr)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Update(UpdateUI), new object[] { commandNr });
            }
            else
            {
               // label2.Text = commandNr.ToString();
                
                switch(commandNr)
                    {
                        case 1: smuConnect(); break;
                        case 2: smuDisconnect(); break;
                        case 3: smuGetId(); break;
                    }
            }
        }

        private void smuConnect()
        {
            string buf;
            readSmuDeviceSettings ivAddres = new readSmuDeviceSettings();
            String address = ivAddres.MangleString(4);
            toolStripTextBox1.Text = address;


            if (ivSmu.OpenDevice(address))
            {
                toolStripTextBox1.BackColor = Color.GreenYellow;
                instrument = new FormattedIO488();
                instrument.IO = (IMessage)ioMgr.Open(address);
                instrument.IO.TerminationCharacterEnabled = true;
                System.Threading.Thread.Sleep(200);
                instrument.WriteString("*IDN?");
                System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                buf = instrument.ReadString().Trim();
                string[] tokens = buf.Split(',');
                toolStripLabelSmuSn.Text = "  " + buf.Split(',')[1] + " " + buf.Split(',')[0] + " " + buf.Split(',')[2];

            }
            else
            {
                MessageBox.Show(this, "Nie połączono.", "Error");
                toolStripTextBox1.BackColor = Color.Gray;
                toolStripTextBox1.Clear();
                return;
            }
        }
        private void smuDisconnect()
        {
            ivSmu.CloseDevice();
            toolStripTextBox1.BackColor = Color.Gray;
            toolStripLabelSmuSn.Text = "--------------";
            toolStripTextBox1.Clear();
            t1.Abort();
        }
        private void smuGetId()
        {
            string buf;
            instrument.WriteString("*IDN?");
            System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
            buf = instrument.ReadString().Trim();
            string[] tokens = buf.Split(',');
            //label2.Text = "  " + buf.Split(',')[1] + " " + buf.Split(',')[0] + " " + buf.Split(',')[2];
        }
        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            t1 = new Thread(Operation);
            t1.Start(1);
        }

        private void toolStripButtonDisconnect_Click(object sender, EventArgs e)
        {
            t1 = new Thread(Operation);
            t1.Start(2);
        }
        private void SMU_B2911B_FormClosed(object sender, FormClosedEventArgs e)
        {
            ivSmu.CloseDevice();
            toolStripTextBox1.BackColor = Color.Gray;
            toolStripLabelSmuSn.Text = "--------------";
            toolStripTextBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(Operation);
            t1.Start(3);
        }
        private void labelMode_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonSelfTest_Click(object sender, EventArgs e)
        {
            textBoxSelftTestResult.Text = "?";
            string message = "Disconnect test leads and cables from the channel terminals!";
            string caption = "Message!";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                OrdersFormMsg = new FormMessage();
                OrdersFormMsg.Show();
                OrdersFormMsg.UpdateForm("Wait!", "Test in progress...!", 100, 20);
                OrdersFormMsg.UpdateProgressBar(8, 1);
                ivSmu.SelfTestStart();
                timerSmu.Enabled = true;
                timerSmu.Interval = 8000;
                timerSmu.Start();
            }
        }
        private void timerSmu_Tick(object sender, EventArgs e)
        {
            String result = ivSmu.SelfTestStop();
            timerSmu.Stop();
            timerSmu.Enabled = false;
            if((Int16.Parse(result) == 0))
            {
                textBoxSelftTestResult.Text = "PASS";
            }
            else textBoxSelftTestResult.Text = "FAIL";
            OrdersFormMsg.Close();
        }
        private String calcMeanStep(String Start, String Stop, String Count)
        {
            String Step = "null"; float start, stop, count, step;

            start = float.Parse(Start); stop = float.Parse(Stop); count = float.Parse(Count);   
            step = Math.Abs((start - stop) / count);
            Step = step.ToString("0.000");
            textBoxStep.Text = Step;

            return Step;
        }
        private void makeSmuConfig()
        {
            int SourceFunction = comboBoxSourceFuncions.SelectedIndex;
            int Mode = comboBoxMode.SelectedIndex;
            int Shape = comboBoxShape.SelectedIndex;
            int Sweep = comboBoxSweep.SelectedIndex;
            int SourceRange = comboBoxSourceRange.SelectedIndex;
            int Timer = comboBoxTrigger.SelectedIndex;
            int MeanMode = comboBoxRange.SelectedIndex;

            ivSmu.addCompCom(textBoxCompliance.Text);
            ivSmu.addVoltCom(textBoxStart.Text);
            
            if (SourceFunction == 0)
            {
                
            }

            if (SourceFunction == 1)
            {
                switch(Mode)
                {
                    case 0: ivSmu.addModeVoltCom(); break;
                    case 1: ivSmu.addModeCurrCom(); break;
                }
                switch(Shape)
                {
                    case 0: ivSmu.addShapeDcCom();    break;
                    case 1: ivSmu.addShapePulseCom(); break;
                }

                int vStart = Int16.Parse(textBoxStart.Text);    
                int vStop = Int16.Parse(textBoxStop.Text);

                if (vStart < vStop) ivSmu.addSweDirUpCom();
                else ivSmu.addSweDirDownCom();

                switch (Sweep)
                {
                    case 0: ivSmu.addSweepLinearSingleCom(); break;
                    case 1: ivSmu.addSweepLinearDoubleCom(); break; 
                    case 2: ivSmu.addSweepLogSingleCom();    break;
                    case 3: ivSmu.addSweepLogDoubleCom();    break;
                    case 4: /* ivSmu.addSweepList(); */      break;
                }

                ivSmu.addStartVoltValCom(textBoxStart.Text);
                ivSmu.addStopVoltValCom(textBoxStop.Text);
                ivSmu.addStepNrCom(textBoxVar1Count.Text);
                calcMeanStep(textBoxStart.Text, textBoxStop.Text, textBoxVar1Count.Text);

                if (SourceRange == 0) ivSmu.addSourceRangeAutoCom();
                else ivSmu.addSourceRangeValCom(comboBoxSourceRange.Text);

                ivSmu.addOutputOnCom();

                ivSmu.addMeasureCounCom("1");
                ivSmu.addMeasureDelayCom("0.0");

                switch(MeanMode)
                {
                    case 0: ivSmu.addMeasureSourAutoCom(); break;
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: break;
                    case 8: break;
                    case 9: break;
                    case 10: break;
                    case 11: break;
                    case 12: break;
                    case 13: break;
                    case 14: break;
                    case 15: break;
                    case 16: break;
                    case 17: break;
                    case 18: break;
                    case 19: break;
                    case 20: break;
                    case 21: break;
                    case 22: break;
                }

                ivSmu.addTriggerStepsCountCom(textBoxVar1Count.Text);
                ivSmu.addTriggerDelCom(textBoxMeasureDelay.Text);
                switch (Timer)
                {
                    case 0: ivSmu.addTriggerAutoCom(); break;
                    case 1: ivSmu.addTriggerTimerCom(textBoxPeriod.Text); break;
                }

                ivSmu.SetSweepChannel();
                ivSmu.Initiate(new int[] { 1 });

                dataGridViewSmu.Rows.Clear();

                double xmax = double.MinValue;
                double xmin = double.MaxValue;
                double ymax = double.MinValue;
                double ymin = double.MaxValue;
                const int READ_SIZE = 20;
                double[,] data = new double[READ_SIZE, SmuControl.COLUMN_COUNT];
                bool isFirst = true;
                int actrow;

                ivSmu.GetData(1, isFirst, READ_SIZE, ref data, out actrow);

                for (int i = 0; i < actrow; i++)
                {
                    int row = dataGridViewSmu.Rows.Add(data[i, 0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5]);
                    dataGridViewSmu.Rows[row].HeaderCell.Value = (row + 1).ToString();
                    chart1.Series[0].Points.AddXY(data[i, 0], data[i, 1]);
                    if (data[i, 0] > xmax) xmax = data[i, 0];
                    if (data[i, 0] < xmin) xmin = data[i, 0];
                    if (data[i, 1] > ymax) ymax = data[i, 1];
                    if (data[i, 1] < ymin) ymin = data[i, 1];
                }
                scaleAdjust(false, chart1.ChartAreas[0], xmin, xmax, ymin, ymax);
                Application.DoEvents();
           
                scaleAdjust(true, chart1.ChartAreas[0], xmin, xmax, ymin, ymax);


        }
             void scaleAdjust(bool isLast, System.Windows.Forms.DataVisualization.Charting.ChartArea chartaria,
                                 double xDataMin, double xDataMax, double yDataMin, double yDataMax)
            {
                double resolution;
                resolution = Math.Pow(10.0, (int)Math.Floor(Math.Log10(xDataMax - xDataMin)) - 1);
                double new_xAxisMin = Math.Ceiling(xDataMin / resolution) * resolution;
                double new_xAxisMax = Math.Floor(xDataMax / resolution) * resolution;
                resolution = Math.Pow(10.0, (int)Math.Floor(Math.Log10(yDataMax - yDataMin)) - 1);
                double new_yAxisMin = Math.Ceiling(yDataMin / resolution) * resolution;
                double new_yAxisMax = Math.Floor(yDataMax / resolution) * resolution;
                if (isLast)
                {
                    chartaria.AxisX.Minimum = new_xAxisMin;
                    chartaria.AxisX.Maximum = new_xAxisMax;
                    chartaria.AxisY.Minimum = new_yAxisMin;
                    chartaria.AxisY.Maximum = new_yAxisMax;
                }
                else
                {
                    if (chartaria.AxisX.Minimum > new_xAxisMin) chartaria.AxisX.Minimum = new_xAxisMin;
                    if (chartaria.AxisX.Maximum < new_xAxisMax) chartaria.AxisX.Maximum = new_xAxisMax;
                    if (chartaria.AxisY.Minimum > new_yAxisMin) chartaria.AxisY.Minimum = new_yAxisMin;
                    if (chartaria.AxisY.Maximum < new_yAxisMax) chartaria.AxisY.Maximum = new_yAxisMax;
                }
            }

            if (SourceFunction == 2)
            {

            }

            if (SourceFunction == 3)
            {

            }

            if (SourceFunction == 4)
            {

            }

            switch (comboBoxSourceFuncions.SelectedIndex)
            {
                case 1: int i = 1; break;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            makeSmuConfig();
        }

        private void dataGridViewSmu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}



