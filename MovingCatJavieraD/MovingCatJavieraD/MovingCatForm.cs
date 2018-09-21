
/*
 * Created by: Javiera Diaz
 * Created on: 17/09/18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program changs the images of the cat when a menu item is clicked
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

namespace MovingCatJavieraD
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //changes image to Cat 2
            this.picCat.Image = Properties.Resources.MovingCat2;
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //changes image from menu item to Cat 1
            this.picCat.Image = Properties.Resources.MovingCat1;
        }

        private void mniCat3_Click(object sender, EventArgs e)
        {
            //chnages image to Cat 3
            this.picCat.Image = Properties.Resources.MovingCat3;
        }

        private void mnuCats_Click(object sender, EventArgs e)
        {
        
        }

        private void picCat_Click(object sender, EventArgs e)
        {

        }
    }
}
