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

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            batBox.Visible = false;
            exitButton.Visible = false;
            titleLabel.Visible = false;

            countdownLabel.Text = "one";
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.beep);
            player1.PlaySync();
            Thread.Sleep(300);
            Refresh();

            countdownLabel.Text = "two";
            player1.PlaySync();
            Thread.Sleep(300);
            Refresh();

            countdownLabel.Text = "three";
            player1.PlaySync();
            Thread.Sleep(300);
            Refresh();

            countdownLabel.Text = "BEGIN";
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.heartbeat);
            player2.Play();
            Thread.Sleep(1000);
            Refresh();

            countdownLabel.Visible = false;
            BackColor = Color.Maroon;
            batBox.Visible = true;
            Refresh();

        }

        private void countdownLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
