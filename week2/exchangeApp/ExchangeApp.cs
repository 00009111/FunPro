using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Grabbing and Converting the user input values
            var amount = Convert.ToDouble(tbxAmount.Text);
            var rate = Convert.ToDouble(tbxRate.Text);

            //Calculating and Converting
            var result = amount + amount / 100 * rate;
            result = Math.Round(result, 2);
            string readyResult = result.ToString();

            //Showing the result
            lblResult.Text = readyResult;
        }
    }
}
