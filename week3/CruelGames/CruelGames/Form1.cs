using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruelGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbtnYoung.Checked) 
            {
                MessageBox.Show("Sorry, you are too young for the Cruel Games");
            }
            else if (rbtnMiddle.Checked)
            {
                MessageBox.Show("Let's rock");
            }
            else if (rbtnOld.Checked)
            {
                MessageBox.Show("You're too old, grandpa");
            }

            Application.Exit();
        }
    }
}
