using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distraction_Tracker
{
    public partial class Form1 : Form
    {

        Stopwatch stopWatchOverall = new Stopwatch();
        Stopwatch stopWatchSinceLast = new Stopwatch();

        
        int numDistractions = 0;
        string currentElapsed;
        string sinceLastElapsed;

        TimeSpan averageTimeSinceLast = new TimeSpan(0, 0, 0);
        TimeSpan currentLongest = new TimeSpan(0, 0, 0);

        List<Double> distractionDurations = new List<Double>();
        Double averageDuration;

        public Form1()
        {
            InitializeComponent();

            // Start Stopwatches when program begins
            stopWatchOverall.Start();
            stopWatchSinceLast.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get elapsed times and set labels equal to stopwatches each tick of timer
            this.currentElapsed = stopWatchOverall.Elapsed.ToString("hh\\:mm\\:ss");
            this.sinceLastElapsed = stopWatchSinceLast.Elapsed.ToString("hh\\:mm\\:ss");

            this.totalElapsedTime.Text = this.currentElapsed;
            this.sinceLastElapsedTime.Text = this.sinceLastElapsed;
        }

        private void distractionCount_Click(object sender, EventArgs e)
        {

        }

        private void AverageAttention_Click(object sender, EventArgs e)
        {

        }

        private void longestAttention_Click(object sender, EventArgs e)
        {

        }

        private void resetAverage_Click(object sender, EventArgs e)
        {

        }

        private void resetAll_Click(object sender, EventArgs e)
        {
            // Reset distraction counter
            this.numDistractions = 0;
            this.distractionCount.Text = this.numDistractions.ToString();

            // Reset Average duration tracker
            this.averageDuration = 0;
            this.AverageAttention.Text = this.averageDuration.ToString();

            // Reset longest duration counter
            this.currentLongest = new TimeSpan(0, 0, 0);
            this.longestAttention.Text = Convert.ToString(0);

            // Empty duration list
            distractionDurations = new List<Double>();

            // Reset stopwatches
            this.stopWatchOverall.Restart();
            this.stopWatchSinceLast.Restart();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Start timers after having paused them
            stopWatchOverall.Start();
            stopWatchSinceLast.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // Pause timers
            stopWatchSinceLast.Stop();
            stopWatchOverall.Stop();
        }

        public void distractionButton_Click(object sender, EventArgs e)
        {
            this.numDistractions++;

            this.distractionCount.Text = this.numDistractions.ToString();

            // Compares the longest elapsed time since the last distraction
            // to the current elapsed time of the sinceLastDistraction stopwatch
            // and sets the current longest elapsed time counter accordingly.
            if ((TimeSpan.Compare(stopWatchSinceLast.Elapsed, this.currentLongest)) >= 0)
            {
                this.currentLongest = stopWatchSinceLast.Elapsed;
                this.longestAttention.Text = this.stopWatchSinceLast.Elapsed.ToString("hh\\:mm\\:ss");
            }

            // Add elapsed duration since last distraction to the list 
            this.distractionDurations.Add(this.stopWatchSinceLast.Elapsed.TotalSeconds);

            // Calculate average attention duration from List and convert back into Timespan
            Double averageDuration = this.distractionDurations.Count > 0 ? this.distractionDurations.Average() : 0.0;
            TimeSpan averageTimespanDuration = new TimeSpan(Convert.ToInt32(averageDuration));

            // Set AverageAttention label text property
            AverageAttention.Text = averageTimespanDuration.ToString("hh\\:mm\\:ss");

            this.stopWatchSinceLast.Restart();
        }
    }
}
