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
    public partial class Quantity : Form
    {
        public Quantity()
        {
            InitializeComponent();
        }

        private void Quantity_Load(object sender, EventArgs e)
        {
            //loads the Quantity list box for you to select how many of each item you want.

            for (int count = 1; count <= 100; count++)
            {
                this.xNumListBox.Items.Add(count);
            }

            this.xNumListBox.SelectedIndex = 0;
        }

        private void xOkButton_Click(object sender, EventArgs e)
        {

            double Amount;

            //input
            Amount = Convert.ToDouble(this.xNumListBox.SelectedItem);
            Global.amount = Amount;
            Global.cost = Convert.ToDouble(Global.Price1) * Amount;
            
            Global.cost = tax(Global.cost);
            this.Close();
            
        }
        // subprocedure that someone sends to me with the variable of price
        public static double tax(double price)
        {
            price = price * .06 + price;
            return price;
        }

 
    }

}
