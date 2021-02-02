using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int teckenkod = int.Parse(tbxTeckenkod.Text);
            char tecken = (char)teckenkod;

            lblSvar.Text = teckenkod.ToString() + " har tecken " + tecken.ToString();

        }
    }
}
