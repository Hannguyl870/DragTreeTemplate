﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        int counter = 1;
        // TODO - create an int variable to track currentRow,
        // TODO - create a Stopwatch object called stopwatch 

        // TODO - create a timer on the form called lightTimer (interval 400ms)
        // TODO - create the tick event for the lightTimer

        // place the following comments in the lighTimer tick event
        // TODO - create a switch block that checks currentRow. In each case
        // it will light up the appropriate lights, (labels). 

        // TODO - increment the currentRow value by 1

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO - start the timer
                lighttimer.Enabled = true;
                stopwatch.Start();
            timeLabel.Text = stopwatch.Elapsed.ToString();

            counter++;


            //if (counter % 4 == 0)
            //{
            //    if (row1col1.BackColor = Color.DimGray)
            //    {
            //        row1col1.BackColor = Color.Red;
            //        row1col2.BackColor = Color.Red;
            //    }
            //   else if (row2col1.BackColor = Color.DimGray)
            //    {
            //        row2col1.BackColor = Color.Orange;
            //        row2col2.BackColor = Color.Orange;
            //    }
            //    else if (row3col2.BackColor = Color.DimGray)
            //    {
            //        row3col1.BackColor = Color.Yellow;
            //        row3col2.BackColor = Color.Yellow;
            //    }
            //    else
            //    {
            //        row4col1.BackColor = Color.Green;
            //        row4col2.BackColor = Color.Green;
            //    }

            //}
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch
            stopwatch.Stop();
          lighttimer.Enabled = false;
            
            
            // TODO - check if the ellapsed time in milliseconds is > 0. 
            // If yes show the time.
            // If no show "FOUL START" 

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch

            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen

            // TODO - reset row value and timeLabel text

        }

    }
}
