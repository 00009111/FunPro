using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkDict
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
            var enWord = tbxEnglish.Text;

            //Translating to Elbonian
            var letterIndex = Convert.ToDouble(enWord.Length);
            var middleIndex = Convert.ToInt32(Math.Floor(letterIndex / 2));

            //Creating the new word
            var elWord = enWord.Substring(middleIndex) + enWord.Substring(0,middleIndex);

            //Showing the result to the user
            tbxElbanian.Text = elWord;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
