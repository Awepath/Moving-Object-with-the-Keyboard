using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Object_with_Arrow_Keys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (button1.Location.X == 0 || button1.Location.X == 410 || button1.Location.Y == 0 || button1.Location.Y == 224)
            {
                warning.Text = "You Shall NOT PASS";
            }
            else
            {
                warning.Text = "";
            }

       

            if (button1.Location.X != 0)
            {
                //A - LEFT
                if (e.KeyChar == 65 || e.KeyChar == 97)
                {
                    button1.Location = new Point(button1.Location.X - 1, button1.Location.Y);
                }
            }
     
            if (button1.Location.X != 410)
            {
                //D - RIGHT
                if (e.KeyChar == 68 || e.KeyChar == 100)
                {
                    button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);
                }
            }
        
            if (button1.Location.Y != 0)
            {

                //W - UP
                if ((e.KeyChar == 87 || e.KeyChar == 119))
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 1);
                }


            }
         
            if ( button1.Location.Y != 224)
            {
                //S - DOWN
                if (e.KeyChar == 83 || e.KeyChar == 115)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 1);
                }
            }
         
           
             
            locationTab.Text = "X: " + button1.Location.X.ToString() + " Y: " + button1.Location.Y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //You have to do "Key Preview: On"
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (button1.Location.X == 0 || button1.Location.X == 410 || button1.Location.Y == 0 || button1.Location.Y == 224)
            {
                warning.Text = "You Shall NOT PASS";
            }
            else
            {
                warning.Text = "0";
            }


     
            if (button1.Location.X != 0)
            {
                //Numpad4 - LEFT
             if (e.KeyCode == Keys.NumPad4)
                {
                    button1.Location = new Point(button1.Location.X - 1, button1.Location.Y);
                }
            }

            if (button1.Location.X != 410)
            {
                 //Numpad6 - RIGHT
             if (e.KeyCode == Keys.NumPad6)
                {
                    button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);
                }
            }
            if (button1.Location.Y != 0)
            {

                //Numpad8 - UP
                if (e.KeyCode == Keys.NumPad8)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 1);
                }
            }
            if (button1.Location.Y != 224)
            {
                 //Numpad2 - DOWN
            if (e.KeyCode == Keys.NumPad2)
                {
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 1);
                }
            }
            locationTab.Text = "X: " + button1.Location.X.ToString() + " Y: " + button1.Location.Y.ToString();
          

        }
    }
}
