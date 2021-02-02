using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift03_04
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
            string resulte = belopp.ToString();
            char b = resulte[0];
            lblHundralappar.Text = (int.Parse(b.ToString())*100).ToString();


        }
    }
}
