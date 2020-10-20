using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Grabbing the user input 
            var userName = txbName.Text;
            var deposit = nudDeposit.Value;
            var inRate = nudRate.Value;

            //Doing the calculation
            var result = deposit + deposit * inRate / 100;
            result = Math.Round(result, 2);

            //Converting the result to string
            var stringResult = result.ToString();

            //Showing the user the result
            string message;
            message = "User : " + userName + "\n";
            message += "Deposit Amount : " +deposit.ToString() + "\n";
            message += "Interest Rate : " + inRate.ToString() + "\n";
            message += "Your Aggregate Money : " + stringResult;
            MessageBox.Show(message);

        }

        private void nudDeposit_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
