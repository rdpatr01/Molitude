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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void xExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void xHelpButton_Click(object sender, EventArgs e)
        {
            //easter egg for everyone. Also a help button.
            for (int count = 1; count <= 5; count++)
            {
                DialogResult response;

                response = MessageBox.Show(" There is no help for you.", "All hope is lost", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    this.Close();
                    count = 5;

                }
                else
                {
                    DialogResult tresponse;

                    tresponse = MessageBox.Show(" Seriously, There is no help for you.", "All hope is lost", MessageBoxButtons.YesNo);

                    if (tresponse == DialogResult.Yes)
                    {
                        this.Close();
                        count = 5;
                    }
                    else
                    {
                        DialogResult bresponse;

                        bresponse = MessageBox.Show(" Seriously Mr. Booth, There is no help for you.", "All hope is lost", MessageBoxButtons.YesNo);
                        if (bresponse == DialogResult.Yes)
                        {
                            this.Close();
                            count = 5;
                        }
                        else
                        {
                            this.Close();
                            count = 5;
                        }
                    }


                }

            }

        }
    }
}
