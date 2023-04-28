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

/*
    An app with two buttons: one that switches modes, and another that Starts / Stops,
    based on which mode the app is in, clock, timer, or stopwatch.
*/

namespace ClockTimerStopwatch
{
    public partial class Form1 : Form
    {
        enum Mode { Clock, Timer, Stopwatch };
        Mode currentMode = Mode.Clock;

        static System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.Text = "ClockTimerStopwatch";
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toggle.Enabled = false;
            timeDisplay.Text = System.DateTime.Now.ToShortTimeString().PadLeft(8, '0'); // 08:00 PM

            timer = new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Interval = 60000; // Update every minute
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    mode_Click(null, null);
                    break;
                case Keys.Space:
                    toggle_Click(null, null);
                    break;
            }
        }

        private void toggle_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Clock)
                return;

            if (toggle.Text == "Start")
            {
                toggle.Text = "Stop";
                if (currentMode == Mode.Stopwatch)
                    timeDisplay.Text = "00:00";
                timer.Start();
            }
            else { 
                toggle.Text = "Start";
                timer.Stop();
            }
        }

        private void mode_Click(object sender, EventArgs e)
        {
            // toggle
            currentMode += 1;
            if ((int)currentMode > 2)
                currentMode = 0;

            mode.Text = currentMode.ToString();
            toggle.Text = "Start";
            timer.Stop();
            timeDisplay.Text = "00:00";

            switch (currentMode)
            {
                case Mode.Clock:
                    //timeDisplay.Enabled = false;
                    toggle.Enabled = false;
                    timeDisplay.Text = System.DateTime.Now.ToShortTimeString().PadLeft(8, '0');
                    timer.Interval = 60000;
                    timer.Start();
                    break;
                case Mode.Timer:
                    timeDisplay.Enabled = true;
                    toggle.Enabled = true;
                    timer.Interval = 1000;
                    break;
                case Mode.Stopwatch:
                    break;
            }
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeDisplay.Invoke(new MethodInvoker(delegate
            {
                switch (currentMode)
                {
                    case Mode.Clock:
                        timeDisplay.Text = Count(timeDisplay.Text, 1);
                        break;
                    case Mode.Timer:
                        timeDisplay.Text = Count(timeDisplay.Text, -1);
                        break;
                    case Mode.Stopwatch:
                        timeDisplay.Text = Count(timeDisplay.Text, 1);
                        break;
                }
            }));
        }

        private string Count(string s, int polarity)
        {
            int hrs = 0;
            int mins = 0;

                try 
                { 
                    hrs = int.Parse(s.Substring(0, 2));
                    mins = int.Parse(s.Substring(3, 2));
                }
                catch 
                {
                    timer.Stop();
                    MessageBox.Show("Please enter a time in MM:SS format.");
                }

            bool modHour = false;
   
            switch (currentMode)
            {
                case Mode.Clock:
                    timeDisplay.Text = System.DateTime.Now.ToShortTimeString().PadLeft(8, '0');
                    break;
                case Mode.Timer:
                    if (mins > 0)
                        mins += polarity;
                    else
                        modHour = true;

                    if (modHour)
                    {
                        if (hrs > 0) 
                        { 
                            hrs += polarity;
                            mins = 59;
                        }
                        else 
                        {
                            toggle.Text = "Start";
                            timer.Stop();
                        }
                    }
                    break;
                case Mode.Stopwatch:
                    if (mins < 59)
                        mins += polarity;
                    else
                    {
                        mins = 0;
                        modHour = true;
                    }

                    if (modHour) 
                    {
                        if (hrs < 99)
                            hrs += polarity;
                        else
                            hrs = 0;
                    }
                    break;

            }

            return String.Format("{0}:{1}", hrs.ToString().PadLeft(2,'0'), mins.ToString().PadLeft(2, '0'));
        }
    }
}
