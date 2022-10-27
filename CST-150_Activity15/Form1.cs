using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity15
{
    public partial class luckyNumberGeneratorfrm : Form
    {
        public luckyNumberGeneratorfrm()
        {
            InitializeComponent();
        }
        //Declaring public string to pass to the second form
        public static string luckyString = "";
        private void luckyNumberBtn_Click(object sender, EventArgs e)
        {
            
            int luckyNumber = 0;
            Random r = new Random();
            int random = r.Next(0, 100);
            int a = 0;
            int b = (int)favoriteNumericUpDown.Value;
            int c = firstNameTxt.Text.Length;
            
            
            //Assigning the holliday's to the day of the month
            if(halloweenRadioButton.Checked)
            {
                a = 31;
            }
            if (thanksGivingRadioButton.Checked)
            {
                a = 28;
            }
            if(christmasRadioButton.Checked)
            {
                a = 25;
            }


            double x = Math.Sqrt(a + b + c);
            //Using quadratic formula for the lucky number
            luckyNumber = (a * (int)Math.Round(Math.Sqrt(x))) + (b * (int)Math.Round(x)) + (c);

            if(luckyNumber > 100)
            {
                luckyNumber = luckyNumber / 10;
            }
            if(luckyNumber > 1000)
            {
                luckyNumber = luckyNumber / 100;
            }
            //Assigning the lucky number to the public string
            luckyString = luckyNumber.ToString();
            //Creating an object of the lucky number form
            luckyNumberFrm f2 = new luckyNumberFrm();
            //Display the lucky number
            f2.Show();
              
        }
    }
}
