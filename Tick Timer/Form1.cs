using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Timer
{
    public partial class Form1 : Form
    {
        string timeString;
        string userInput1;
        string userInput2;
        string userInput3;
        string userInput4;

        int numberOfClicks;

        int numberSeconds;
        int numberMinutes;
        int savedSeconds;
        int savedMinutes;
        string stringMinutes;
        string stringSeconds;

        public Form1()
        {
            InitializeComponent();
            startButton.Select();
        }

        public void writeTimer(string buttonNumber)
        {
            if (numberOfClicks == 1)
            {
                userInput1 = buttonNumber;
                timerBox.Text = "00:0" + timeString;
            }
            else if (numberOfClicks == 2)
            {
                userInput2 = buttonNumber;
                timerBox.Text = "00:" + timeString;
            }
            else if (numberOfClicks == 3)
            {
                userInput3 = buttonNumber;
                timerBox.Text = "0" + timeString[0] + ":" + timeString.Substring(1, 2);
            }
            else if (numberOfClicks == 4)
            {
                userInput4 = buttonNumber;
                timerBox.Text = timeString.Substring(0, 2) + ":" + timeString.Substring(2, 2);
            }
        }



        private void click_Event(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;

            if (pressedButton != null)
            {
                numberOfClicks = numberOfClicks + 1;
                timeString += pressedButton.Text;
                writeTimer(pressedButton.Text);
            }   
        }

        private void start_Event(object sender, EventArgs e)
        {
            timer1.Start();

            tableLayoutPanel1.Visible = false;

            timerBox2.Text = timerBox.Text;
            timerBox2.Visible = true;
            restartButton.Visible = true;
            adjustTimerButton.Visible = true;

            stringMinutes = timerBox.Text.Substring(0, 2);
            stringSeconds = timerBox.Text.Substring(3, 2);

            adjustIncorrectTimes(ref stringMinutes, ref stringSeconds);

            savedSeconds = Convert.ToInt32(stringSeconds);
            savedMinutes = Convert.ToInt32(stringMinutes);

            restartButton.Select();
        }

        private void adjustIncorrectTimes(ref string stringMinutes, ref string stringSeconds)
        {
            numberSeconds = Convert.ToInt32(stringSeconds);
            numberMinutes = Convert.ToInt32(stringMinutes);
            
            if (numberSeconds > 60)
            {
                numberSeconds = numberSeconds % 59;
                numberMinutes += 1;
            }

            stringSeconds = numberSeconds.ToString();
            stringMinutes = numberMinutes.ToString();
        }

        private void updateTimer()
        {
            if ((numberMinutes < 10) && (numberSeconds < 10))
                timerBox2.Text = "0" + stringMinutes + ":" + "0" + stringSeconds;
            else if (numberSeconds < 10)
                timerBox2.Text = stringMinutes + ":" + "0" + stringSeconds;
            else if (numberMinutes < 10)
                timerBox2.Text = "0" + stringMinutes + ":" + stringSeconds;
            else
                timerBox2.Text = stringMinutes + ":" + stringSeconds;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numberMinutes = Convert.ToInt32(stringMinutes);
            numberSeconds = Convert.ToInt32(stringSeconds);

            if (numberMinutes > 0) 
                numberSeconds = numberSeconds - 1;
            else if ((numberMinutes == 0) && (numberSeconds > 0))
                numberSeconds = numberSeconds - 1;


            if (numberSeconds < 0)
            {
                numberSeconds = 59;
                numberMinutes = numberMinutes - 1;
            }
            System.Diagnostics.Debug.WriteLine("2" + numberSeconds);

            if ((numberSeconds == 0) && (numberMinutes == 0))
            {
                timer1.Stop();
            }

            stringMinutes = numberMinutes.ToString();
            stringSeconds = numberSeconds.ToString();

            updateTimer();
             
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            stringSeconds = savedSeconds.ToString();
            stringMinutes = savedMinutes.ToString();
        }

        private void adjustTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tableLayoutPanel1.Visible = true;

            timerBox2.Visible = false;
            restartButton.Visible = false;
            adjustTimerButton.Visible = false;

            numberOfClicks = 0;
            timeString = "";
            timerBox.Text = "00:00";

            startButton.Select();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                numberOfClicks = numberOfClicks + 1;
                string pressedNumberText = e.KeyChar.ToString();
                timeString += pressedNumberText;
                writeTimer(pressedNumberText);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
