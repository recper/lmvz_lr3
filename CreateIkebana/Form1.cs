using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateIkebana
{
    public partial class Form1 : Form
    {
        Flowers flo = new Flowers();
        Plants plants = new Plants();
        Baskets baskets = new Baskets();
        ShowIkebanas ikebanas = new ShowIkebanas();
  public Form1()
        {
            AddOwnedForm(flo);
            AddOwnedForm(plants);
            AddOwnedForm(ikebanas);
            AddOwnedForm(baskets);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flo.ShowDialog();
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            plants.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbtnCreate_Click(object sender, EventArgs e)
        {
            if ((mbtn1.Image == flo.fbtn4.Image || mbtn1.Image == flo.fbtn5.Image || mbtn1.Image == flo.fbtn7.Image) && (mbtn2.Image == flo.fbtn5.Image || mbtn2.Image == flo.fbtn4.Image || mbtn2.Image == flo.fbtn7.Image) &&( mbtn3.Image == flo.fbtn7.Image || mbtn3.Image == flo.fbtn4.Image || mbtn3.Image == flo.fbtn5.Image))
            {
                mbtnIkebana.Image = ikebanas.button1.Image;
                mbtnIkebana.Visible = true;
            }
            if (mbtn1.Image == flo.fbtn8.Image || mbtn1.Image == flo.fbtn4.Image || mbtn1.Image == flo.fbtn10.Image)
            {
                mbtnIkebana.Image = ikebanas.button1.Image;
                mbtnIkebana.Visible = true;
            }

            if (mbtn1.Image == flo.fbtn1.Image || mbtn1.Image == flo.fbtn3.Image || mbtn1.Image == flo.fbtn12.Image)
            {
                mbtnIkebana.Image = ikebanas.button2.Image;
                mbtnIkebana.Visible = true;
            }

            if (mbtn1.Image == flo.fbtn7.Image || mbtn1.Image == flo.fbtn2.Image || mbtn1.Image == flo.fbtn11.Image)
            {
                mbtnIkebana.Image = ikebanas.button4.Image;
                mbtnIkebana.Visible = true;
            }

            if (mbtn1.Image == flo.fbtn9.Image || mbtn1.Image == flo.fbtn6.Image || mbtn1.Image == flo.fbtn5.Image)
            {
                mbtnIkebana.Image = ikebanas.button3.Image;
                mbtnIkebana.Visible = true;
            }

     }

        private void mbtn_Click(object sender, EventArgs e)
        {
            ikebanas.ShowDialog();
        }

        private void mbtnBaskets_Click(object sender, EventArgs e)
        {
            baskets.ShowDialog();
        }

        private void aboutPrToolStripMenuItem_Click(object sender, EventArgs e)
        {
    //        helpProvider1.SetHelpString(Control F1, string 
        }

   
    }
}