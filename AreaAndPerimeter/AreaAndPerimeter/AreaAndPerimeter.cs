/*
 * Created by: Javiera Diaz
 * Created on: 18/09/18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program calculates area and perimeter when the 'calculate' buttin is clicked by the user.
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

namespace AreaAndPerimeter
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();

            //Hide the perimeter, area, and answer labels until user clicks the calcuate button
            this.lblPerimeter.Hide();
            this.lblArea.Hide();
            this.lblPerimeterAnswer.Hide();
            this.lblAreaAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAreaAndPerimeter_Load(object sender, EventArgs e)
        {

        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculateButton_Click(object sender, EventArgs e)
        {
            //declare local variab;es
            int length, width, area, perimeter;

            //convert to string each textbox to an int
            length = int.Parse(txtLength.Text);
            width = int.Parse(txtWidth.Text);

            //calculate area and perimeter
            area = length * width;
            perimeter = (2 * length) + (2 * width);

            //respectable labels of area and perimeter have been inserted
            this.lblAreaAnswer.Text = Convert.ToString(area) + "cm squared";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + "cm";

            this.lblPerimeter.Show();
            this.lblArea.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeterAnswer.Show();

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
