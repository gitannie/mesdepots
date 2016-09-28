using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton de base du chef de projet");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
