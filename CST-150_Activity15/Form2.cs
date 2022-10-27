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
    public partial class luckyNumberFrm : Form
    {
        public luckyNumberFrm()
        {
            InitializeComponent();
        }

        private void luckyNumberFrm_Load(object sender, EventArgs e)
        {
            luckyNumberTxt.Text = luckyNumberGeneratorfrm.luckyString;
        }
    }
}
