using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btxKör_Click(object sender, EventArgs e)
        {
           double decimaltal = double.Parse(tbxDecimaltal.Text)+0.5;

            double result = Math.Floor(decimaltal);

            lblHeltal.Text = result.ToString();

        }
    }
}
