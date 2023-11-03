using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void gunaElipsePanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (AdminPass.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if (AdminPass.Text == "123456789")
            {
                employees U = new employees();
                U.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Password Contact The Admin");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
