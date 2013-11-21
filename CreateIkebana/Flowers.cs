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
    public partial class Flowers : Form
    {
        private int quantatyOfChekedFlovers;
        public Flowers()
        {
            InitializeComponent();
            quantatyOfChekedFlovers = 0;
        }

        public bool CheckOne()
        {
            if (!((Form1)this.Owner).mbtn1.Visible)
                return true;      
            else
                return false;
        }

        public bool CheckTwo()
        {           
            if (!((Form1)this.Owner).mbtn2.Visible)
                return true;           
            else
                return false;
        }

        public bool CheckThree()
        {
            if (!((Form1)this.Owner).mbtn3.Visible)
                return true;
            else
                return false;
        }

        private void fbtn1_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn1.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb1.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn1.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb1.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn1.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb1.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }


            

           

           
        }

        private void fbtn2_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn2.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb2.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn2.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb2.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn2.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb2.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn3_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn3.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb3.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn3.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb3.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn3.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb3.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn4_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn4.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb4.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn4.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb4.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn4.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb4.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn5_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn5.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb5.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn5.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb5.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn5.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb5.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn6_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn6.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb6.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn6.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb6.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn6.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb6.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn7_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn7.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb7.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn7.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb7.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn7.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb7.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn8_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn8.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb8.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn8.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb8.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn8.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb8.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn9_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn9.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb9.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn9.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb9.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn9.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb9.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn10_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn10.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb10.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn10.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb10.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn10.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb10.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn11_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn11.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb11.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn11.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb11.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn11.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb11.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }

        private void fbtn12_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn1.Image = fbtn12.Image;
                ((Form1)this.Owner).mbtn1.Visible = true;
                ((Form1)this.Owner).mlb1.Text = flb12.Text;
                ((Form1)this.Owner).mlb1.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn2.Image = fbtn12.Image;
                ((Form1)this.Owner).mbtn2.Visible = true;
                ((Form1)this.Owner).mlb2.Text = flb12.Text;
                ((Form1)this.Owner).mlb2.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn3.Image = fbtn12.Image;
                ((Form1)this.Owner).mbtn3.Visible = true;
                ((Form1)this.Owner).mlb3.Text = flb12.Text;
                ((Form1)this.Owner).mlb3.Visible = true;
                return;
            }
        }


        private void btnNo_Click(object sender, EventArgs e)
        {
            quantatyOfChekedFlovers = 0;
            infoLabel.ForeColor = Color.Black;
            infoLabel.Font = new Font(infoLabel.Font.FontFamily, 10);
            foreach (Control x in this.Controls) {
                try
                {
                    ((Button)x).FlatAppearance.BorderSize = 0;
                }
                catch { }
            }
            ((Form1)this.Owner).mbtn1.Visible = false;
            ((Form1)this.Owner).mlb1.Visible = false;
            ((Form1)this.Owner).mbtn2.Visible = false;
            ((Form1)this.Owner).mlb2.Visible = false;
            ((Form1)this.Owner).mbtn3.Visible = false;
            ((Form1)this.Owner).mlb3.Visible = false;
        }

        private void fbtn8_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.FlatAppearance.BorderSize == 0)
            {
                if (quantatyOfChekedFlovers < 3)
                {
                    button.FlatAppearance.BorderSize = 2;
                    quantatyOfChekedFlovers++;
                }
                else
                {
                    infoLabel.ForeColor = Color.Red;
                    infoLabel.Font = new Font(infoLabel.Font.FontFamily, 13);
                }
            }
            else 
            {
                if (quantatyOfChekedFlovers > 0)
                {
                    button.FlatAppearance.BorderSize = 0;
                    quantatyOfChekedFlovers--;
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
