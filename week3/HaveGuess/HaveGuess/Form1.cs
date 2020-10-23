using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 
namespace HaveGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaring global variable
        int randomNum;

        //Assigning a random number on FormLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            var random = new Random();
            randomNum = random.Next(1, 100);
        }

        //Developing the game
        private void btnCompare_Click(object sender, EventArgs e)
        {
            //Grabbing the user data
            var userNumber = nudInputNum.Value;

            //Comparing user data with the randomly selected number 
            //and showing the result to the user
            if (userNumber < randomNum)
            {
                lblResult.Text = "is less";
            }
            else if (userNumber > randomNum)
            {
                lblResult.Text = "is more";
            }

            else if (userNumber == randomNum)
            {
                label2.Text = "You are right!!!";
                lblResult.Text = "";
            }
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            //components.Dispose();
            //InitializeComponent();
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }
    }
}

