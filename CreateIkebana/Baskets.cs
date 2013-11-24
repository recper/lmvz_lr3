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
    public partial class Baskets : Form
    {
        private int quantatyOfChekedBaskets;
        public Baskets()
        {
            quantatyOfChekedBaskets = 0;
            InitializeComponent();
            this.fbtn11.Click += new System.EventHandler(this.color_Click);
            this.fbtn12.Click += new System.EventHandler(this.color_Click);
            this.fbtn8.Click += new System.EventHandler(this.color_Click);
            this.fbtn4.Click += new System.EventHandler(this.color_Click);
            this.fbtn10.Click += new System.EventHandler(this.color_Click);
            this.fbtn6.Click += new System.EventHandler(this.color_Click);
            this.fbtn2.Click += new System.EventHandler(this.color_Click);
            this.fbtn3.Click += new System.EventHandler(this.color_Click);
            this.fbtn9.Click += new System.EventHandler(this.color_Click);
            this.fbtn7.Click += new System.EventHandler(this.color_Click);
            this.fbtn5.Click += new System.EventHandler(this.color_Click);
            this.fbtn1.Click += new System.EventHandler(this.color_Click);

        }

        public bool CheckOne()
        {
            if (!((Form1)this.Owner).mbtn7.Visible)
                return true;
            else
                return false;
        }

        public bool CheckTwo()
        {
            if (!((Form1)this.Owner).mbtn8.Visible)
                return true;
            else
                return false;
        }

        public bool CheckThree()
        {
            if (!((Form1)this.Owner).mbtn9.Visible)
                return true;
            else
                return false;
        }

        private void fbtn1_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn1.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb1.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn1.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb1.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn1.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb1.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn2_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn2.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb2.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn2.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb2.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn2.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb2.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn3_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn3.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb3.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn3.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb3.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn3.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb3.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn4_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn4.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb4.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn4.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb4.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn4.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb4.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn5_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn5.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb5.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn5.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb5.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn5.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb5.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn6_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn6.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb6.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn6.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb6.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn6.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb6.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn7_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn7.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb7.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn7.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb7.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn7.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb7.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn8_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn8.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb8.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn8.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb8.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn8.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb8.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn9_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn9.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb9.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn9.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb9.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn9.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb9.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn10_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn10.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb10.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn10.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb10.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn10.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb10.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn11_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn11.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb11.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn11.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb11.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn11.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb11.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        private void fbtn12_Click(object sender, EventArgs e)
        {
            if (CheckOne())
            {
                ((Form1)this.Owner).mbtn7.Image = fbtn12.Image;
                ((Form1)this.Owner).mbtn7.Visible = true;
                ((Form1)this.Owner).mlb7.Text = flb12.Text;
                ((Form1)this.Owner).mlb7.Visible = true;
                return;
            }

            if (CheckTwo())
            {
                ((Form1)this.Owner).mbtn8.Image = fbtn12.Image;
                ((Form1)this.Owner).mbtn8.Visible = true;
                ((Form1)this.Owner).mlb8.Text = flb12.Text;
                ((Form1)this.Owner).mlb8.Visible = true;
                return;
            }

            if (CheckThree())
            {
                ((Form1)this.Owner).mbtn9.Image = fbtn12.Image;
                ((Form1)this.Owner).mbtn9.Visible = true;
                ((Form1)this.Owner).mlb9.Text = flb12.Text;
                ((Form1)this.Owner).mlb9.Visible = true;
                return;
            }
        }

        internal void btnNo_Click(object sender, EventArgs e)
        {
            quantatyOfChekedBaskets = 0;
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
            ((Form1)this.Owner).mbtn7.Visible = false;
            ((Form1)this.Owner).mlb7.Visible = false;
            ((Form1)this.Owner).mbtn8.Visible = false;
            ((Form1)this.Owner).mlb8.Visible = false;
            ((Form1)this.Owner).mbtn9.Visible = false;
            ((Form1)this.Owner).mlb9.Visible = false;
        }

        private void color_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.FlatAppearance.BorderSize == 0)
            {
                if (quantatyOfChekedBaskets < 3)
                {
                    button.FlatAppearance.BorderSize = 2;
                    quantatyOfChekedBaskets++;
                }
                else
                {
                    infoLabel.ForeColor = Color.Red;
                    infoLabel.Font = new Font(infoLabel.Font.FontFamily, 13);
                }
            }
            else
            {
                if (quantatyOfChekedBaskets > 0)
                {
                    button.FlatAppearance.BorderSize = 0;
                    quantatyOfChekedBaskets--;
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
