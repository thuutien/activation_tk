using System;
using System.Diagnostics;
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
            Process.Start("https://github.com/thuutien");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This software is required to run as Adminstrator. \nUse this software with your responsibilities. \nThis software was made for educational purposes only!");

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

        private void btn_server2019e_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.server2019e);

        }

        private void btn_server2019s_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.server2019s);
        }

        private void btn_server2019d_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.server2019d);
        }

        private void btn_server2022s_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.server2022s);
        }

        private void btn_server2022d_Click(object sender, EventArgs e)
        {
            Helper.activate(Windows.server2022d);
        }

        private void btn_office2021p_Click(object sender, EventArgs e)
        {
            Helper.officeActivation(Office.Office2021p64);
        }

        private void btn_office2021p86_Click(object sender, EventArgs e)
        {
            Helper.officeActivation(Office.Office2022p86);
        }
    }
}
