using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
{
    public partial class ConverterForm : Form
    {
        Weight userWeight = new Weight();
        Temperature userTemp = new Temperature();
        Speed userSpeed = new Speed();

        public ConverterForm()
        {
            InitializeComponent();

            txtBoxInput.Select();
            txtBoxInput.Focus();

            //LinkLabel.Link link = new LinkLabel.Link();
            //link.LinkData = "http://www.iamjoanne.info";
            //lnkLblToWebsite.Links.Add(link);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double userInput;

            if(txtBoxInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter a number in the text box.");
                txtBoxInput.Focus();
            }
            else if(double.TryParse(txtBoxInput.Text, out userInput) == false)
            {
                MessageBox.Show("Invalid input: Numbers only.");
                txtBoxInput.Clear();
                txtBoxInput.Focus();
            }
            else
            {
                if (rdBtnLbKg.Checked)
                {
                    userWeight.WeightInput = userInput;
                    lblOutput.Text = userInput + " lbs = " + userWeight.LbsToKg().ToString() + " kg";
                }
                else if (rdBtnKgLbs.Checked)
                {
                    userWeight.WeightInput = userInput;
                    lblOutput.Text = userInput + " kg = " + userWeight.KgToLbs().ToString() + " lbs";
                }
                else if (rdBtnFahrCel.Checked)
                {
                    userTemp.TempInput = userInput;
                    lblOutput.Text = userInput + " °F = " + userTemp.FahrToCel().ToString() + " °C";
                }
                else if (rdBtnCelFahr.Checked)
                {
                    userTemp.TempInput = userInput;
                    lblOutput.Text = userInput + " °C = " + userTemp.CelToFahr().ToString() + " °F";
                }
                else if (rdBtnKmphMph.Checked)
                {
                    userSpeed.SpeedInput = userInput;
                    lblOutput.Text = userInput + " km/h = " + userSpeed.KmphToMph().ToString() + " mph";
                }
                else if (rdBtnMphKmph.Checked)
                {
                    userSpeed.SpeedInput = userInput;
                    lblOutput.Text = userInput + " mph = " + userSpeed.MphToKmph().ToString() + " km/h";
                }
            }
        }

        private void lnkLblToWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnkLblToWebsite.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.iamjoanne.info");
        }

        private void lnkLblHow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnkLblHow.LinkVisited = true;
            MessageBox.Show("How to use Converter App:\n\n-Enter a number to convert in the text box.\n\n-Choose which units to convert your number to and from.\n\n-Click \"Convert\" button and calculation displays at the bottom.\n\nFor any issues, please contact tech@iamjoanne.info", "How to use Converter App");
        }
    }
}
