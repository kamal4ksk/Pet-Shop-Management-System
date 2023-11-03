using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petshopmanagementsystem
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            CountDogs();
            CountBirds();
            CountCats();
            CountFish();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True");

        private void home_Load(object sender, EventArgs e)
        {

        }
        private void CountDogs()
        {
            string Cat = "Dog";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ProductTbl where PrCat='"+Cat+"'" ,Con);                                                                                                                                                                                                                                                                                                                                                                   
             DataTable dt = new DataTable();
            sda.Fill(dt);
            Doglbl.Text = dt.Rows[0][0].ToString(); 
            Con.Close();
        }
        private void CountBirds()
        {
            string Cat = "Bird";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ProductTbl where PrCat='" + Cat + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Birdlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountCats()
        {
            string Cat = "Cat";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ProductTbl where PrCat='" + Cat + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Catslbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountFish()
        {
            string Cat = "Fish";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ProductTbl where PrCat='" + Cat + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Fishlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            customer U = new customer();
            U.Show();
            this.Hide();
        }

        private void gunaElipsePanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Bills U = new Bills();
            U.Show();
            this.Hide();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            login U = new login();
            U.Show();
            this.Hide();
        
    }

        private void Doglbl_Click(object sender, EventArgs e)
        {

        }
    }
}
