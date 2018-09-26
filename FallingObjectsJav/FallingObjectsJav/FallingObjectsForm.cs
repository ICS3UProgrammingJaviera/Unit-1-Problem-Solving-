/*
 * Created by: Javiera
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Assignment #2 - Name of Program
 * This program calculates how close a falling object is to the ground from 100m with a varible height given by the user.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsJav
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void FallingObjectsForm_Load(object sender, EventArgs e)
        {
            //Hide these labels
            this.lblAnswer.Hide();
            this.lblStatment.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            double time, height;

            //convert time(textbox text) to a string
            time = double.Parse(txtTime.Text);

            //calculate formula
            height = 100 - 0.5 * 9.81 * Math.Pow(time, 2);

            //insert respectable labels to textbox
            this.lblAnswer.Text = Convert.ToString(height) + "m";

            //Show labels when calculate button is clicked
            this.lblAnswer.Show();
            this.lblStatment.Show();
        }
    }
}
