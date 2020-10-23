using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //Grabbing the user data
            var inputNum = nudYear.Value;

            //Checking whether it is a leap year
            if (inputNum>1582 & inputNum % 4 == 0 )
            {
                if (inputNum % 100==0)
                {
                    MessageBox.Show("It's not a Leap Year");
                }
                else if (inputNum % 400 == 0)
                {
                    MessageBox.Show("It's a Leap Year");
                };

            }
            else
            {
                MessageBox.Show("It's not a Leap Year");
            }
        }
    }
}
