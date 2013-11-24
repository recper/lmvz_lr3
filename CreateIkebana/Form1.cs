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

        bool tips = true;
        

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
            h1lplab1.Visible = false;
            helplab2.Visible = tips;
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            plants.ShowDialog();
            helplab2.Visible = false;
            helplab3.Visible = tips;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbtnCreate_Click(object sender, EventArgs e)
        {
            helplab4.Visible = false;
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
            helplab3.Visible = false;
            helplab4.Visible = tips;
        }

        private void aboutPrToolStripMenuItem_Click(object sender, EventArgs e)
        {
    //        helpProvider1.SetHelpString(Control F1, string 
        }

        private void mbtnRestart_Click(object sender, EventArgs e)
        {
            
            h1lplab1.Visible = true;
            //flowers
            flo.btnNo_Click(sender,e);
            plants.pbtnNo_Click(sender, e);
            baskets.btnNo_Click(sender,e);
            mbtnIkebana.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbtnRestart_Click(sender,e);
        }


        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mbtnRestart_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void убрToolStripMenuItem_Click(object sender, EventArgs e)
        {
             tips = false;
             h1lplab1.Visible = false;
        }

        private void createTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             tips = true;
        }

    }
}