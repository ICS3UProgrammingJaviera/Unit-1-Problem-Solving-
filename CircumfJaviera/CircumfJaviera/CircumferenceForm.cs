/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Name of Program
 * This program calculates the circumference of a circle using a variable radius input by the user.
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

namespace CircumfJaviera
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variable
            double radius, circumference;

            //convert radius to string
            radius = double.Parse(txtVariable.Text);

            //calulate circumference
            circumference = 2 * Math.PI * radius;

            //assign answer to label
            this.lblCircAnswer.Text = Convert.ToString(circumference);

            //show the labels once button is clicked
            this.lblCircAnswer.Show();
            this.lblStatement.Show();
            
        }

        private void frmCircumference_Load(object sender, EventArgs e)
        {
            //Hide statements before calculate button is run
            this.lblStatement.Hide();
            this.lblCircAnswer.Hide();
        }
    }
}
