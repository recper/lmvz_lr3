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
    public partial class Plants : Form
    {
        private int quantatyOfChekedPlants;

        public Plants()
        {
            InitializeComponent();
            this.pbtn11.Click += new System.EventHandler(this.color_Click);
            this.pbtn12.Click += new System.EventHandler(this.color_Click);
            this.pbtn8.Click += new System.EventHandler(this.color_Click);
            this.pbtn4.Click += new System.EventHandler(this.color_Click);
            this.pbtn10.Click += new System.EventHandler(this.color_Click);
            this.pbtn6.Click += new System.EventHandler(this.color_Click);
            this.pbtn2.Click += new System.EventHandler(this.color_Click);
            this.pbtn3.Click += new System.EventHandler(this.color_Click);
            this.pbtn9.Click += new System.EventHandler(this.color_Click);
            this.pbtn7.Click += new System.EventHandler(this.color_Click);
            this.pbtn5.Click += new System.EventHandler(this.color_Click);
            this.pbtn1.Click += new System.EventHandler(this.color_Click);
        }

        public bool CheckOne()
        {
            if (!((Form1)this.Owner).mbtn4.Visible)
                return true;
            else
                return false;
        }

        public bool CheckTwo()
        {
            if (!((Form1)this.Owner).mbtn5.Visible)
                return true;
            else
                return false;
        }

        public bool CheckThree()
        {
            if (!((Form1)this.Owner).mbtn6.Visible)
                return true;
            else
                return false;
        }

        private void pbtn1_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn1.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb1.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn1.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb1.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn1.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb1.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        }

        private void pbtn2_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn2.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb2.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn2.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb2.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn2.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb2.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        }

        private void pbtn3_Click(object sender, EventArgs e)
        {

         if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn3.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb3.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn3.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb3.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn3.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb3.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn4_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn4.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb4.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn4.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb4.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn4.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb4.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn5_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn5.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb5.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn5.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb5.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn5.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb5.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn6_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn6.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb6.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn6.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb6.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn6.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb6.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn7_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn7.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb7.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn7.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb7.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn7.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb7.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn8_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn8.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb8.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn8.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb8.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn8.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb8.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn9_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn9.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb9.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn9.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb9.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn9.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb9.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        
        }

        private void pbtn10_Click(object sender, EventArgs e)
        {
             if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn10.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb10.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn10.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb10.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn10.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb10.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        }

        private void pbtn11_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn11.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb11.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn11.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb11.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn11.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb11.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
 
        }

        private void pbtn12_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn4.Image = pbtn12.Image;
                ((Form1)this.Owner).mbtn4.Visible = true;
                ((Form1)this.Owner).mlb4.Text = plb12.Text;
                ((Form1)this.Owner).mlb4.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn5.Image = pbtn12.Image;
                ((Form1)this.Owner).mbtn5.Visible = true;
                ((Form1)this.Owner).mlb5.Text = plb12.Text;
                ((Form1)this.Owner).mlb5.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn6.Image = pbtn12.Image;
                ((Form1)this.Owner).mbtn6.Visible = true;
                ((Form1)this.Owner).mlb6.Text = plb12.Text;
                ((Form1)this.Owner).mlb6.Visible = true;
                return;
            }
        }

        internal void pbtnNo_Click(object sender, EventArgs e)
        {
            quantatyOfChekedPlants = 0;
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font(infoLabel.Font.FontFamily, 10);
            foreach (Control x in this.Controls)
            {
                try
                {
                    ((Button)x).FlatAppearance.BorderSize = 0;
                }
                catch { }
            }
            ((Form1)this.Owner).mbtn4.Visible = false;
            ((Form1)this.Owner).mlb4.Visible = false;
            ((Form1)this.Owner).mbtn5.Visible = false;
            ((Form1)this.Owner).mlb5.Visible = false;
            ((Form1)this.Owner).mbtn6.Visible = false;
            ((Form1)this.Owner).mlb6.Visible = false;
        }

        private void color_Click(object sender, EventArgs e)
        {
                Button button = (Button)sender;
                if (button.FlatAppearance.BorderSize == 0)
                {
                    if (quantatyOfChekedPlants < 3)
                    {
                        button.FlatAppearance.BorderSize = 2;
                        quantatyOfChekedPlants++;
                    }
                    else
                    {
                        infoLabel.ForeColor = Color.Red;
                        infoLabel.Font = new Font(infoLabel.Font.FontFamily, 13);
                    }
                }
                else
                {
                    if (quantatyOfChekedPlants > 0)
                    {
                        button.FlatAppearance.BorderSize = 0;
                        quantatyOfChekedPlants--;
                        infoLabel.ForeColor = Color.Black;
                        infoLabel.Font = new Font(infoLabel.Font.FontFamily, 10);
                    }
                    else
                    {
                        //TODO
                    }
                }   
            }
    }
}
