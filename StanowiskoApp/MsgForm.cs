using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaowiskoApp
{
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {

        }
        public void UpdateForm(String cpt, String msg, int posX, int posY)
        {
            Text = cpt;
            label1.Text = msg;
            label1.Left = posX;
            label1.Top = posY;
            label1.Refresh();
        }
        public void UpdateProgressBar(int max, int step)
        {
            progressBarMsg.Maximum = max;
            progressBarMsg.Step = step; 
            progressBarMsg.Visible = true; 
            timerProgressBar.Enabled = true;
            timerProgressBar.Start();
        }
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarMsg.PerformStep();
        }
        private void FormMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            progressBarMsg.Visible = false;
            timerProgressBar.Enabled = false;
            timerProgressBar.Stop();
        }
    }
}
