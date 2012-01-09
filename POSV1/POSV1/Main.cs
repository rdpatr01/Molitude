/*
 * Author: Russell Patrick
 * Csc 240
 * Lab 4
 * Uses the Global.cs, Quantity.cs, and a gif at later intervals.
 * Honorable Mentions:
*/
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
    public partial class Main : Form
    {
 
        int item1,item2,item3,item4,item5,item6,item7,item8,item9,item10,item11,item12;
        double tprice1;
        double tprice2;
        double tprice3;
        double tprice4;
        double tprice5;
        double tprice6;
        double tprice7;
        double tprice8;
        double tprice9;
        double tprice10;
        double tprice11;
        double tprice12;
        double total;
        string V1, V2, V3, V4, V5, V6, V7;
        double cash;

        public Main()
        {
            InitializeComponent();
        }

        private void xSmallPopcornButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 3;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item1 = Convert.ToInt32(Global.amount);
            tprice1 = Convert.ToDouble(Global.cost);
            this.xSmlPopAmtLabel.Text = item1.ToString();
            this.xSmlPopOutLabel.Text = tprice1.ToString("C");
            this.xSmlPopAmtLabel.Visible = true;
            this.xSmlPopOutLabel.Visible = true;
            this.xSmallPopLabel.Visible = true;

        }

        private void xMediumPopcornButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 4;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item2 = Convert.ToInt32(Global.amount);
            tprice2 = Convert.ToDouble(Global.cost);
            this.xMedPopAmtLabel.Text = item2.ToString();
            this.xMedPopOutLabel.Text = tprice2.ToString("C");
            this.xMedPopAmtLabel.Visible = true;
            this.xMedPopOutLabel.Visible = true;
            this.xMedPopLabel.Visible = true;
        }

        private void xLargePopcornButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 5;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item3 = Convert.ToInt32(Global.amount);
            tprice3 = Convert.ToDouble(Global.cost);
            this.xLrgPopAmtLabel.Text = item3.ToString();
            this.xLrgPopOutLabel.Text = tprice3.ToString("C");
            this.xLrgPopAmtLabel.Visible = true;
            this.xLrgPopOutLabel.Visible = true;
            this.xLrgPopLabel.Visible = true;
        }

        private void xSmallDrinkButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 2.50;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item4 = Convert.ToInt32(Global.amount);
            tprice4 = Convert.ToDouble(Global.cost);
            this.xSmlDrkAmtLabel.Text = item4.ToString();
            this.xSmlDrkOutLabel.Text = tprice4.ToString("C");
            this.xSmlDrkAmtLabel.Visible = true;
            this.xSmlDrkOutLabel.Visible = true;
            this.xSmlDrinkLabel.Visible = true;
        }

        private void xMedDrinkButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 3.50;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item5 = Convert.ToInt32(Global.amount);
            tprice5 = Convert.ToDouble(Global.cost);
            this.xMedDrkAmtLabel.Text = item5.ToString();
            this.xMedDrkOutLabel.Text = tprice5.ToString("C");
            this.xMedDrkAmtLabel.Visible = true;
            this.xMedDrkOutLabel.Visible = true;
            this.xMedDrinkLabel.Visible = true;
        }

        private void xLrgDrinkButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 4.50;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item6 = Convert.ToInt32(Global.amount);
            tprice6 = Convert.ToDouble(Global.cost);
            this.xLrgDrkAmtLabel.Text = item6.ToString();
            this.xLrgDrkOutLabel.Text = tprice6.ToString("C");
            this.xLrgDrkAmtLabel.Visible = true;
            this.xLrgDrkOutLabel.Visible = true;
            this.xLargeDrinkLabel.Visible = true;
        }

        private void xSmallCandyButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 2;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item7 = Convert.ToInt32(Global.amount);
            tprice7 = Convert.ToDouble(Global.cost);
            this.xSmlCanAmtLabel.Text = item7.ToString();
            this.xSmlCanOutLabel.Text = tprice7.ToString("C");
            this.xSmlCanAmtLabel.Visible = true;
            this.xSmlCanOutLabel.Visible = true;
            this.xSmlCandyLabel.Visible = true;
        }

        private void xMedCandyButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 3;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item8 = Convert.ToInt32(Global.amount);
            tprice8 = Convert.ToDouble(Global.cost);
            this.xMedCanAmtLabel.Text = item8.ToString();
            this.xMedCanOutLabel.Text = tprice8.ToString("C");
            this.xMedCanAmtLabel.Visible = true;
            this.xMedCanOutLabel.Visible = true;
            this.xMedCandyLabel.Visible = true;
        }

        private void xLrgCandyButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 4;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item9 = Convert.ToInt32(Global.amount);
            tprice9 = Convert.ToDouble(Global.cost);
            this.xLrgCanAmtLabel.Text = item9.ToString();
            this.xLrgCanOutLabel.Text = tprice9.ToString("C");
            this.xLrgCanAmtLabel.Visible = true;
            this.xLrgCanOutLabel.Visible = true;
            this.xLrgCandyLabel.Visible = true;
        }

        private void xSmallComboButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 5.50;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item10 = Convert.ToInt32(Global.amount);
            tprice10 = Convert.ToDouble(Global.cost);
            this.xSmlComAmtLabel.Text = item10.ToString();
            this.xSmlComOutLabel.Text = tprice10.ToString("C");
            this.xSmlComAmtLabel.Visible = true;
            this.xSmlComOutLabel.Visible = true;
            this.xSmallComboLabel.Visible = true;
        }

        private void xMedComboButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 6.50;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item11 = Convert.ToInt32(Global.amount);
            tprice11 = Convert.ToDouble(Global.cost);
            this.xMedComAmtLabel.Text = item11.ToString();
            this.xMedComOutLabel.Text = tprice11.ToString("C");
            this.xMedComAmtLabel.Visible = true;
            this.xMedComOutLabel.Visible = true;
            this.xMedComboLabel.Visible = true;
        }

        private void xLrgComboButton_Click(object sender, EventArgs e)
        {
            //this codes the button and send the information on to the next form
            double price1 = 7.50;
            Global.Price1 = price1.ToString();
            Form copydialogform = new Quantity();
            copydialogform.ShowDialog();
            item12 = Convert.ToInt32(Global.amount);
            tprice12 = Convert.ToDouble(Global.cost);
            this.xLrgComAmtLabel.Text = item12.ToString();
            this.xLrgComOutLabel.Text = tprice12.ToString("C");
            this.xLrgComAmtLabel.Visible = true;
            this.xLrgComOutLabel.Visible = true;
            this.xLrgComboLabel.Visible = true;
        }

        private void xExitButton_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void xClearButton_Click(object sender, EventArgs e)
        {
            // Dialog Exit box
            DialogResult response;

            response = MessageBox.Show("Are you sure you want to clear the form?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            // this clears the form.
            if (response == DialogResult.Yes)
            {
                total = 0;

                tprice1 = 0;
                tprice2 = 0;
                tprice3 = 0;
                tprice4 = 0;
                tprice5 = 0;
                tprice6 = 0;
                tprice7 = 0;
                tprice8 = 0;
                tprice9 = 0;
                tprice10 = 0;
                tprice11 = 0;
                tprice12 = 0;

                V1 = null;
                V2 = null;
                V3 = null;
                V4 = null;
                V5 = null;
                V6 = null;
                V7 = null;

                this.xChangeLabel.Visible = false;
                this.xChangeOutLabel.Visible = false;

                this.xSmlPopAmtLabel.Visible = false;
                this.xSmlPopOutLabel.Visible = false;
                this.xSmallPopLabel.Visible = false;
                this.xSmlPopAmtLabel.Text =null;
                this.xSmlPopOutLabel.Text = null;


                this.xSmlCanAmtLabel.Visible = false;
                this.xSmlCanOutLabel.Visible = false;
                this.xSmlCandyLabel.Visible = false;
                this.xSmlCanAmtLabel.Text =null;
                this.xSmlCanOutLabel.Text = null;

                this.xSmlDrkAmtLabel.Visible = false;
                this.xSmlDrkOutLabel.Visible = false;
                this.xSmlDrinkLabel.Visible = false;
                this.xSmlDrkAmtLabel.Text =null;
                this.xSmlDrkOutLabel.Text = null;

                this.xSmlComAmtLabel.Visible = false;
                this.xSmlComOutLabel.Visible = false;
                this.xSmallComboLabel.Visible = false;
                this.xSmlComAmtLabel.Text = null;
                this.xSmlComOutLabel.Text = null;


                this.xMedPopAmtLabel.Visible = false;
                this.xMedPopOutLabel.Visible = false;
                this.xMedPopLabel.Visible = false;
                this.xMedPopAmtLabel.Text = null;
                this.xMedPopOutLabel.Text = null;

                this.xMedCanAmtLabel.Visible = false;
                this.xMedCanOutLabel.Visible = false;
                this.xMedCandyLabel.Visible = false;
                this.xMedCanAmtLabel.Text = null;
                this.xMedCanOutLabel.Text = null;



                this.xMedDrkAmtLabel.Visible = false;
                this.xMedDrkOutLabel.Visible = false;
                this.xMedDrinkLabel.Visible = false;
                this.xMedDrkAmtLabel.Text = null;
                this.xMedDrkOutLabel.Text = null;


                this.xMedComAmtLabel.Visible = false;
                this.xMedComOutLabel.Visible = false;
                this.xMedComboLabel.Visible = false;
                this.xMedComAmtLabel.Text = null;
                this.xMedComAmtLabel.Text = null;


                this.xLrgPopAmtLabel.Visible = false;
                this.xLrgPopOutLabel.Visible = false;
                this.xLrgPopLabel.Visible = false;
                this.xLrgPopAmtLabel.Text = null;
                this.xLrgPopOutLabel.Text = null;


                this.xLrgCanAmtLabel.Visible = false;
                this.xLrgCanOutLabel.Visible = false;
                this.xLrgCandyLabel.Visible = false;
                this.xLrgCanAmtLabel.Text = null;
                this.xLrgCanOutLabel.Text = null;


                this.xLrgDrkAmtLabel.Visible = false;
                this.xLrgDrkOutLabel.Visible = false;
                this.xLargeDrinkLabel.Visible = false;
                this.xLrgDrkAmtLabel.Text = null;
                this.xLrgDrkOutLabel.Text = null;


                this.xLrgComAmtLabel.Visible = false;
                this.xLrgComOutLabel.Visible = false;
                this.xLrgComboLabel.Visible = false;
                this.xLrgComAmtLabel.Text = null;
                this.xLrgComOutLabel.Text = null;

                this.xTotalLabel.Visible = false;
                this.xTotalOutLabel.Visible = false;
                this.xTotalOutLabel.Text = null;

                this.xTenderOutLabel.Visible = false;
                this.xTenderLabel.Visible = false;
                this.xTenderOutLabel.Text = null; 

            }
        }

        private void xTotalButton_Click(object sender, EventArgs e)
        {
            //calculates and shows the calc total.
            total = tprice1 + tprice2 + tprice3 + tprice4 + tprice5 + tprice6 + tprice7 + tprice8 + tprice9 + tprice10 + tprice11 + tprice12;

            xTotalLabel.Visible = true;
            xTotalOutLabel.Visible = true;
            xTotalOutLabel.Text = total.ToString("C");
        }

        private void xCreditButton_Click(object sender, EventArgs e)
        {
            if (this.xTotalOutLabel.Visible)
            {
                //tenders the amount in credit.
                this.xTenderOutLabel.Visible = true;
                this.xTenderLabel.Visible = true;
                this.xTenderOutLabel.Text = total.ToString("C");

                MessageBox.Show("Sale Completed");

                total = 0;

                tprice1 = 0;
                tprice2 = 0;
                tprice3 = 0;
                tprice4 = 0;
                tprice5 = 0;
                tprice6 = 0;
                tprice7 = 0;
                tprice8 = 0;
                tprice9 = 0;
                tprice10 = 0;
                tprice11 = 0;
                tprice12 = 0;

                V1 = null;
                V2 = null;
                V3 = null;
                V4 = null;
                V5 = null;
                V6 = null;
                V7 = null;

                this.xChangeLabel.Visible = false;
                this.xChangeOutLabel.Visible = false;

                this.xSmlPopAmtLabel.Visible = false;
                this.xSmlPopOutLabel.Visible = false;
                this.xSmallPopLabel.Visible = false;
                this.xSmlPopAmtLabel.Text = null;
                this.xSmlPopOutLabel.Text = null;


                this.xSmlCanAmtLabel.Visible = false;
                this.xSmlCanOutLabel.Visible = false;
                this.xSmlCandyLabel.Visible = false;
                this.xSmlCanAmtLabel.Text = null;
                this.xSmlCanOutLabel.Text = null;

                this.xSmlDrkAmtLabel.Visible = false;
                this.xSmlDrkOutLabel.Visible = false;
                this.xSmlDrinkLabel.Visible = false;
                this.xSmlDrkAmtLabel.Text = null;
                this.xSmlDrkOutLabel.Text = null;

                this.xSmlComAmtLabel.Visible = false;
                this.xSmlComOutLabel.Visible = false;
                this.xSmallComboLabel.Visible = false;
                this.xSmlComAmtLabel.Text = null;
                this.xSmlComOutLabel.Text = null;


                this.xMedPopAmtLabel.Visible = false;
                this.xMedPopOutLabel.Visible = false;
                this.xMedPopLabel.Visible = false;
                this.xMedPopAmtLabel.Text = null;
                this.xMedPopOutLabel.Text = null;

                this.xMedCanAmtLabel.Visible = false;
                this.xMedCanOutLabel.Visible = false;
                this.xMedCandyLabel.Visible = false;
                this.xMedCanAmtLabel.Text = null;
                this.xMedCanOutLabel.Text = null;



                this.xMedDrkAmtLabel.Visible = false;
                this.xMedDrkOutLabel.Visible = false;
                this.xMedDrinkLabel.Visible = false;
                this.xMedDrkAmtLabel.Text = null;
                this.xMedDrkOutLabel.Text = null;


                this.xMedComAmtLabel.Visible = false;
                this.xMedComOutLabel.Visible = false;
                this.xMedComboLabel.Visible = false;
                this.xMedComAmtLabel.Text = null;
                this.xMedComAmtLabel.Text = null;


                this.xLrgPopAmtLabel.Visible = false;
                this.xLrgPopOutLabel.Visible = false;
                this.xLrgPopLabel.Visible = false;
                this.xLrgPopAmtLabel.Text = null;
                this.xLrgPopOutLabel.Text = null;


                this.xLrgCanAmtLabel.Visible = false;
                this.xLrgCanOutLabel.Visible = false;
                this.xLrgCandyLabel.Visible = false;
                this.xLrgCanAmtLabel.Text = null;
                this.xLrgCanOutLabel.Text = null;


                this.xLrgDrkAmtLabel.Visible = false;
                this.xLrgDrkOutLabel.Visible = false;
                this.xLargeDrinkLabel.Visible = false;
                this.xLrgDrkAmtLabel.Text = null;
                this.xLrgDrkOutLabel.Text = null;


                this.xLrgComAmtLabel.Visible = false;
                this.xLrgComOutLabel.Visible = false;
                this.xLrgComboLabel.Visible = false;
                this.xLrgComAmtLabel.Text = null;
                this.xLrgComOutLabel.Text = null;

                this.xTotalLabel.Visible = false;
                this.xTotalOutLabel.Visible = false;
                this.xTotalOutLabel.Text = null;

                this.xTenderOutLabel.Visible = false;
                this.xTenderLabel.Visible = false;
                this.xTenderOutLabel.Text = null;
            }
            else
            {
                MessageBox.Show("Please Calculate the Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xHelpMenuItem_Click(object sender, EventArgs e)
        {
            //opens the help menu
            Form help = new Help();
            help.ShowDialog();
        }

        private void xExitMenuItem_Click(object sender, EventArgs e)
        {
            //the exit menu item
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Dialog Exit box
            DialogResult response;

            response = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (response == DialogResult.Yes)
            {
                //ends the application
                Application.Exit();
            }







        }

        private void xCashButton_Click(object sender, EventArgs e)
        {
            //the cash tender method.
            if (this.xTotalOutLabel.Visible == true)
            {
                string cashtender;
                
                double change;
                cashtender = V1 + V2 + V3 + V4 + V5 + V6 + V7;
                
                if (string.IsNullOrEmpty(cashtender))
                {
                    // error message to make sure their is a cash amount
                    MessageBox.Show("Please Enter a Cash Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // sets the tender box visible and populates it
                    this.xTenderOutLabel.Text = "$" + cashtender;
                    this.xTenderLabel.Visible = true;
                    this.xTenderOutLabel.Visible = true;
                    cash = Convert.ToDouble(cashtender);
                    if (cash >= total)
                    {
                        change = cash - total;
                        this.xChangeLabel.Visible = true;
                        this.xChangeLabel.Text = "Change:";
                        this.xChangeOutLabel.Visible = true;
                        this.xChangeOutLabel.Text = change.ToString("C");

                        MessageBox.Show("Sale Completed");

                        total = 0;

                        tprice1 = 0;
                        tprice2 = 0;
                        tprice3 = 0;
                        tprice4 = 0;
                        tprice5 = 0;
                        tprice6 = 0;
                        tprice7 = 0;
                        tprice8 = 0;
                        tprice9 = 0;
                        tprice10 = 0;
                        tprice11 = 0;
                        tprice12 = 0;

                        V1 = null;
                        V2 = null;
                        V3 = null;
                        V4 = null;
                        V5 = null;
                        V6 = null;
                        V7 = null;

                        this.xChangeLabel.Visible = false;
                        this.xChangeOutLabel.Visible = false;

                        this.xSmlPopAmtLabel.Visible = false;
                        this.xSmlPopOutLabel.Visible = false;
                        this.xSmallPopLabel.Visible = false;
                        this.xSmlPopAmtLabel.Text = null;
                        this.xSmlPopOutLabel.Text = null;


                        this.xSmlCanAmtLabel.Visible = false;
                        this.xSmlCanOutLabel.Visible = false;
                        this.xSmlCandyLabel.Visible = false;
                        this.xSmlCanAmtLabel.Text = null;
                        this.xSmlCanOutLabel.Text = null;

                        this.xSmlDrkAmtLabel.Visible = false;
                        this.xSmlDrkOutLabel.Visible = false;
                        this.xSmlDrinkLabel.Visible = false;
                        this.xSmlDrkAmtLabel.Text = null;
                        this.xSmlDrkOutLabel.Text = null;

                        this.xSmlComAmtLabel.Visible = false;
                        this.xSmlComOutLabel.Visible = false;
                        this.xSmallComboLabel.Visible = false;
                        this.xSmlComAmtLabel.Text = null;
                        this.xSmlComOutLabel.Text = null;


                        this.xMedPopAmtLabel.Visible = false;
                        this.xMedPopOutLabel.Visible = false;
                        this.xMedPopLabel.Visible = false;
                        this.xMedPopAmtLabel.Text = null;
                        this.xMedPopOutLabel.Text = null;

                        this.xMedCanAmtLabel.Visible = false;
                        this.xMedCanOutLabel.Visible = false;
                        this.xMedCandyLabel.Visible = false;
                        this.xMedCanAmtLabel.Text = null;
                        this.xMedCanOutLabel.Text = null;



                        this.xMedDrkAmtLabel.Visible = false;
                        this.xMedDrkOutLabel.Visible = false;
                        this.xMedDrinkLabel.Visible = false;
                        this.xMedDrkAmtLabel.Text = null;
                        this.xMedDrkOutLabel.Text = null;


                        this.xMedComAmtLabel.Visible = false;
                        this.xMedComOutLabel.Visible = false;
                        this.xMedComboLabel.Visible = false;
                        this.xMedComAmtLabel.Text = null;
                        this.xMedComAmtLabel.Text = null;


                        this.xLrgPopAmtLabel.Visible = false;
                        this.xLrgPopOutLabel.Visible = false;
                        this.xLrgPopLabel.Visible = false;
                        this.xLrgPopAmtLabel.Text = null;
                        this.xLrgPopOutLabel.Text = null;


                        this.xLrgCanAmtLabel.Visible = false;
                        this.xLrgCanOutLabel.Visible = false;
                        this.xLrgCandyLabel.Visible = false;
                        this.xLrgCanAmtLabel.Text = null;
                        this.xLrgCanOutLabel.Text = null;


                        this.xLrgDrkAmtLabel.Visible = false;
                        this.xLrgDrkOutLabel.Visible = false;
                        this.xLargeDrinkLabel.Visible = false;
                        this.xLrgDrkAmtLabel.Text = null;
                        this.xLrgDrkOutLabel.Text = null;


                        this.xLrgComAmtLabel.Visible = false;
                        this.xLrgComOutLabel.Visible = false;
                        this.xLrgComboLabel.Visible = false;
                        this.xLrgComAmtLabel.Text = null;
                        this.xLrgComOutLabel.Text = null;

                        this.xTotalLabel.Visible = false;
                        this.xTotalOutLabel.Visible = false;
                        this.xTotalOutLabel.Text = null;

                        this.xTenderOutLabel.Visible = false;
                        this.xTenderLabel.Visible = false;
                        this.xTenderOutLabel.Text = null;
                    }
                    else if (cash < total)
                    {
                        MessageBox.Show("Not enough Cash", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        change = total - cash;
                        this.xChangeLabel.Visible = true;
                        this.xChangeOutLabel.Visible = true;
                        this.xChangeLabel.Text = "You Owe:";
                        this.xChangeOutLabel.Text = change.ToString("C");
                    }
                }
            }
            else
            {
                V1 = null;
                V2 = null;
                V3 = null;
                V4 = null;
                V5 = null;
                V6 = null;
                V7 = null;


                MessageBox.Show("Please Calculate the Total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xOneButton_Click(object sender, EventArgs e)
        {
            //Sets the value of the button
            if (V1 == null)
            {
                V1 = xOneButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xOneButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xOneButton.Text; 
            }

            else if (V4 == null)
            {

                V4 = xOneButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xOneButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xOneButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xOneButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void xTwoButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xTwoButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xTwoButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xTwoButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xTwoButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xTwoButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xTwoButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xTwoButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void xThreeButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xThreeButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xThreeButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xThreeButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xThreeButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xThreeButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xThreeButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xThreeButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void xFourButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xFourButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xFourButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xFourButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xFourButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xFourButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xFourButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xFourButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xFiveButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xFiveButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xFiveButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xFiveButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xFiveButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xFiveButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xFiveButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xFiveButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xSixButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xSixButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xSixButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xSixButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xSixButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xSixButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xSixButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xSixButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xSevenButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xSevenButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xSevenButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xSevenButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xSevenButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xSevenButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xSevenButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xSevenButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xEightButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xEightButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xEightButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xEightButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xEightButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xEightButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xEightButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xEightButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xNineButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xNineButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xNineButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xNineButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xNineButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xNineButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xNineButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xNineButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xZeroButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xZeroButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xZeroButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xZeroButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xZeroButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xZeroButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xZeroButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xZeroButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xDecimalButton_Click(object sender, EventArgs e)
        {//Sets the value of the button
            if (V1 == null)
            {
                V1 = xDecimalButton.Text;
            }

            else if (V2 == null)
            {

                V2 = xDecimalButton.Text;

            }

            else if (V3 == null)
            {

                V3 = xDecimalButton.Text;
            }

            else if (V4 == null)
            {

                V4 = xDecimalButton.Text;
            }
            else if (V5 == null)
            {

                V5 = xDecimalButton.Text;
            }
            else if (V6 == null)
            {

                V6 = xDecimalButton.Text;
            }
            else if (V7 == null)
            {

                V7 = xDecimalButton.Text;
            }
            else
            {
                MessageBox.Show("Tendered Amount to High for Cash. Please use a Credit Card.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void xAboutMenuItem_Click(object sender, EventArgs e)
        {
            Form About = new About();
            About.ShowDialog();
        }


        

    }
}
