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
using System.Media;

namespace SpringFieldNuclearAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reactor1Label_Click(object sender, EventArgs e)
        {

        }

        private void Reactor2Label_Click(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer (Properties.Resources.alert__1_);
            alertPlayer.Play();
         

            this.BackColor = Color.White;
            outputLabel.Text = "Meltdown Imminent";

            reactor1State.BackColor = Color.Red;
            reactor2State.BackColor = Color.Red;

            outputLabel.BackColor = Color.Red;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(800);

            reactor1State.BackColor = Color.Green;
            reactor2State.BackColor = Color.Green;


            outputLabel.BackColor = Color.Green;
            outputLabel.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(800);

            reactor1State.BackColor = Color.Red;
            reactor2State.BackColor = Color.Red;

            outputLabel.BackColor = Color.Red;
            outputLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(800);

            reactor1State.BackColor = Color.Green;
            reactor2State.BackColor = Color.Green;


            outputLabel.BackColor = Color.Green;
            outputLabel.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(800);

            reactor1State.BackColor = Color.Red;
            reactor2State.BackColor = Color.Red;

            outputLabel.BackColor = Color.Red;
            outputLabel.BackColor = Color.Red;


        }
    }
}
