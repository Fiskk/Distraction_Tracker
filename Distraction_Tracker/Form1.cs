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

        List<Double> distratcionDurations = new List<Double>();

        public Form1()
        {
            InitializeComponent();

            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);

            stopWatchOverall.Start();
            stopWatchSinceLast.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This will need to send a row to the local DB every ~30 seconds

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
            this.numDistractions = 0;
            this.distractionCount.Text = this.numDistractions.ToString();

            this.stopWatchOverall.Stop();
            this.stopWatchSinceLast.Stop();

            this.stopWatchOverall.Start();
            this.stopWatchSinceLast.Start();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopWatchOverall.Start();
            stopWatchSinceLast.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
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

            this.distratcionDurations.Add(this.stopWatchSinceLast.Elapsed.TotalSeconds;

            TimeSpan averageDuration = this.distratcionDurations.Count > 0 ? this.distratcionDurations.Average() : 0.0;

            this.stopWatchSinceLast.Restart();
        }
    }
}
