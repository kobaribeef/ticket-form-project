using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketProject
{
    /***
     * Triathlon events found at https://www.trifind.com
     * Marathon events found at https://findmymarathon.com/index.php
     * 5k events found through Google events search per state
     * Bicycle races found through Google events search
     * Tough Mudder runs found through Google events search
     * */
    public partial class Form1 : Form
    {

        public void clearForm()
        {
            Utilities.ResetAllControls(this);
            txtPayMethodCost.Text = "";
            invalidNameLabel1.Hide();
            invalidNameLabel2.Hide();
        }

        string[] midwestRegions = new string[]
        {
            "Iowa", "Illinois", "Wisconsin"
        };

        string[] months = new string[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        string[] events;

        string[] paymentType = new string[]
        {
            "Credit Card", "Paypal"
        };

        string firstName;
        string lastName;
        string activity;
        string region;
        string month;
        string eventPicked;
        string qty;
        string payType;
        decimal finalCost;
        decimal pricePerTicket;
        decimal payMethodCost;

        int selectedActivity;

        public void enableSubmit()
        {
            txtFinalCost.Text = "";
            if (!(cboActivity.SelectedIndex == -1) && !(cboRegion.SelectedIndex == -1) && !(cboMonth.SelectedIndex == -1) && !(cboEvent.SelectedIndex == -1) && !(cboTicketQty.SelectedIndex == -1) && !(cboPaymentType.SelectedIndex == -1) && (validText(txtFirstName.Text)) && (validText(txtLastName.Text)))
            {
                btnPurchase.Enabled = true;
                finalCost = (pricePerTicket * Convert.ToDecimal(cboTicketQty.SelectedItem)) * (1.0m + payMethodCost);
                txtFinalCost.Text = $"${Math.Round(finalCost, 2)}";
            }
            else
            {
                btnPurchase.Enabled = false;
            }
        }

        public bool validText(string name)
        {
            Regex regex = new Regex("^(?=.{1,40}$)[a-zA-Z]+(?:[-'\\s][a-zA-Z]+)*$");
            return regex.IsMatch(name);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboActivity.Items.Add("Triathlon");
            cboActivity.Items.Add("Marathon");
            cboActivity.Items.Add("5K Run/Walk");
            cboActivity.Items.Add("Bicycle Race");
            cboActivity.Items.Add("Tough Mudder Run");
            cboRegion.Items.AddRange(midwestRegions);
            cboMonth.Items.AddRange(months);
            cboTicketQty.Items.AddRange(Enumerable.Range(1, 100).Cast<object>().ToArray());
            cboPaymentType.Items.AddRange(paymentType);
            invalidNameLabel1.Hide();
            invalidNameLabel2.Hide();
            enableSubmit();
        }

        private void cboActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEvent.ResetText();
            cboEvent.Items.Clear();
            cboRegion.SelectedIndex = -1;
            txtChosenEvent.Text = "";
            selectedActivity = cboActivity.SelectedIndex;

            switch (selectedActivity)
            {
                case 0:
                    pricePerTicket = 24.95m;
                    txtPricePerTicket.Text = $"${pricePerTicket}";
                    break;
                case 1:
                    pricePerTicket = 19.95m;
                    txtPricePerTicket.Text = $"${pricePerTicket}";
                    break;
                case 2:
                    pricePerTicket = 14.95m;
                    txtPricePerTicket.Text = $"${pricePerTicket}";
                    break;
                case 3:
                    pricePerTicket = 9.95m;
                    txtPricePerTicket.Text = $"${pricePerTicket}";
                    break;
                case 4:
                    pricePerTicket = 34.95m;
                    txtPricePerTicket.Text = $"${pricePerTicket}";
                    break;
            }
            enableSubmit();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        { 
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            activity = Convert.ToString(cboActivity.SelectedItem);
            region = Convert.ToString(cboRegion.SelectedItem);
            month = Convert.ToString(cboMonth.SelectedItem);
            eventPicked = Convert.ToString(cboEvent.SelectedItem);
            qty = Convert.ToString(cboTicketQty.SelectedItem);
            payType = Convert.ToString(cboPaymentType.SelectedItem);

            MessageBox.Show($"Hello {firstName} {lastName},\nYou have purchased {qty} ticket(s) for {eventPicked}.\nPlease report to {region} in {month}.\nYour total cost is ${Math.Round(finalCost, 2)}, paid by {payType}.");
            clearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEvent.ResetText();
            cboEvent.Items.Clear();
            int selectedRegion = cboRegion.SelectedIndex;
            //selectedActivity == 0 is for triathlons. see cboActivity selectedIndexChanged method
            //region selection is as follows- 0: Iowa | 1: Illinois | 2: Wisconsin
            if(selectedActivity == 0)
            {
                switch (selectedRegion)
                {
                    case 0:
                        events = new string[]
                        {
                                "Triple D Winter Race", "TriByKnight Triathlon", "Pigman Triathlon", "Bluff Creek Triathlon"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 1:
                        events = new string[]
                        {
                            "ET Indoor Triathlon", "Abe's Mini Triathlon", "Illinois Triathlon Championships", "Twin Lakes Triathlon"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 2:
                        events = new string[]
                        {
                            "Stride, Ride, Glide Tri", "Grantsburg Adventure Triathlon", "Elkhart Lake Triathlon", "Ironman 70.3 Wisconsin"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                }
            }
            //selectedActivity == 1 is for Marathons.
            if(selectedActivity == 1)
            {
                switch (selectedRegion)
                {
                    case 0:
                        events = new string[]
                        {
                            "Des Moines Marathon", "Run CRANDIC Marathon", "IronHorse Marathon", "Run4Troops Marathon"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 1:
                        events = new string[]
                        {
                            "Illinois Marathon", "Chicago Marathon", "Barrel Marathon", "Quad Cities Marathon"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 2:
                        events = new string[]
                        {
                            "Grandad Marathon", "Lakefront Marathon", "Madison Marathon", "Fox Cities Marathon"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                }
            }
            //selectedActivity == 2 is for 5K Run/Walks
            if(selectedActivity == 2)
            {
                switch(selectedRegion)
                {
                    case 0:
                        events = new string[]
                        {
                            "Chocoholic Frolic 5K", "Red Shoe Run & Walk 5K", "Donut Run 5K", "Annual RiverRun 5K"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 1:
                        events = new string[]
                        {
                            "Illinois 5K Run/Walk", "St. Patrick's Day Fun Run 5K", "Run For Hope", "SuperHEARo 5K"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 2:
                        events = new string[]
                        {
                            "Sweet Home Milwaukee 5K", "Put Homelessness to Rest 5K", "Annual Autism Awareness 5K", "Fleis Nightfall Frolic 2020"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                }
            }
            //selectedActivity == 3 is for bicycle races
            if(selectedActivity == 3)
            {
                switch(selectedRegion)
                {
                    case 0:
                        events = new string[]
                        {
                            "Iowa Spring Classic", "Iowa Gravel Classic", "Break The Cycle 200", "Oktoberfest Bike Ride 2020"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 1:
                        events = new string[]
                        {
                            "Elgin Bike Ride", "2020 Ride Across Illinois (RAIL) North", "Rough Road 100", "Bike the Drive"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 2:
                        events = new string[]
                        {
                            "Green Lake 100 Bike Ride", "Tour of America's Dairyland", "Greenwood 38 Mile Bike Race", "Ride Across Wisconsin"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                }
            }
            //selectedActivity == 4 is for Tough Mudder runs
            if(selectedActivity == 4)
            {
                switch(selectedRegion)
                {
                    case 0:
                        events = new string[]
                        {
                            "Woolstock Iowa Conquer the Gauntlet", "J Fit Mud Run", "One Tough Cookie", "The Ridge Run"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 1:
                        events = new string[]
                        {
                            "Tough Mudder Chicago", "Toughest Mudder Chicago", "MuckFest 2020", "Spartan Race"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                    case 2:
                        events = new string[]
                        {
                            "Tough Mudder Wisconsin", "Abominable Snow Race", "Alpine Adventure Challenge", "Wisconsin Tough Mudder Classic"
                        };
                        cboEvent.Items.AddRange(events);
                        break;
                }
            }
            enableSubmit();
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableSubmit();
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableSubmit();
            txtChosenEvent.Text = Convert.ToString(cboEvent.SelectedItem);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            enableSubmit();
            if (!validText(txtFirstName.Text))
            {
                invalidNameLabel1.Show();
            }
            else
            {
                invalidNameLabel1.Hide();
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            enableSubmit();
            if (!validText(txtLastName.Text))
            {
                invalidNameLabel2.Show();
            }
            else
            {
                invalidNameLabel2.Hide();
            }
        }

        private void cboTicketQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableSubmit();
            txtTicketQty.Text = Convert.ToString(cboTicketQty.SelectedItem);
        }

        private void cboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPayMethod.Text = Convert.ToString(cboPaymentType.SelectedItem);
            if (cboPaymentType.SelectedIndex == 0)
            {
                payMethodCost = .05m;
            }
            else if (cboPaymentType.SelectedIndex == 1)
            {
                payMethodCost = .015m;
            }
            txtPayMethodCost.Text = $"{payMethodCost * 100:0.00}%";
            enableSubmit();
        }
    }
}
