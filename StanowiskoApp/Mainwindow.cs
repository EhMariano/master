using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace StaowiskoApp
{

    public partial class MainWindow : Form
    {

        public  MainWindow()
        {
            InitializeComponent();
           
    }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sMUB2911ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             SMU_B2911B OrdersForm = new SMU_B2911B();
             OrdersForm.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temperatureControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperature_Controller OrdersForm = new Temperature_Controller();
            OrdersForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings OrdersForm = new Settings();
            OrdersForm.Show();
        }

        private void turboInstrumentControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTIC OrdersForm = new formTIC();
            OrdersForm.Show();
        }
    }
}
