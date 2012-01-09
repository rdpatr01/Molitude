using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POSV1
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //loading the timer
            this.xUnloadTimer.Start();
            this.xAnimTimer.Start();
            this.xSplashPanel.Left = (this.Width - this.xSplashPanel.Width) / 2;
            this.xSplashPanel.Top = (this.Height - this.xSplashPanel.Height) / 2;
        }
        private void unloadform()
        {
            //unloads and loads the pay calc form
            this.xUnloadTimer.Stop();

            Form Main = new Main();
            Main.Show();

            this.Hide();

        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //allows for a keypress to run the unload form
                unloadform();
            }
        }

        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            //allows for a keypress to run the unload form
            unloadform();
        }

        private void xSplashPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //allows for a keypress to run the unload form
            unloadform();
        }

        private void xUnloadTimer_Tick(object sender, EventArgs e)
        {
            unloadform();
        }

        private void xAnimTimer_Tick(object sender, EventArgs e)
        {
            this.xAnimTimer.Stop();
            int count;
            
            
                // this causes the picture to move from top to bottom. Reverse for bottom to top.
                for (count = 0; count <= 300; count++)
                {
                    this.xAnimPictureBox.Top = count;

                    

                }

                //this causes the picture to move from the left to the right. Reverse for right to left.
                // to increase by a certain amount do count+=4 or so forth
                for (count = 150; count <= 0; count--)
                {
                    this.xAnimPictureBox.Top = count;

                    
                    
                }

                
            

        }

   
    }
}
