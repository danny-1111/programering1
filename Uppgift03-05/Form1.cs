using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift03_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int belopp = int.Parse(tbxBelopp.Text);
            int result;
            if (belopp <= 500) { result = 100; } else { result = 500; }
            lblSvar.Text = result.ToString();


        }
    }
}
