using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petshopmanagementsystem
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            timer1.Start(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
        int startp = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 4;
            progressbar.Value = startp;
            percentage.Text = startp + "%";
            if (progressbar.Value==100)
            {
             progressbar.Value = 0;
                login obj = new login();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }

        }
    }
}
