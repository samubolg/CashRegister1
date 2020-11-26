using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister1
{
    public partial class CashRegister : Form
    {
        //Global Variables
        double candyApplesCost = 15;
        double cheesecakesCost = 7;
        double peaksCost = 10;
        double taxRate = 0.13;
        double candyAppleTotal;
        double cheesecakeTotal;
        double peaksTotal;
        double subtotalTotal = 0;
        double taxTotal = 0;
        double orderTotal = 0;
        double tenderedTotal = 0;
        double changeTotal = 0;
        double tenderedAmount;
        public CashRegister()
        {
            InitializeComponent();
        }
        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                cheesecakeTotal = Convert.ToInt32(inputTextbox1.Text);
                peaksTotal = Convert.ToInt32(inputTextbox2.Text);
                candyAppleTotal = Convert.ToInt32(inputTextbox3.Text);
                subtotalTotal = candyAppleTotal * candyApplesCost + peaksTotal * peaksCost + cheesecakeTotal * cheesecakesCost;
                taxTotal = subtotalTotal * taxRate;
                orderTotal = subtotalTotal + taxTotal;
                outputLabel3.Text = orderTotal.ToString("C");
                outputLabel2.Text = taxTotal.ToString("C");
                outputLabel1.Text = subtotalTotal.ToString("C");
                noNumbersLabel1.Text = "";
            }
            catch
            {
                noNumbersLabel1.Text = "Please Enter a Numerical Value!";
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedTotal = Convert.ToDouble(tenderedTextbox.Text);
                changeTotal = tenderedTotal - orderTotal;
                changeOutput.Text = changeTotal.ToString("C");
                noNumbersLabel2.Text = "";
            }
            catch
            {
                noNumbersLabel2.Text = "Please Enter a Numerical Value!";
            }
        }
        private void ChangeOutput_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "RMCF .INC";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nOrder Number: 1477";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nNovember 26 2020";
            receiptLabel.Text += $"\n";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nChocolate Cheesecake x{cheesecakeTotal} @ {cheesecakesCost.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nPeaks                x{peaksTotal} @ {peaksCost.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nCandy Apples         x{candyAppleTotal} @ {candyApplesCost.ToString("C")}";
            receiptLabel.Text += $"\n";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nSubtotal              {subtotalTotal.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nTax                   {taxTotal.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nTotal                 {orderTotal.ToString("C")}";
            receiptLabel.Text += $"\n";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nTendered              {tenderedTotal.ToString("C")}";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nChange                {changeTotal.ToString("C")}";
            receiptLabel.Text += $"\n";
            Thread.Sleep(500);
            Refresh();
            receiptLabel.Text += $"\nHave a Nice Day!";
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            changeTotal = 0;
            tenderedTotal = 0;
            orderTotal = 0;
            taxTotal = 0;
            subtotalTotal = 0;
            candyAppleTotal = 0;
            peaksTotal = 0;
            cheesecakeTotal = 0;
            changeOutput.Text = "";
            inputTextbox1.Text = "";
            inputTextbox2.Text = "";
            inputTextbox3.Text = "";
            tenderedTextbox.Text = "";
            outputLabel1.Text = "";
            outputLabel2.Text = "";
            outputLabel3.Text = "";
            receiptLabel.Text = "";
        }
    }
}
