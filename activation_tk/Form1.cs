using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activation_tk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bnt_10home_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.tenhome);
        }

        private void bnt_10pro_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.tenpro);
        }

        private void bnt_11home_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.elevenhome);
        }

        private void bnt_11pro_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.elevenpro);
        }
    }
}
